using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSLB900.MSTools.Util
{
    public static class CSHandleSecurity
    {
        public static string GetIPAddress()
        {
            var name = Dns.GetHostName();
            var ip = Dns.GetHostEntry(name).AddressList.FirstOrDefault(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            return ip?.ToString() ?? "IP não encontrado!";
        }
    }
}
