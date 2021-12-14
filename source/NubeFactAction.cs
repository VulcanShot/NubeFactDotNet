using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NubeFactDotNet
{
    abstract class NubeFactAction
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("operacion")]
        public abstract Operacion Operacion { get; }

        [JsonProperty("tipo_de_comprobante")]
        public TipoDeComprobante TipoDeComprobante { get; set; }

        [JsonProperty("serie")]
        public string Serie { get; set; }

        [JsonProperty("numero")]
        public int Numero { get; set; }
    }
}
