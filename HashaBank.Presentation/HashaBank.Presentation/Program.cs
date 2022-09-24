class Program
{
    static void Main()
    {
        System.Console.WriteLine("******Harsha Bank******");
        System.Console.WriteLine("Login Page");

        string userName = null, password = null;

        System.Console.WriteLine("Username: ");
        userName = System.Console.ReadLine();

        if (userName != "")
        {
            System.Console.WriteLine("Password: ");
            password = System.Console.ReadLine();
        }

        if (userName == "system" && password == "manager")
        {
            System.Console.WriteLine("TO DO: Main menu  here ");
        }

        System.Console.WriteLine("Thank you");
        System.Console.ReadKey();

    }
}