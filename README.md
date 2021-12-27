# NubeFactDotNet
Un API Wrapper en C# para los servicios de NubeFact que permite: generar, consultar y cancelar boletas/facturas de forma simple y rápida.

## Instalación
    Install-Package NubeFactDotNet

## Documentación
Para empezar a utilizar esta librería, simplemente inicializa un `NubeFactClient` como se aprecia a continuación:<br>
```cs
using NubeFactDotNet;
NubeFactClient client = new("tu-url-va-aqui", "tu-token-va-aqui");
```
Posteriormente, puedes acceder a cualquiera de las funciones disponibles, las cuales cuentan con versiones tanto sincrónicas como asincrónicas. Por ejemplo:<br>
```cs
string response = client.ConsultInvoice(TipoDeComprobante.Factura, "FFF1", 1);
```
Las funciones disponibles son las siguientes:
```cs
public string GenerateInvoice(Invoice invoice, TipoDeComprobante tipoDeComprobante, string serie, int numero);
public async Task<string> GenerateInvoiceAsync(Invoice invoice, TipoDeComprobante tipoDeComprobante, string serie, int numero);
public string ConsultInvoice(TipoDeComprobante tipoDeComprobante, string serie, int numero);
public async Task<string> ConsultInvoiceAsync(TipoDeComprobante tipoDeComprobante, string serie, int numero);
public string CancelInvoice(TipoDeComprobante tipoDeComprobante, string serie, int numero, string motivo, string? codigoUnico = null);
public async Task<string> CancelInvoiceAsync(TipoDeComprobante tipoDeComprobante, string serie, int numero, string motivo, string? codigoUnico = null);
public string ConsultCancellation(TipoDeComprobante tipoDeComprobante, string serie, int numero);
public async Task<string> ConsultCancellationAsync(TipoDeComprobante tipoDeComprobante, string serie, int numero);
```
