using Newtonsoft.Json;

namespace NubeFactDotNet.Responses
{
    public abstract class NubeFactResponse
    {
        [JsonProperty("numero")]
        public int Numero { get; set; }

        [JsonProperty("enlace")]
        public string Enlace { get; set; }

        [JsonProperty("sunat_ticket_numero")]
        public string SunatTicketNumero { get; set; }

        [JsonProperty("aceptada_por_sunat")]
        public bool AceptadaPorSunat { get; set; }

        [JsonProperty("sunat_description")]
        public string SunatDescription { get; set; }

        [JsonProperty("sunat_note")]
        public string SunatNote { get; set; }

        [JsonProperty("sunat_responsecode")]
        public string SunatResponsecode { get; set; }

        [JsonProperty("sunat_soap_error")]
        public string SunatSoapError { get; set; }

        [JsonProperty("enlace_del_pdf")]
        public string EnlaceDelPdf { get; set; }

        [JsonProperty("enlace_del_xml")]
        public string EnlaceDelXml { get; set; }

        [JsonProperty("enlace_del_cdr")]
        public string EnlaceDelCdr { get; set; }
    }
}
