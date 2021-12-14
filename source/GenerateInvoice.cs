using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NubeFactDotNet
{
    class GenerateInvoice : NubeFactAction
    {
        public GenerateInvoice(Invoice invoice, TipoDeComprobante tipoDeComprobante, string serie, int numero)
        {
            this.TipoDeComprobante = tipoDeComprobante;
            this.Serie = serie;
            this.Numero = numero;
            this.SunatTransaction = invoice.SunatTransaction;
            this.ClienteTipoDeDocumento = invoice.ClienteTipoDeDocumento;
            this.ClienteNumeroDeDocumento = invoice.ClienteNumeroDeDocumento;
            this.ClienteDenominacion = invoice.ClienteDenominacion;
            this.ClienteDireccion = invoice.ClienteDireccion;
            this.ClienteEmail = invoice.ClienteEmail;
            this.ClienteEmail1 = invoice.ClienteEmail1;
            this.ClienteEmail2 = invoice.ClienteEmail2;
            this.FechaDeEmision = invoice.FechaDeEmision;
            this.FechaDeVencimiento = invoice.FechaDeVencimiento;
            this.Moneda = invoice.Moneda;
            this.TipoDeCambio = invoice.TipoDeCambio;
            this.PorcentajeDeIgv = invoice.PorcentajeDeIgv;
            this.DescuentoGlobal = invoice.DescuentoGlobal;
            this.TotalDescuento = invoice.TotalDescuento;
            this.TotalAnticipo = invoice.TotalAnticipo;
            this.TotalGravada = invoice.TotalGravada;
            this.TotalInafecta = invoice.TotalInafecta;
            this.TotalExonerada = invoice.TotalExonerada;
            this.TotalIgv = invoice.TotalIgv;
            this.TotalGratuita = invoice.TotalGratuita;
            this.TotalOtrosCargos = invoice.TotalOtrosCargos;
            this.Total = invoice.Total;
            this.PercepcionTipo = invoice.PercepcionTipo;
            this.PercepcionBaseImponible = invoice.PercepcionBaseImponible;
            this.TotalPercepcion = invoice.TotalPercepcion;
            this.TotalIncluidoPercepcion = invoice.TotalIncluidoPercepcion;
            this.RetencionTipo = invoice.RetencionTipo;
            this.RetencionBaseImponible = invoice.RetencionBaseImponible;
            this.TotalRetencion = invoice.TotalRetencion;
            this.TotalImpuestosBolsas = invoice.TotalImpuestosBolsas;
            this.Detraccion = invoice.Detraccion;
            this.Observaciones = invoice.Observaciones;
            this.DocumentoQueSeModificaTipo = invoice.DocumentoQueSeModificaTipo;
            this.DocumentoQueSeModificaSerie = invoice.DocumentoQueSeModificaSerie;
            this.DocumentoQueSeModificaNumero = invoice.DocumentoQueSeModificaNumero;
            this.TipoDeNotaDeCredito = invoice.TipoDeNotaDeCredito;
            this.TipoDeNotaDeDebito = invoice.TipoDeNotaDeDebito;
            this.EnviarAutomaticamenteALaSunat = invoice.EnviarAutomaticamenteALaSunat;
            this.EnviarAutomaticamenteAlCliente = invoice.EnviarAutomaticamenteAlCliente;
            this.CodigoUnico = invoice.CodigoUnico;
            this.CondicionesDePago = invoice.CondicionesDePago;
            this.MedioDePago = invoice.MedioDePago;
            this.PlacaVehiculo = invoice.PlacaVehiculo;
            this.OrdenCompraServicio = invoice.OrdenCompraServicio;
            this.TablaPersonalizadaCodigo = invoice.TablaPersonalizadaCodigo;
            this.FormatoDePdf = invoice.FormatoDePdf;
            this.GeneradoPorContingencia = invoice.GeneradoPorContingencia;
            this.BienesRegionSelva = invoice.BienesRegionSelva;
            this.ServiciosRegionSelva = invoice.ServiciosRegionSelva;
            this.Items = invoice.Items;
            this.Guias = invoice.Guias;
            this.VentaAlCredito = invoice.VentaAlCredito;

        }

        [JsonProperty("operacion")]
        [JsonConverter(typeof(StringEnumConverter))]
        public override Operacion Operacion { get; } = Operacion.generar_comprobante;

        [JsonProperty("sunat_transaction")]
        public SunatTransaction SunatTransaction { get; set; }

        /// <summary>
        /// Whitespace = VARIOS - VENTAS MENORES A S/.700.00 Y OTROS<br/>
        /// 0 = NO DOMICILIADO, SIN RUC(EXPORTACIÓN)<br/>
        /// 1 = DNI - DOC.NACIONAL DE IDENTIDAD<br/>
        /// 4 = CARNET DE EXTRANJERÍA<br/>
        /// 6 = RUC - REGISTRO ÚNICO DE CONTRIBUYENTE<br/>
        /// 7 = PASAPORTE<br/>
        /// A = CÉDULA DIPLOMÁTICA DE IDENTIDAD<br/>
        /// </summary>
        [JsonProperty("cliente_tipo_de_documento")]
        public string ClienteTipoDeDocumento { get; set; }

        [JsonProperty("cliente_numero_de_documento")]
        public string ClienteNumeroDeDocumento { get; set; }

        [JsonProperty("cliente_denominacion")]
        public string ClienteDenominacion { get; set; }

        [JsonProperty("cliente_direccion")]
        public string ClienteDireccion { get; set; }

        [JsonProperty("cliente_email")]
        public string? ClienteEmail { get; set; }

        [JsonProperty("cliente_email_1")]
        public string? ClienteEmail1 { get; set; }

        [JsonProperty("cliente_email_2")]
        public string? ClienteEmail2 { get; set; }

        [JsonProperty("fecha_de_emision")]
        public DateTime FechaDeEmision { get; set; }

        [JsonProperty("fecha_de_vencimiento")]
        public DateTime? FechaDeVencimiento { get; set; }

        [JsonProperty("moneda")]
        public Moneda Moneda { get; set; }

        [JsonProperty("tipo_de_cambio")]
        public string? TipoDeCambio { get; set; }

        [JsonProperty("porcentaje_de_igv")]
        public double PorcentajeDeIgv { get; set; }

        [JsonProperty("descuento_global")]
        public string? DescuentoGlobal { get; set; }

        [JsonProperty("total_descuento")]
        public string? TotalDescuento { get; set; }

        [JsonProperty("total_anticipo")]
        public string? TotalAnticipo { get; set; }

        [JsonProperty("total_gravada")]
        public double? TotalGravada { get; set; }

        [JsonProperty("total_inafecta")]
        public string? TotalInafecta { get; set; }

        [JsonProperty("total_exonerada")]
        public string? TotalExonerada { get; set; }

        [JsonProperty("total_igv")]
        public int? TotalIgv { get; set; }

        [JsonProperty("total_gratuita")]
        public string? TotalGratuita { get; set; }

        [JsonProperty("total_otros_cargos")]
        public string? TotalOtrosCargos { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("percepcion_tipo")]
        public TipoDePercepcion? PercepcionTipo { get; set; }

        [JsonProperty("percepcion_base_imponible")]
        public string? PercepcionBaseImponible { get; set; }

        [JsonProperty("total_percepcion")]
        public string? TotalPercepcion { get; set; }

        [JsonProperty("total_incluido_percepcion")]
        public string? TotalIncluidoPercepcion { get; set; }

        [JsonProperty("retencion_tipo")]
        public string? RetencionTipo { get; set; }

        [JsonProperty("retencion_base_imponible")]
        public string? RetencionBaseImponible { get; set; }

        [JsonProperty("total_retencion")]
        public string? TotalRetencion { get; set; }

        [JsonProperty("total_impuestos_bolsas")]
        public string? TotalImpuestosBolsas { get; set; }

        [JsonProperty("detraccion")]
        public bool? Detraccion { get; set; }

        [JsonProperty("observaciones")]
        public string? Observaciones { get; set; }

        [JsonProperty("documento_que_se_modifica_tipo")]
        public string? DocumentoQueSeModificaTipo { get; set; }

        [JsonProperty("documento_que_se_modifica_serie")]
        public string DocumentoQueSeModificaSerie { get; set; }

        [JsonProperty("documento_que_se_modifica_numero")]
        public string? DocumentoQueSeModificaNumero { get; set; }

        [JsonProperty("tipo_de_nota_de_credito")]
        public string? TipoDeNotaDeCredito { get; set; }

        [JsonProperty("tipo_de_nota_de_debito")]
        public string? TipoDeNotaDeDebito { get; set; }

        [JsonProperty("enviar_automaticamente_a_la_sunat")]
        public bool? EnviarAutomaticamenteALaSunat { get; set; }

        [JsonProperty("enviar_automaticamente_al_cliente")]
        public bool? EnviarAutomaticamenteAlCliente { get; set; }

        [JsonProperty("codigo_unico")]
        public string? CodigoUnico { get; set; }

        [JsonProperty("condiciones_de_pago")]
        public string? CondicionesDePago { get; set; }

        [JsonProperty("medio_de_pago")]
        public string? MedioDePago { get; set; }

        [JsonProperty("placa_vehiculo")]
        public string? PlacaVehiculo { get; set; }

        [JsonProperty("orden_compra_servicio")]
        public string? OrdenCompraServicio { get; set; }

        [JsonProperty("tabla_personalizada_codigo")]
        public string? TablaPersonalizadaCodigo { get; set; }

        [JsonProperty("formato_de_pdf")]
        public string? FormatoDePdf { get; set; }

        [JsonProperty("generado_por_contingencia")]
        public string? GeneradoPorContingencia { get; set; }

        [JsonProperty("bienes_region_selva")]
        public string? BienesRegionSelva { get; set; }

        [JsonProperty("servicios_region_selva")]
        public string ServiciosRegionSelva { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        [JsonProperty("guias")]
        public List<Guia> Guias { get; set; }

        [JsonProperty("venta_al_credito")]
        public List<VentaAlCredito> VentaAlCredito { get; set; }
    }
}
