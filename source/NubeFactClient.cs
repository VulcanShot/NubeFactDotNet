using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace NubeFactDotNet
{
    public class NubeFactClient
    {
        public NubeFactClient(Uri uri, string token)
        {
            this.Uri = uri;
            this.Token = token;
        }

        public NubeFactClient(string uri, string token)
        {
            this.Uri = new UriBuilder(uri).Uri;
            this.Token = token;
        }

        public Uri Uri { get; set; }
        public string Token { get; set; }

        public string GenerateInvoice(Invoice invoice, TipoDeComprobante tipoDeComprobante, string serie, int numero)
        {
            var requestObject = new GenerateInvoice(invoice, tipoDeComprobante, serie, numero);
            return SendRequest(requestObject);
        }

        public async Task<string> GenerateInvoiceAsync(Invoice invoice, TipoDeComprobante tipoDeComprobante, string serie, int numero)
        {
            var requestObject = new GenerateInvoice(invoice, tipoDeComprobante, serie, numero);
            return await SendRequestAsync(requestObject);
        }

        public string ConsultInvoice(TipoDeComprobante tipoDeComprobante, string serie, int numero)
        {
            var requestObject = new ConsultInvoice(tipoDeComprobante, serie, numero);
            return SendRequest(requestObject);
        }

        public async Task<string> ConsultInvoiceAsync(TipoDeComprobante tipoDeComprobante, string serie, int numero)
        {
            var requestObject = new ConsultInvoice(tipoDeComprobante, serie, numero);
            return await SendRequestAsync(requestObject);
        }

        public string CancelInvoice(TipoDeComprobante tipoDeComprobante, string serie, int numero, string motivo, string? codigoUnico = null)
        {
            var requestObject = new CancelInvoice(tipoDeComprobante, serie, numero, motivo, codigoUnico);
            return SendRequest(requestObject);
        }

        public async Task<string> CancelInvoiceAsync(TipoDeComprobante tipoDeComprobante, string serie, int numero, string motivo, string? codigoUnico = null)
        {
            var requestObject = new CancelInvoice(tipoDeComprobante, serie, numero, motivo, codigoUnico);
            return await SendRequestAsync(requestObject);
        }

        public string ConsultCancellation(TipoDeComprobante tipoDeComprobante, string serie, int numero)
        {
            var requestObject = new ConsultCancellation(tipoDeComprobante, serie, numero);
            return SendRequest(requestObject);
        }

        public async Task<string> ConsultCancellationAsync(TipoDeComprobante tipoDeComprobante, string serie, int numero)
        {
            var requestObject = new ConsultCancellation(tipoDeComprobante, serie, numero);
            return await SendRequestAsync(requestObject);
        }

        private string SendRequest(NubeFactAction requestObject)
        {
            string json = JsonConvert.SerializeObject(requestObject, Formatting.Indented);
            byte[] bytes = Encoding.Default.GetBytes(json);
            string utfJson = Encoding.UTF8.GetString(bytes);
            try
            {
                using var client = new WebClient();
                client.Headers[HttpRequestHeader.ContentType] = "application/json; charset=utf-8";
                client.Headers[HttpRequestHeader.Authorization] = "Token token=" + this.Token;
                return client.UploadString(this.Uri, "POST", utfJson);
            }
            catch (WebException ex)
            {
                var respuesta = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                return respuesta;
            }
        }

        private async Task<string> SendRequestAsync(NubeFactAction requestObject)
        {
            string json = JsonConvert.SerializeObject(requestObject, Formatting.Indented);
            byte[] bytes = Encoding.Default.GetBytes(json);
            string utfJson = Encoding.UTF8.GetString(bytes);
            try
            {
                using var client = new WebClient();
                client.Headers[HttpRequestHeader.ContentType] = "application/json; charset=utf-8";
                client.Headers[HttpRequestHeader.Authorization] = "Token token=" + this.Token;
                return await client.UploadStringTaskAsync(this.Uri, "POST", utfJson);
            }
            catch (WebException ex)
            {
                return await new StreamReader(ex.Response.GetResponseStream()).ReadToEndAsync();
            }
        }

    }
}