using System;
using System.Collections.Generic;
using BankProject.BusinessLogicLayer.BALContracts;
using BankProject.DataAccessLayer;
using BankProject.DataAccessLayer.DALContracts;
using BankProject.Entities;
using BankProject.Exceptions;

namespace BankProject.BusinessLogicLayer
{
     public class CustomersBusinessLogicLayer : ICustomersBusinessLogicLayer
    {
        #region Private Fields
        private ICustomersDataAccessLayer _customersDataAccessLayer;
        #endregion

        #region Constructors
        public CustomersBusinessLogicLayer()
        {
            _customersDataAccessLayer = new CustomersDataAccessLayer();
        }
        #endregion


        #region Properties
        private ICustomersDataAccessLayer CustomersDataAccessLayer
        {
            set => _customersDataAccessLayer = value;
            get => _customersDataAccessLayer;
        }
        #endregion


        #region Methods
        public List<Customer> GetCustomers()
        {
            try
            {
                return CustomersDataAccessLayer.GetCustomers();
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            try
            {
                return CustomersDataAccessLayer.GetCustomersByCondition(predicate);
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Guid AddCustomer(Customer customer)
        {
            try
            {
                List<Customer> allCustomers = CustomersDataAccessLayer.GetCustomers();
                long maxCustCode = 0;
                foreach (var item in allCustomers)
                {
                    if (item.CustomerCode > maxCustCode)
                    {
                        maxCustCode = item.CustomerCode;
                    }
                }

                if (allCustomers.Count >= 1)
                {
                    customer.CustomerCode = maxCustCode + 1;
                }
                else
                {
                    customer.CustomerCode = BankProject.Configuration.Settings.BaseCustomerNo + 1;
                }
                return CustomersDataAccessLayer.AddCustomer(customer);
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                return CustomersDataAccessLayer.UpdateCustomer(customer);
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteCustomer(Guid customerID)
        {
            try
            {
                return CustomersDataAccessLayer.DeleteCustomer(customerID);
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}

