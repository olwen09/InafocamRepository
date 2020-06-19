//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using Andamios.Core.Entities;
//using Andamios.Core.Interfaces;
//using Andamios.Web.Helpers;

//namespace Andamios.Web.Models
//{
//    public class SearchbarModel
//    {
//        public string Filtro { get; set; }

//        //[Required(ErrorMessage = "El {0} es requerido ")]
//        public string Categoria { get; set; }
//        public int ResultCount { get; set; }
//        public string Total { get; set; }
//        /// <summary>
//        /// El controlador o módulo en el que se está mostrando el modelo
//        /// </summary>
//        public string Modulo { get; set; }
//        public List<ISearchbar> Resultados { get; set; }
//        public Pager Pager { get; set; }

//    }

//    public class ClaseResult : ISearchbar
//    {
//        public int TipoProductoId { get; set; }
//        public string Nombre { get; set; }
//        public string Descripcion { get; set; }
//        public Pager Pager { get; set; }
//        public virtual ICollection<Core.Entities.Inventario> Inventario { get; set; }
//    }

//    public class ConteoDevolucionResult : ISearchbar
//    {
//        public ConteoDevolucion ConteoDev { get; set; }
//        public Pager Pager { get; set; }

//    }

//    public class ConduceDevolucionResult : ISearchbar
//    {
//        public ConduceDevolucion ConduceDev { get; set; }
//        public Pager Pager { get; set; }

//    }

//    public class ClienteResult : ISearchbar
//    {
//        public Cliente Cliente { get; set; }
//        public Pager Pager { get; set; }

//    }

//    public class ProyectoResult : ISearchbar
//    {
//        public Proyecto Proyecto { get; set; }
//        public Pager Pager { get; set; }

//    }

//    public class InventarioResult : ISearchbar
//    {
//        public int InventarioId { get; set; }
//        public string Imagen { get; set; }
//        public string CodigoProducto { get; set; }
//        public string Descripcion { get; set; }
//        public decimal? PrecioVenta { get; set; }
//        public decimal? PrecioRentaFija { get; set; }
//        public string ClaseProducto { get; set; }
//        public int? TipoProductoId { get; set; }
//        public int TotalIngresado { get; set; }
//        public int? TotalRentado { get; set; }
//        public int? TotalOrdenado { get; set; }
//        public decimal? Costo { get; set; }
//        public virtual TipoProducto TipoProducto { get; set; }
//        public Pager Pager { get; set; }

//    }

//    public class ConteoResult : ISearchbar
//    {
//        public ConteoDespacho Conteo { get; set; }

//        public Pager Pager { get; set; }
//    }

//    public class ConduceResult : ISearchbar
//    {
//        public ConduceDespacho Conduce { get; set; }

//        public Pager Pager { get; set; }
//    }


//    public class ContratoResult : ISearchbar
//    {
//        public Cotizacion Contrato { get; set; }
//        public bool HasPiezas { get; set; }
//        public Pager Pager { get; set; }

//    }

//    public class FacturaResult : ISearchbar
//    {
//        public Factura Factura { get; set; }
//        public Pager Pager { get; set; }
//    }

//    public class ReciboResult : ISearchbar
//    {
//        public Recibo Recibo { get; set; }
//        public Pager Pager { get; set; }
//    }
//    public class DepositoResult : ISearchbar
//    {
//        public DepositoCliente Deposito { get; set; }
//        public Pager Pager { get; set; }
//    }


//}