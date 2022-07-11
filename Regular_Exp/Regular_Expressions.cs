using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular_Exp
{
    internal class Regular_Expressions
    {
        const string NAME = "^[A-Z]{1}[a-z]{2,}$";
        public void FirstNameCheck(string firstName)
        {
            if (Regex.IsMatch(firstName, NAME))
            {
                Console.WriteLine("First name is valid.");
                return;
            }
            Console.WriteLine("First name is not valid.");
        }
    }
}
