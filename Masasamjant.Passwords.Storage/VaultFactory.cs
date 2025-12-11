using Masasamjant.Security.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masasamjant.Passwords
{
    /// <summary>
    /// Represents factory to create new <see cref="Vault"/>.
    /// </summary>
    /// <typeparam name="TCryptoKey"></typeparam>
    public sealed class VaultFactory<TCryptoKey> : VaultService<TCryptoKey> where TCryptoKey : CryptoKey
    {
        public VaultFactory(IFileCryptography<TCryptoKey> cryptography)
            : base(cryptography)
        { }

        public async Task<Vault> CreateVaultAsync(TCryptoKey cryptoKey, string vaultFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
