using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PeopleManagement.Common.Tools
{
    public static class RegexTool
    {

        public static string NormalizeUserName(string userName)
        {
            return Regex.Replace(userName, "[^0-9a-zA-Z]+", "");
        }
    }
}
