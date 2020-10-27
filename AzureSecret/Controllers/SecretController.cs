using System;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AzureSecret.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecretController : ControllerBase
    {
        private const string KeyVaultUri = "your-keyvault-uri";
        private const string SecretName = "your-secret-name";
        private readonly ILogger<SecretController> _logger;

        public SecretController(ILogger<SecretController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            var client = new SecretClient(new Uri(KeyVaultUri), new DefaultAzureCredential());
            var secret = await client.GetSecretAsync(SecretName);
            return secret.Value.Value;
        }
    }
}
