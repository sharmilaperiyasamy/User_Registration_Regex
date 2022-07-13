Regular_Exp.Regular_Expressions reg = new Regular_Exp.Regular_Expressions();

Console.WriteLine("Regular Expressions : \n0.exit\n1.Firstname Checker\n2.Lastname Checker\n3.EMail Check\n4.Mobile Number Check" +
    "\n5.Password_Rule1 check\n6.Password_Rule2 check\n7.Password_Rule3 check\n8.Password_Rule4 check\n9.Sample Email validation" +
    "\n10.Validate using Lambda function for user entry\nEnter your option");
int n = Convert.ToInt32(Console.ReadLine());
switch(n)
{
    case 1:
        Console.WriteLine("Enter the First Name : ");
        string fname = Console.ReadLine();
        reg.FirstNameCheck(fname);
        break;
        case 2:
        Console.WriteLine("Enter the Last Name : ");
        string lname = Console.ReadLine();
        reg.LastNameCheck(lname);
        break;
    case 3:
        Console.WriteLine("Enter the Email Address : ");
        string email = Console.ReadLine();
        reg.emailcheck(email);
        break;
    case 4:
        Console.WriteLine("Enter the Mobile number : ");
        string mob = Console.ReadLine();
        reg.mobileno_check(mob);
        break;
    case 5:
        Console.WriteLine("Enter the password : ");
        string pas1 = Console.ReadLine();
        reg.Password_Rule1(pas1);
        break;
    case 6:
        Console.WriteLine("Enter the password : ");
        string pas2 = Console.ReadLine();
        reg.Password_Rule2(pas2);
        break;
    case 7:
        Console.WriteLine("Enter the password : ");
        string pas3 = Console.ReadLine();
        reg.Password_Rule3(pas3);
        break;
    case 8:
        Console.WriteLine("Enter the password : ");
        string pas4 = Console.ReadLine();
        reg.Password_Rule4(pas4);
        break;
    case 9:
        Console.WriteLine("\nSample Email validation:\n");
        string[] sample = File.ReadAllLines(@"C:\Users\Lenovo\source\repos\Bridgelabz\User_Registration_Regex\Regular_Exp\Sample_email.txt");
        for (int i = 0; i < sample.Length; i++)
        {
            string ret = reg.Sample_email_clear(sample[i]);
            Console.WriteLine(sample[i] + "  ->  " + ret);
        }
        break;
        case 10:
        reg.validate();
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}
