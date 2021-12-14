using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace NubeFactDotNet
{
    class CancelInvoice : NubeFactAction
    {
        public CancelInvoice(TipoDeComprobante tipoDeComprobante, string serie, int numero, string motivo, string codigoUnico)
        {
            this.TipoDeComprobante = tipoDeComprobante;
            this.Serie = serie;
            this.Numero = numero;
            this.Motivo = motivo;
            this.CodigoUnico = codigoUnico;
        }

        [JsonProperty("operacion")]
        [JsonConverter(typeof(StringEnumConverter))]
        public override Operacion Operacion { get; } = Operacion.generar_anulacion;

        [JsonProperty("motivo")]
        public string Motivo { get; set; }

        [JsonProperty("codigo_unico")]
        public string? CodigoUnico { get; set; }
    }
}
