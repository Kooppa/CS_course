public class MultipleObjectsExample
{
    static void Main()
    {
        Employee.OrganizationName = "Harsha Inc.";
        System.Console.WriteLine("****** " + Employee.OrganizationName + " ******");
        
        for (int i = 0; i < 10; i++)
        {
            string employeeNumber;
            switch (i)
            {
                case 0: employeeNumber = "Primer empleado:"; break;
                case 1: employeeNumber = "Segundo empleado:"; break;
                case 2: employeeNumber = "Tercer empleado:"; break;
                case 3: employeeNumber = "Cuarto empleado:"; break;
                case 4: employeeNumber = "Quinti empleado:"; break;
                case 5: employeeNumber = "Sexto empleado:"; break;
                case 6: employeeNumber = "Septimo empleado:"; break;
                case 7: employeeNumber = "Octovo empleado:"; break;
                case 8: employeeNumber = "Noveno empleado:"; break;
                case 9: employeeNumber = "Decimo empleado"; break;
                default: employeeNumber = "Empleado por encima de decimo:"; break;
            }
            System.Console.WriteLine(employeeNumber);

            Employee emp = new Employee();

            System.Console.Write("ID: ");
            emp.EmployeeID = uint.Parse(System.Console.ReadLine());

            System.Console.Write("Nombre: ");
            emp.EmployeeName = System.Console.ReadLine();

            System.Console.Write("Salario por hora: ");
            emp.SalaryPerHour = uint.Parse(System.Console.ReadLine());

            System.Console.Write("Horas al día: ");
            emp.NoOfWorkingHours = uint.Parse(System.Console.ReadLine());

            emp.NetSalary = emp.NoOfWorkingHours * emp.SalaryPerHour;

            System.Console.WriteLine( employeeNumber);
            System.Console.WriteLine("Employee ID: " + emp.EmployeeID);
            System.Console.WriteLine("Nombre: " + emp.EmployeeName);
            System.Console.WriteLine("Salario por hora: " + emp.SalaryPerHour);
            System.Console.WriteLine("Horas al día: " + emp.NoOfWorkingHours);
            System.Console.WriteLine("Salario neto: " + emp.NetSalary);
            System.Console.WriteLine("Typo: " + Employee.TypeOfEmployee);
            System.Console.WriteLine("Departamento: " + emp.DepartmentName);

            System.Console.Write("Registrar otro empleado? Yes / No: ");
            string choice = System.Console.ReadLine();

            if (!(choice == "yes" || choice == "YES" || choice == "Yes" || choice == "y" || choice == "Y"))
            {
                break;
            }
        }
        System.Console.WriteLine("\nThank you.");
        System.Console.ReadKey();
    }
}

