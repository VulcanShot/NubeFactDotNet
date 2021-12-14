using Newtonsoft.Json;

namespace NubeFactDotNet.Responses
{
    public class ConsultInvoiceResponse : GenerateInvoiceResponse
    {
        [JsonProperty("anulado")]
        public bool Anulado { get; set; }
    }
}
