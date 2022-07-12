Regular_Exp.Regular_Expressions reg = new Regular_Exp.Regular_Expressions();

Console.WriteLine("Regular Expressions : \n0.exit\n1.Firstname Checker\n2.Lastname Checker\n3.EMail Check\n4.Mobile Number Check" +
    "\n5.Password_Rule1 check\nEnter your option");
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
        string pas = Console.ReadLine();
        reg.Password_Rule1(pas);
        break;
    default:
        Console.WriteLine("Invalid option");
        break;

}
