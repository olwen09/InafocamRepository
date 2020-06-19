namespace Andamios.Web.Models
{
    public class DataTablesModel
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public int totalRecordsFiltered { get; set; }
        public object data { get; set; }

        public DataTablesModel(int draw, int recordsTotal, int recordsFiltered, int totalRecordsFiltered, object data)
        {
            this.draw = draw;
            this.recordsTotal = recordsTotal;
            this.recordsFiltered = recordsFiltered;
            this.totalRecordsFiltered = totalRecordsFiltered;
            this.data = data;
        }

        public DataTablesModel()
        {
        }
    }
}