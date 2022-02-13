using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BscScan.NetCore.Extensions
{
    public static class StringExtensions
    {

        public static string ToRequestParameters(this string value, string? apiKey)
        {
            return value.Replace("{apiKey}", apiKey);
        }

        public static string AddAddress(this string value,string address)
        {
            return value.Replace("{address}",address);
        }
    }
}
