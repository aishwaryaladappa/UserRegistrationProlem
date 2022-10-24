using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class LastName
    {
        public string REGEX_NAME = "^[A-Z]{3,}$";

        public bool ValidateLastName(string name)
        {
            return Regex.IsMatch(name, REGEX_NAME);
        }
    }
}





