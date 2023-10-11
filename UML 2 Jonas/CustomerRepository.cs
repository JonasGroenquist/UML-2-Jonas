using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_Jonas
{
    public class CustomerRepositoryDictionary
    {
        private Dictionary<string, Customer> _customers;
        public CustomerRepositoryDictionary()
        {
            _customers = new Dictionary<string, Customer>();
        }
        public int Count
        {
            get { return _customers.Count; }
        }




        public void AddCustomer(Customer aCustomer)
        {
            _customers.Add(aCustomer.Phone, aCustomer);
        }



        public Customer LookupCustomer(string phone)
        {
            if (_customers.ContainsKey(phone))
                return _customers[phone];
            else
                return null;
        }



        public void DeleteCustomer(string phone)
        {
            _customers.Remove(phone);
        }




        public void PrintCustomer()
        {
            foreach (var customer in _customers.Values)
            {
                Console.WriteLine(customer + " ");
            }
        }



        public void UpdateCustomer(string phone, Customer customerToUpdate)
        {
            if (_customers.ContainsKey(phone))
            {
                _customers[phone] = customerToUpdate;
            }
        }
    }

}
