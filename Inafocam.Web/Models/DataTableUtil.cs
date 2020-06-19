using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Andamios.Web.Models
{
    public class DataTableUtil
    {
        public class DataTablesSearch
        {
            public string value { get; set; }
            public bool regex { get; set; }
        }

        public class DataTablesColumn
        {
            public string data { get; set; }
            public string name { get; set; }
            public bool searchable { get; set; }
            public bool orderable { get; set; }
            public DataTablesSearch search { get; set; }
            //public Search search { get; set; }
        }

        public class DataTablesOrder
        {
            public string dir { get; set; }
            public int column { get; set; }
        }

        //[System.Web.Mvc.ModelBinder(typeof(DataTablesModelBinder))]
        public class DataTablesRequestParams
        {
            public int draw { get; set; }
            public int start { get; set; }
            public int length { get; set; }
            public int? RecCount { get; set; }
            public ICollection<DataTablesColumn> columns { get; set; }
            public ICollection<DataTablesOrder> order { get; set; }
            public DataTablesSearch search { get; set; }
            public string rnc { get; set; }

            public int GetCount()
            {
                return RecCount.HasValue ? RecCount.Value : 0;
            }

            public DataTablesModel BuildRequestModel(object data)
            {
                return new DataTablesModel() { draw = this.draw, recordsTotal = this.GetCount(), totalRecordsFiltered = this.GetCount(), recordsFiltered = this.GetCount(), data = data };
            }

            public DataTablesModel BuildRequestModel<T>(IQueryable<T> data)
            {
                if (this.start == 0)
                {
                    this.RecCount = data.Count();
                }

                int cnt = this.GetCount();

                //No paginar si no hay suficientes registros.
                //if(cnt < length)
                //{
                //    return new DataTablesModel
                //    {
                //        draw = this.draw,
                //        recordsFiltered = cnt,
                //        totalRecordsFiltered = cnt,
                //        recordsTotal = cnt,
                //        data = data
                //    };
                //}

                return new DataTablesModel
                {
                    draw = this.draw,
                    recordsFiltered = cnt,
                    totalRecordsFiltered = cnt,
                    recordsTotal = cnt,
                    data = data.Skip(this.start).Take(this.length)
                };
            }

            public DataTablesModel BuildFilteredModel<T>(IQueryable<T> data)
            {
                var _where = this.BuildDynamicWhere().ToString();
                var _order = this.GetOrderBy();

                //if (_where != "")
                //{
                //    data = data.Where(_where);
                //}

                if (this.start == 0)
                {
                    this.RecCount = data.Count();
                }

                int cnt = this.GetCount();

                //if (_order != "")
                //{
                //    data = data.OrderBy(_order);
                //}

                return new DataTablesModel()
                {
                    draw = this.draw,
                    recordsFiltered = cnt,
                    totalRecordsFiltered = cnt,
                    recordsTotal = cnt,
                    data = data.Skip(this.start).Take(this.length).ToList()
                };

            }

            public virtual StringBuilder BuildDynamicWhere()
            {
                var strings = new StringBuilder();
                bool l1 = true;
                string field;

                foreach (var column in this.columns)
                {
                    if (column.searchable && !string.IsNullOrEmpty(column.search.value))
                    {
                        field = column.name ?? column.data;

                        if (field != "function")
                        {
                            //Por el momento vamos por "Like"
                            if (l1)
                            {
                                strings.AppendLine(field + ".Contains(\"" + column.search.value + "\") ");
                                l1 = false;
                                continue;
                            }
                            strings.AppendLine(" && " + field + ".Contains(\"" + column.search.value + "\") ");
                        }
                    }
                }

                return strings;
            }

            public virtual StringBuilder BuildDynamicWhere<T>()
            {
                var strings = new StringBuilder();
                bool l1 = true;
                string field;

                foreach (var column in this.columns)
                {
                    if (column.searchable && !string.IsNullOrEmpty(column.search.value))
                    {
                        field = column.name ?? column.data;

                        if (field != "function")
                        {

                            var type = typeof(T).GetProperty(field).PropertyType.ToString();
                            var condition = ".Contains(\"" + column.search.value + "\") ";
                            switch (type)
                            {
                                default:
                                case "System.Int32":
                                    condition = " == " + column.search.value;
                                    break;
                                //case "System.DateTime":
                                //    condition = ".Equals(\"" + column.search.value + "\") ";
                                //    break;
                                case "System.String":
                                    condition = ".Contains(\"" + column.search.value + "\") ";
                                    break;
                            }

                            if (l1)
                            {
                                strings.AppendLine(field + condition);
                                l1 = false;
                                continue;
                            }
                            strings.AppendLine(" && " + field + condition);
                        }
                    }
                }

                return strings;
            }

            public virtual StringBuilder BuildDynamicWhereStartsWith()
            {
                var strings = new StringBuilder();
                bool l1 = true;

                foreach (var column in this.columns)
                {
                    if (column.data != "function" && column.searchable && !string.IsNullOrEmpty(column.search.value))
                    {
                        //Por el momento vamos por "Like"
                        if (l1)
                        {
                            strings.AppendLine((column.name ?? column.data) + ".StartsWith(\"" + column.search.value + "\") ");
                            l1 = false;
                            continue;
                        }
                        strings.AppendLine(" && " + (column.name ?? column.data) + ".StartsWith(\"" + column.search.value + "\") ");
                    }
                }

                return strings;
            }

            public virtual string GetOrderBy()
            {
                //string order = "";
                //foreach (var o in this.order)
                //{
                //    var element = this.columns.ElementAt(o.column);

                //    if(element != null){
                //        order += (element.name ?? element.data);
                //    }
                //}
                if (this.order != null)
                {
                    var orderElement = this.order.FirstOrDefault();

                    if (orderElement != null)
                    {
                        var column = this.columns.ElementAt(orderElement.column);

                        if (column != null)
                        {
                            string _col = (column.name ?? column.data);

                            if (_col == "function")
                            {
                                return "";
                            }
                            return _col + " " + orderElement.dir;
                        }
                    }
                }

                return "";
            }
        }
    }
}