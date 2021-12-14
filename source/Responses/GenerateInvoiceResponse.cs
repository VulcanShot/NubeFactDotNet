using Newtonsoft.Json;

namespace NubeFactDotNet.Responses
{
    public class GenerateInvoiceResponse : NubeFactResponse
    {
        [JsonProperty("tipo_de_comprobante")]
        public int TipoDeComprobante { get; set; }

        [JsonProperty("serie")]
        public string Serie { get; set; }

        [JsonProperty("cadena_para_codigo_qr")]
        public string CadenaParaCodigoQr { get; set; }

        [JsonProperty("codigo_hash")]
        public string CodigoHash { get; set; }

        [JsonProperty("codigo_de_barras")]
        public string CodigoDeBarras { get; set; }
    }
}
