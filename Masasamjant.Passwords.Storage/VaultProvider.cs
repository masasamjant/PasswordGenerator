using Masasamjant.Security.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masasamjant.Passwords
{
    public sealed class VaultProvider<TCryptoKey> : VaultService<TCryptoKey> where TCryptoKey : CryptoKey
    {
        public VaultProvider(IFileCryptography<TCryptoKey> cryptography) 
            : base(cryptography)
        { }

        public async Task<Vault> OpenVaultAsync(TCryptoKey cryptoKey, string vaultFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
