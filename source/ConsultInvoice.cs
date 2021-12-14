using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace NubeFactDotNet
{
    class ConsultInvoice : NubeFactAction
    {
        public ConsultInvoice(TipoDeComprobante tipoDeComprobante, string serie, int numero)
        {
            this.TipoDeComprobante = tipoDeComprobante;
            this.Serie = serie;
            this.Numero = numero;
        }

        [JsonProperty("operacion")]
        [JsonConverter(typeof(StringEnumConverter))]
        public override Operacion Operacion { get; } = Operacion.consultar_comprobante;
    }
}
