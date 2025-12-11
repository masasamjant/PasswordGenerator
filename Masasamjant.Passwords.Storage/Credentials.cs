using Masasamjant.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masasamjant.Passwords
{
    /// <summary>
    /// Represents user name and password pair.
    /// </summary>
    public class Credentials
    {
        public Credentials(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        [EncryptedStringProperty]
        public string UserName { get; internal set; }

        [EncryptedStringProperty]
        public string Password { get; internal set; }
    }
}
