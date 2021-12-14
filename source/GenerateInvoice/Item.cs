using Newtonsoft.Json;

namespace NubeFactDotNet
{
    public class Item
    {
        [JsonProperty("unidad_de_medida")]
        public string UnidadDeMedida { get; set; }

        [JsonProperty("codigo")]
        public string? Codigo { get; set; }

        [JsonProperty("codigo_producto_sunat")]
        public string CodigoProductoSunat { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("cantidad")]
        public int Cantidad { get; set; }

        [JsonProperty("valor_unitario")]
        public int ValorUnitario { get; set; }

        [JsonProperty("precio_unitario")]
        public double PrecioUnitario { get; set; }

        [JsonProperty("descuento")]
        public string? Descuento { get; set; }

        [JsonProperty("subtotal")]
        public int Subtotal { get; set; }

        [JsonProperty("tipo_de_igv")]
        public TipoDeIGV TipoDeIGV { get; set; }

        [JsonProperty("igv")]
        public int Igv { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("anticipo_regularizacion")]
        public bool AnticipoRegularizacion { get; set; }

        [JsonProperty("anticipo_documento_serie")]
        public string? AnticipoDocumentoSerie { get; set; }

        [JsonProperty("anticipo_documento_numero")]
        public string? AnticipoDocumentoNumero { get; set; }
    }
}
