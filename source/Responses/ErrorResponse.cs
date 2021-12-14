using Newtonsoft.Json;

namespace NubeFactDotNet.Responses
{
    public class ErrorResponse
    {
        [JsonProperty("errors")]
        public string Errors { get; set; }

        [JsonProperty("codigo")]
        public int Codigo { get; set; }
    }
}
