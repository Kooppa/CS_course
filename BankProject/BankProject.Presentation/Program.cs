using BankProject.Presentation;

class Program
{
    static void Main()
    {
        System.Console.WriteLine("***** Registro Banco *****");
        System.Console.WriteLine("Pagina de log in");

        string userName = null, password = null;

        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();

        if (userName != "")
        {
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }
        
        if (userName == "system" && password == "manager")
        {         
            int mainMenuChoice = -1;

            do
            {                
                System.Console.WriteLine("\nBienvenido");
                System.Console.WriteLine("1. Menú de Clientes");
                System.Console.WriteLine("2. Menú de Cuentas");
                System.Console.WriteLine("0. Salir");
          
                System.Console.Write("Enter: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1: 
                        CustomersMenu(); 
                        break;
                    case 2: 
                        AccountsMenu(); 
                        break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Campos invalidos");
        }

        System.Console.WriteLine("Gracias. Hasta luego");
        System.Console.ReadKey();
    }

    static void CustomersMenu()
    {
        int customerMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\nMenú de clientes");
            System.Console.WriteLine("1. Añadir un cliente a la base");
            System.Console.WriteLine("2. Ver lista de usuarios");
            System.Console.WriteLine("0. Back to Main Menu");

            System.Console.Write("Enter: ");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

            switch (customerMenuChoice)
            {
                case 1: 
                    CustomersPresentation.AddCustomer(); 
                    break;
                case 2: 
                    CustomersPresentation.ViewCustomers(); 
                    break;
            }
        } while (customerMenuChoice != 0);
    }


    static void AccountsMenu()
    {
        int accountsMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n:::Accounts menu:::");
            System.Console.WriteLine("1. Añadir cuenta");
            System.Console.WriteLine("2. Borrar cuenta");
            System.Console.WriteLine("3. Ver lista de cuentas");
            System.Console.WriteLine("0. Back to Main Menu");

            System.Console.Write("Enter: ");
            accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (accountsMenuChoice != 0);
    }
}


