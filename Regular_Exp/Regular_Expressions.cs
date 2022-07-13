﻿using System;
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
        const string E_mail = "abc.?[a-z]{3,}@bl.co.?[a-z]{2,}$";

        //uc1 firstname checker
        public void FirstNameCheck(string firstName)
        {
            if (Regex.IsMatch(firstName, First_name))
            {
                Console.WriteLine("First name is valid.");
                return;
            }
            Console.WriteLine("Enter a valid First name.");
        }

        //uc2 second name checker
        public void LastNameCheck(string lastname)
        {
            if(Regex.IsMatch(lastname, Last_name))
            {
                Console.WriteLine("Last name is valid.");
                return;
            }
            Console.WriteLine("Enter a valid lastname.");
        }

        //uc3 third name checker
        public void emailcheck(string email)
        {
            if(Regex.IsMatch(email,E_mail))
            {
                Console.WriteLine("Email Id is valid");
                return;
            }
            else
            {
                Console.WriteLine("Enter a valid Email Address");
            }
        }

    }
}
