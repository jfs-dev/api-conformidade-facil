using System.Security.Cryptography.X509Certificates;

string url = "https://cff.svrs.rs.gov.br/api/v1/consultas/classTrib";
string certPath = @"Certificados\Certificado.p12";
string certPassword = "senha-certificado";

var collection = X509CertificateLoader.LoadPkcs12CollectionFromFile(certPath, certPassword);
var cert = collection.FirstOrDefault(x => x.HasPrivateKey) ?? throw new FileNotFoundException("Certificado não encontrado!");

var handler = new HttpClientHandler();
handler.ClientCertificates.Add(cert);

using HttpClient client = new(handler);
try
{
    HttpResponseMessage response = await client.GetAsync(url);
    response.EnsureSuccessStatusCode();

    string json = await response.Content.ReadAsStringAsync();

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Resposta da API");
    Console.WriteLine("---------------");

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(json[..255]);
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Erro");
    Console.WriteLine("----");

    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
}
