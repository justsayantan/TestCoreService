using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tridion.ContentManager.CoreService.Client;

namespace TestCoreService
{
    class Program
    {
        static void Main(string[] args)
        {
            CoreServiceClient client = Utility.CoreServiceSource;
            client.GetApiVersion();

        }
    }
}
