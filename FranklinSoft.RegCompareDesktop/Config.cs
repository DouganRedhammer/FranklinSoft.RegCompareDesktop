using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FranklinSoft.RegCompareDesktop
{
    public static class Config
    {
        public static int TestConnectionTimeout => int.Parse(ConfigurationManager.AppSettings["TestConnectionTimeout"]);
        public static int RetrieveRegistryTimeout => int.Parse(ConfigurationManager.AppSettings["RetrieveRegistryTimeout"]);
        public static string DefaultRegistryKeyRoot => ConfigurationManager.AppSettings["DefaultRegistryKeyRoot"];
        public static string DefaultMachineA => ConfigurationManager.AppSettings["DefaultMachineA"];
        public static string DefaultMachineB => ConfigurationManager.AppSettings["DefaultMachineB"];
    }
}
