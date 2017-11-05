//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta_
    {
        public string idCaja { get; set; }
        public int idDoc { get; set; }
        public int idCorrelativo { get; set; }
        public int tipoDeVenta { get; set; }
        public string documento { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public bool EsBoleta { get; set; }
        public bool facturado { get; set; }
        public bool anulado { get; set; }
        public int numPasajeros { get; set; }
        public bool pagadoAlConductor { get; set; }
        public bool clientePago { get; set; }
        public System.DateTime fechaFacturacion { get; set; }
        public double totalAPagar { get; set; }
        public double montoDePagoEnSoles { get; set; }
        public double igvTotal { get; set; }
        public double montoDePagoEnMoneda { get; set; }
        public double montoDelVueltoEnSoles { get; set; }
        public Nullable<int> idMoneda { get; set; }
        public double CotizacionMoneda { get; set; }
        public int mesVencimientoTargeta { get; set; }
        public int anioVencimientoTargeta { get; set; }
        public string UltimosDigitosTargeta { get; set; }
        public Nullable<int> idTurno { get; set; }
        public string idUsuario { get; set; }
        public Nullable<int> idConductor { get; set; }
        public Nullable<int> idCliente { get; set; }
        public string idOrdenador { get; set; }
        public bool nuevoInsert { get; set; }
        public bool necesitoUpdateEnCloud { get; set; }
        public Nullable<int> TipoDeTargeta { get; set; }
    
        public virtual Cliente_ Cliente_ { get; set; }
        public virtual Conductor_ Conductor_ { get; set; }
        public virtual Moneda_ Moneda_ { get; set; }
        public virtual Ordenador_ Ordenador_ { get; set; }
        public virtual Usuario_ Usuario_ { get; set; }
    }
}
