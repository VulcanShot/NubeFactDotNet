using Newtonsoft.Json;

namespace NubeFactDotNet
{
    public class VentaAlCredito
    {
        [JsonProperty("cuota")]
        public int? Cuota { get; set; }

        [JsonProperty("fecha_de_pago")]
        public string? FechaDePago { get; set; }

        [JsonProperty("importe")]
        public int Importe { get; set; }
    }
}
