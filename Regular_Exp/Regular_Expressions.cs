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
        const string E_mail = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$";
        const string Mobile_no = "^[0-9]{1,3}[ ][789][0-9]{9}$";
        const string Pass_rule1 = "^[a-z]{8}$";
        const string Pass_rule2 = "^[A-Z]{1}[a-z A-Z]{7,}$";
        const string Pass_rule3 = "^[A-Z]{1}[a-z]{6}[0-9]{1}";
        const string Pass_rule4 = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        const string Clear_Sample = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";

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

        //uc4 mobile number check
        public void mobileno_check(string MobileNumber)
        {
            if(Regex.IsMatch(MobileNumber,Mobile_no))
            {
                Console.WriteLine("Mobile Number is valid");
                return ;
            }
            else
            {
                Console.WriteLine("Enter a valid mobile number");
            }    
        }

        //uc5 password rule 1 - minimum 8 characters
        public void Password_Rule1(string pass1)
        {
            if(Regex.IsMatch(pass1, Pass_rule1))
            {
                Console.WriteLine("Password is strong.");
                return;
            }
            else
            {
                Console.WriteLine("Please enter lower case 8 characters ");
            }
        }
        //uc6 password rule 2 one upper case
        public void Password_Rule2(string pass2)
        {
            if (Regex.IsMatch(pass2, Pass_rule2))
            {
                Console.WriteLine("Password is strong.");
                return;
            }
            else
            {
                Console.WriteLine("Please enter valid password ");
            }
        }
        //uc7 password rule 3 - one numeric character
        public void Password_Rule3(string pass3)
        {
            if (Regex.IsMatch(pass3, Pass_rule3))
            {
                Console.WriteLine("Password is strong.");
                return;
            }
            else
            {
                Console.WriteLine("Please enter valid password ");
            }
        }
        //uc8 password rule 4 - one special character
        public void Password_Rule4(string pass4)
        {
            if (Regex.IsMatch(pass4, Pass_rule4))
            {
                Console.WriteLine("Password is strong.");
                return;
            }
            else
            {
                Console.WriteLine("Please enter valid password ");
            }
        }

        // uc9 email Sample validation
        public string Sample_email_clear(String mail)
        {
            if(Regex.IsMatch(mail, Clear_Sample))
            {
                return "Valid Email Address.";
            }
            else
            {
                return "Email Address is not valid";
            }
        }
    }
}
