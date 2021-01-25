using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNo = "12345";
            customer1.Name = "Tuncay";
            customer1.Surname = "Göçkon";
            customer1.TcNo = "22222222222";
            customer1.Id = 101;


            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 102;
            customer2.CustomerNo = "12346";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "123456789";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);


        }
    }
}
