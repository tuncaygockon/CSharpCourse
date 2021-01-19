using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 10001;
            customer1.Name = "Myles";
            customer1.Surname = "Turner";
            customer1.Subscription = true;

            Customer customer2 = new Customer();
            customer2.Id = 10002;
            customer2.Name = "Damion";
            customer2.Surname = "Lee";
            customer2.Subscription = false;

            Customer customer3 = new Customer();
            customer3.Id = 10003;
            customer3.Name = "Will";
            customer3.Surname = "Barton";
            customer3.Subscription = false;

            Customer customer4 = new Customer();
            customer4.Id = 10004;
            customer4.Name = "Jon";
            customer4.Surname = "Leuer";
            customer4.Subscription = true;

            Customer customer5 = new Customer();
            customer5.Id = 10005;
            customer5.Name = "Fred";
            customer5.Surname = "VanVleet";
            customer4.Subscription = true;


            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };

            CustomerManager customerManager = new CustomerManager();

            foreach (var c in customers)
            {
                customerManager.Add(c);
                
            }

            Console.WriteLine(" ");

            Console.WriteLine("All Customers:");
            foreach (var v in customers)
            {
                customerManager.CustomerList(v);
                
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("Non-Sub Customers:");

            for (int x = 0; x < customers.Length; x++)
            {
                if (customers[x].Subscription == false)
                {
                    customerManager.CustomerList(customers[x]);
                   
                }

            }

            Console.WriteLine(" ");

            start: Console.WriteLine("Enter an ID Code:");

            int Number = new int();
            Number = Convert.ToInt32(Console.ReadLine());

            bool foundIt = new bool();

            for (int i = 0; i < customers.Length; i++)
            {
                if (Number == customers[i].Id)
                {
                    foundIt = true;
                    customerManager.Delete(customers[i]);
                    goto start;
                }
                foundIt = false;

            }
            if (foundIt == false)
            {
                Console.WriteLine("Invalid ID Code.");
                Console.WriteLine(" ");
                goto start;
            }
        }
    }
}
