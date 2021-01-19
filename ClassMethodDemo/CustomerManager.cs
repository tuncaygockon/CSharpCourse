using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("New Customer Added : " + customer.Name + " " + customer.Surname);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted : " + customer.Name + " " + customer.Surname);
            Console.WriteLine(" ");
        }

        public void CustomerList(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname);
        }
        public void SubscriberList(Customer customer)
        {
            Console.WriteLine(customer.Id + " : " + customer.Name + " " + customer.Surname);
        }







    }
}
