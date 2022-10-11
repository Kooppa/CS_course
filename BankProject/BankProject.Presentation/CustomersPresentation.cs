using System;
using System.Collections.Generic;
using BankProject.Entities;
using BankProject.Exceptions;
using BankProject.BusinessLogicLayer;
using BankProject.BusinessLogicLayer.BALContracts;

namespace BankProject.Presentation
{
    static class CustomersPresentation
    {
        internal static void AddCustomer()
        {
            try
            {
                Customer customer = new Customer();

                Console.WriteLine("\n*****Añade un cliente*****");
                Console.Write("Nombre de cliente: ");
                customer.CustomerName = Console.ReadLine();
                Console.Write("Dirreción de cliente: ");
                customer.Address = Console.ReadLine();
                Console.Write("Marca dle cliente: ");
                customer.Landmark = Console.ReadLine();
                Console.Write("Ciudad: ");
                customer.City = Console.ReadLine();
                Console.Write("País: ");
                customer.Country = Console.ReadLine();
                Console.Write("(Número debe ser de 10 digitos y contener solo números): ");
                Console.Write("Número celular. ");
                customer.Mobile = Console.ReadLine();

                ICustomersBusinessLogicLayer customersBusinessLogicLayer = new CustomersBusinessLogicLayer();
                Guid newGuid = customersBusinessLogicLayer.AddCustomer(customer);

                List<Customer> matchingCustomers = customersBusinessLogicLayer.GetCustomersByCondition(item => item.CustomerID == newGuid);
                if (matchingCustomers.Count >= 1)
                {
                    Console.WriteLine("ID de cliente: " + matchingCustomers[0].CustomerCode);
                    Console.WriteLine("Nuevo cliente registrado exitosamente\n");
                }
                else
                {
                    Console.WriteLine("El cliente no se registro.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }


        internal static void ViewCustomers()
        {
            try
            {
                ICustomersBusinessLogicLayer customersBusinessLogicLayer = new CustomersBusinessLogicLayer();

                List<Customer> allCustomers = customersBusinessLogicLayer.GetCustomers();
                Console.WriteLine("\n*****Lista de clientes*****");

                foreach (var item in allCustomers)
                {
                    Console.WriteLine("ID del cliente: " + item.CustomerCode);
                    Console.WriteLine("Nombre del cliente: " + item.CustomerName);
                    Console.WriteLine("Dirección: " + item.Address);
                    Console.WriteLine("Marca: " + item.Landmark);
                    Console.WriteLine("Ciudad: " + item.City);
                    Console.WriteLine("País: " + item.Country);
                    Console.WriteLine("Número de celular: " + item.Mobile);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }
    }
}
