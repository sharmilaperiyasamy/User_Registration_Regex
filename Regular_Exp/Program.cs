Regular_Exp.Regular_Expressions reg = new Regular_Exp.Regular_Expressions();

Console.WriteLine("Regular Expressions : \n0.exit\n1.Firstname Checker\n2.Lastname Checker\nEnter your option");
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
    default:
        Console.WriteLine("Invalid option");
        break;

}
