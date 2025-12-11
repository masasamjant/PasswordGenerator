using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masasamjant.Passwords
{
    /// <summary>
    /// Represents service that required authentication using username and password pair.
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Initializes new instance of the <see cref="Service"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="loginUrl"></param>
        /// <param name="credentials"></param>
        public Service(string name, string description, string? loginUrl, Credentials? credentials)
        {
            Name = name;
            Description = description;
            LoginUrl = loginUrl;
            Credentials = credentials;
        }

        /// <summary>
        /// Gets the name of the service.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Gets the description of the service.
        /// </summary>
        public string Description { get; internal set; }

        /// <summary>
        /// Gets the URL of the service, either home or login page.
        /// </summary>
        public string? LoginUrl { get; internal set; }

        /// <summary>
        /// Gets the credentials associated with service.
        /// </summary>
        public Credentials? Credentials { get; internal set; }

        public void AddCredentials(Credentials credentials)
        {
            Credentials = credentials;
        }

        public void RemoveCredentials()
        {
            Credentials = null;
        }
    }
}
