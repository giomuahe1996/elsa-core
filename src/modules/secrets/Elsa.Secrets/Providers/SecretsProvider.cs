using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elsa.Secrets.Manager;
using Elsa.Secrets.Models;
using Elsa.Secrets.ValueFormatters;

namespace Elsa.Secrets.Providers
{
    public class SecretsProvider : ISecretsProvider
    {
        private readonly ISecretsManager _secretsManager;
        private readonly IEnumerable<ISecretValueFormatter> _valueFormatters;

        public SecretsProvider(ISecretsManager secretsManager, IEnumerable<ISecretValueFormatter> valueFormatters)
        {
            _secretsManager = secretsManager;
            _valueFormatters = valueFormatters;
        }

        public async Task<string> GetSecretById(string id) {
            var secret = await _secretsManager.GetSecretById(id);

            var formatter = _valueFormatters.FirstOrDefault(x => x.Type == secret?.Type);

            if (formatter != null)
                return await formatter.FormatSecretValue(secret);

            return null;
        }

        public async Task<string> GetSecretByName(string name) {
            var secret = await _secretsManager.GetSecretByName(name);

            var formatter = _valueFormatters.FirstOrDefault(x => x.Type == secret?.Type);

            if (formatter != null)
                return await formatter.FormatSecretValue(secret);

            return null;
        }

        public async Task<ICollection<string>> GetSecrets(string type)
        {
            var secrets = await _secretsManager.GetSecrets(type);
            return secrets.Select(x => x.Id).ToArray();
        }

        public async Task<ICollection<(string, string)>> GetSecretsForSelectListAsync(string type)
        {
            var secrets = await _secretsManager.GetSecrets(type);
            return secrets.Select(x => (x.Name ?? x.DisplayName, x.Name)).ToArray();
        }
    }
}