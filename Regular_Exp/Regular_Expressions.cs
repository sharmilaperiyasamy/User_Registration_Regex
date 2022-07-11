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
        const string First_name = "^[A-Z]{1}[a-z]{2,}$";
        const string Last_name = "^[A-Z]{1}[a-z]{2,}$";
        public void FirstNameCheck(string firstName)
        {
            if (Regex.IsMatch(firstName, First_name))
            {
                Console.WriteLine("First name is valid.");
                return;
            }
            Console.WriteLine("First name is not valid.");
        }

        public void LastNameCheck(string lastname)
        {
            if(Regex.IsMatch(lastname, Last_name))
            {
                Console.WriteLine("Last name is valid.");
                return;
            }
            Console.WriteLine("Lastname is not valid");
        }
    }
}
