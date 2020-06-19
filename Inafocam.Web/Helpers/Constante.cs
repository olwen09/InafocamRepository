using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Andamios.Web.Helpers
{
    public class Constante
    {
        // constantes estaticas
        public static readonly string Alquiler = "Alquiler";
        public static readonly string Permission = "Permissions";
        public static readonly string Module = "Module";
        public const string Despacho = "DESPACHO";
        public const string Recurrente = "RECURRENTE";
        public const string Devolucion = "DEVOLUCION";

        public const string Facturacion = "Facturacion";
        public const string Cxc = "CuentasPorCobrar";
        public const string Deposito = "Deposito";
        public const string Recibo = "Recibo";
        public const string Impresion = "Impresion";
        // constantes no estaticas
        //public const string ClienteCanRead = "CLIENTE.Read";

        #region Permisos
        // PERMISOS
        //CLIENTE =============================

        public const string ClienteCanRead = ModulosClaims.Cliente + ".Read";
        public const string ClienteCanCreate = ModulosClaims.Cliente + ".Create";
        public const string ClienteCanUpdate = ModulosClaims.Cliente + ".Update";
        public const string ClienteCanAdmin = ModulosClaims.Cliente + ".Admin";

        //SUPLIDOR =============================

        public const string SuplidorCanRead = ModulosClaims.Suplidor + ".Read";
        public const string SuplidorCanCreate = ModulosClaims.Suplidor + ".Create";
        public const string SuplidorCanUpdate = ModulosClaims.Suplidor + ".Update";
        public const string SuplidorCanAdmin = ModulosClaims.Suplidor + ".Admin";

        //Inventario =============================

        public const string InventariorCanRead = ModulosClaims.Inventario + ".Read";
        public const string InventarioCanCreate = ModulosClaims.Inventario + ".Create";
        public const string InventarioCanUpdate = ModulosClaims.Inventario + ".Update";
        public const string InventarioCanAdmin = ModulosClaims.Inventario + ".Admin";

        //Contrato =============================

        public const string ContratoCanRead = ModulosClaims.Contratos + ".Read";
        public const string ContratoCanCreate = ModulosClaims.Contratos + ".Create";
        public const string ContratoCanUpdate = ModulosClaims.Contratos + ".Update";
        public const string ContratoCanAdmin = ModulosClaims.Contratos + ".Admin";

        //CuentasPorCobrar=============================

        public const string CuentasPorCobrarCanRead = ModulosClaims.CuentaporCobrar + ".Read";
        public const string CuentasPorCobrarCanCreate = ModulosClaims.CuentaporCobrar + ".Create";
        public const string CuentasPorCobrarCanUpdate = ModulosClaims.CuentaporCobrar + ".Update";
        public const string CuentasPorCobrarCanAdmin = ModulosClaims.CuentaporCobrar + ".Admin";

        //Usuario=============================

        public const string UsuarioCanRead = ModulosClaims.Usuario + ".Read";
        public const string UsuariorCanCreate = ModulosClaims.Usuario + ".Create";
        public const string UsuarioCanUpdate = ModulosClaims.Usuario + ".Update";
        public const string UsuarioCanAdmin = ModulosClaims.Usuario + ".Admin";

        //Facturacion=============================

        public const string FacturaciónCanRead = ModulosClaims.Facturación + ".Read";
        public const string FacturaciónCanCreate = ModulosClaims.Facturación + ".Create";
        public const string FacturaciónCanUpdate = ModulosClaims.Facturación + ".Update";
        public const string FacturaciónCanAdmin = ModulosClaims.Facturación + ".Admin";

        //ConteoDespacho=============================

        public const string ConteoDespachoCanRead = ModulosClaims.ConteoDespacho + ".Read";
        public const string ConteoDespachoCanCreate = ModulosClaims.ConteoDespacho + ".Create";
        public const string ConteoDespachoCanUpdate = ModulosClaims.ConteoDespacho + ".Update";
        public const string ConteoDespachoCanAdmin = ModulosClaims.ConteoDespacho + ".Admin";

        //ConduceDespacho=============================

        public const string ConduceDespachoCanRead = ModulosClaims.ConduceDespacho + ".Read";
        public const string ConduceDespachoCanCreate = ModulosClaims.ConduceDespacho + ".Create";
        public const string ConduceDespachoCanUpdate = ModulosClaims.ConduceDespacho + ".Update";
        public const string ConduceDespachoCanAdmin = ModulosClaims.ConduceDespacho + ".Admin";

        //ConteoDevolución=============================

        public const string ConteoDevoluciónCanRead = ModulosClaims.ConteoDevolución + ".Read";
        public const string ConteoDevoluciónCanCreate = ModulosClaims.ConteoDevolución + ".Create";
        public const string ConteoDevoluciónCanUpdate = ModulosClaims.ConteoDevolución + ".Update";
        public const string ConteoDevoluciónCanAdmin = ModulosClaims.ConteoDevolución + ".Admin";

        // ConduceDevolución=============================

        public const string ConduceDevoluciónCanRead = ModulosClaims.ConduceDevolución + ".Read";
        public const string ConduceDevoluciónCanCreate = ModulosClaims.ConduceDevolución + ".Create";
        public const string ConduceDevoluciónCanUpdate = ModulosClaims.ConduceDevolución + ".Update";
        public const string ConduceDevoluciónCanAdmin = ModulosClaims.ConduceDevolución + ".Admin";

        // CuentaporCobrar=============================

        public const string CuentaporCobrarCanRead = ModulosClaims.CuentaporCobrar + ".Read";
        public const string CuentaporCobrarCanCreate = ModulosClaims.CuentaporCobrar + ".Create";
        public const string CuentaporCobrarCanUpdate = ModulosClaims.CuentaporCobrar + ".Update";
        public const string CuentaporCobrarCanAdmin = ModulosClaims.CuentaporCobrar + ".Admin";

        // CambioInventario=============================

        public const string CambioInventarioCanRead = ModulosClaims.CambioInventario + ".Read";
        public const string CambioInventarioCanCreate = ModulosClaims.CambioInventario + ".Create";
        public const string CambioInventarioCanUpdate = ModulosClaims.CambioInventario + ".Update";
        public const string CambioInventarioCanAdmin = ModulosClaims.CambioInventario + ".Admin";

        // TipodeInventario=============================

        public const string TipodeInventarioCanRead = ModulosClaims.TipodeInventario + ".Read";
        public const string TipodeInventarioCanCreate = ModulosClaims.TipodeInventario + ".Create";
        public const string TipodeInventarioCanUpdate = ModulosClaims.TipodeInventario + ".Update";
        public const string TipodeInventarioCanAdmin = ModulosClaims.TipodeInventario + ".Admin";

        // IngresoInvnetario=============================

        public const string IngresoInvnetarioCanRead = ModulosClaims.IngresoInvnetario + ".Read";
        public const string IngresoInvnetarioCanCreate = ModulosClaims.IngresoInvnetario + ".Create";
        public const string IngresoInvnetarioCanUpdate = ModulosClaims.IngresoInvnetario + ".Update";
        public const string IngresoInvnetarioCanAdmin = ModulosClaims.IngresoInvnetario + ".Admin";

        // Reportes=============================

        public const string ReportesCanRead = ModulosClaims.Reportes + ".Read";
        public const string ReportesCanCreate = ModulosClaims.Reportes + ".Create";
        public const string ReportesCanUpdate = ModulosClaims.Reportes + ".Update";
        public const string ReportesCanAdmin = ModulosClaims.Reportes + ".Admin";

        // Rol=============================

        public const string RolCanRead = ModulosClaims.Rol + ".Read";
        public const string RolCanCreate = ModulosClaims.Rol + ".Create";
        public const string RolCanUpdate = ModulosClaims.Rol + ".Update";
        public const string RolCanAdmin = ModulosClaims.Rol + ".Admin";

        // Proyecto=============================

        public const string ProyectoCanRead = ModulosClaims.Proyecto + ".Read";
        public const string ProyectoCanCreate = ModulosClaims.Proyecto + ".Create";
        public const string ProyectoCanUpdate = ModulosClaims.Proyecto + ".Update";
        public const string ProyectoCanAdmin = ModulosClaims.Proyecto + ".Admin";

        #endregion

    }

    public static class ModulosClaims
    {
        // MODULOS
        public const string Cliente = "CL";
        public const string Proyecto = "PR";
        public const string Comprobantes = "CP";
        public const string TipoComprobante = "TP";
        public const string Contratos = "CT";
        public const string ConteoDespacho = "CTD";
        public const string ConduceDespacho = "CDD";
        public const string ConteoDevolución = "CTV";
        public const string ConduceDevolución = "CDV";
        public const string CuentaporCobrar = "CXC";
        public const string Facturación = "FTC";
        public const string Inventario = "INV";
        public const string CambioInventario = "CBI";
        public const string TipodeInventario = "TI";
        public const string IngresoInvnetario = "II";
        public const string Reportes = "RP";
        public const string Suplidor = "SP";
        public const string Usuario = "US";
        public const string Rol = "ROL";
        public const string Recibo = "REC";
    }
}
