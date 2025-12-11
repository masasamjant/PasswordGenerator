using Masasamjant.Security.Abstractions;

namespace Masasamjant.Passwords
{
    /// <summary>
    /// Represents abstract service of <see cref="Vault"/>.
    /// </summary>
    /// <typeparam name="TCryptoKey">The type of the crypto key.</typeparam>
    public abstract class VaultService<TCryptoKey> where TCryptoKey : CryptoKey
    {
        /// <summary>
        /// Initializes new instance of the <see cref="VaultService{TCryptoKey}"/> class.
        /// </summary>
        /// <param name="cryptography">The <see cref="IFileCryptography{TCryptoKey}"/>.</param>
        internal VaultService(IFileCryptography<TCryptoKey> cryptography)
        {
            Cryptography = cryptography;
        }

        /// <summary>
        /// Gets the file cryptography.
        /// </summary>
        protected IFileCryptography<TCryptoKey> Cryptography { get; }
    }
}
