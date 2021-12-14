using Newtonsoft.Json;

namespace NubeFactDotNet
{
    public class Guia
    {
        [JsonProperty("guia_tipo")]
        public TipoDeGuia? GuiaTipo { get; set; }

        [JsonProperty("guia_serie_numero")]
        public string? GuiaSerieNumero { get; set; }
    }
}
