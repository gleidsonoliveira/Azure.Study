using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

class Program
{
    static async System.Threading.Tasks.Task Main(string[] args)
    {
        string keyVaultUrl = "<Url-Key-Vault>";
        string clientId = "<seu-client-id>";
        string clientSecret = "<seu-client-secret>";
        string tenantId = "<seu-tenant-id>";

        var secretClient = new SecretClient(new Uri(keyVaultUrl), new ClientSecretCredential(tenantId, clientId, clientSecret));

        string secretName = "seu-segredo";
        KeyVaultSecret secret = await secretClient.GetSecretAsync(secretName);

        Console.WriteLine($"Valor do Segredo '{secretName}': {secret.Value}");
    }
}
