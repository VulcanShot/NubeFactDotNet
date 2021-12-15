# NubeFactDotNet
Un API Wrapper en C# para los servicios de NubeFact que permite: generar, consultar y cancelar boletas/facturas de forma simple y rápida.

## Instalación
    Install-Package NubeFactDotNet

## Documentación
Para empezar a utilizar esta librería, simplemente inicializa un `NubeFactClient` como se aprecia a continuación:<br>
```cs
using NubeFactDotNet;
NubeFactClient client = new("tu-url-va-aqui" ,"tu-token-va-aqui");
```
Posteriormente, puedes acceder a cualquiera de las funciones disponibles, las cuales cuentan con versiones `sync` y `async` respectivamente. Por ejemplo:<br>
```cs
string response = processor.ConsultInvoice(TipoDeComprobante.Factura, "FFF1", 1);
Console.WriteLine(response);
```
