using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tridion.ContentManager.CoreService.Client;

namespace TestCoreService
{
    public static class Utility
    {

        private static CoreServiceClient _coreServiceSource;
        public static CoreServiceClient CoreServiceSource
        {
            get
            {
                if (_coreServiceSource != null) return _coreServiceSource;
                _coreServiceSource = new CoreServiceClient("sourceEndpoint");

                // _coreServiceSource.ClientCredentials.UserName.UserName = ConfigurationManager.AppSettings["SourceUserName"];
                if (_coreServiceSource.ClientCredentials != null)
                {
                    _coreServiceSource.ClientCredentials.UserName.Password = ConfigurationManager.AppSettings["SourceUserPassword"];
                    string username = ConfigurationManager.AppSettings["SourceUserName"];
                    string domain = ConfigurationManager.AppSettings["SourceUserDomain"];
                    _coreServiceSource.ClientCredentials.UserName.UserName = $@"{domain}\{username}";
                    _coreServiceSource.ClientCredentials.Windows.ClientCredential.UserName = username;
                    _coreServiceSource.ClientCredentials.Windows.ClientCredential.Domain = domain;
                    _coreServiceSource.ClientCredentials.Windows.ClientCredential.Password = ConfigurationManager.AppSettings["SourceUserPassword"];
                }


                return _coreServiceSource;
            }
        }
    }
}
