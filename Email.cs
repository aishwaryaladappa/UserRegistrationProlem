using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class Email
    {
        public string REGEX_Email = "^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})?$";

        public bool ValidateEmail(string name)
        {
            return Regex.IsMatch(name, REGEX_Email);
        }
    }
}





