using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Elyase";
            customer1.CustomerLastName = "Keceli";
            customer1.TcNo = "11111111111";
            customer1.PlaceOfBirth = "Ordu";

            Customer customer2 = new Customer();
            customer2.CustomerName = "Fatih";
            customer2.CustomerLastName = "Keceli";
            customer2.TcNo = "11111111112";
            customer2.PlaceOfBirth = "Ordu";

            Customer customer3 = new Customer();
            customer3.CustomerName = "Furkan";
            customer3.CustomerLastName = "Keceli";
            customer3.TcNo = "11111111113";
            customer3.PlaceOfBirth = "Ordu";

            Customer customer4 = new Customer();
            customer4.CustomerName = "Burak";
            customer4.CustomerLastName = "Keceli";
            customer4.TcNo = "11111111114";
            customer4.PlaceOfBirth = "Ordu";

            Customer[] customers = new Customer[] {customer1,customer2,customer3,customer4 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerName);
            }
            Console.WriteLine("--------");
            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdd(customer1);
            customerManager.CustomerAdd(customer2);
            customerManager.CustomerAdd(customer3);
            customerManager.CustomerAdd(customer4);
            customerManager.CustomerDelete(customer1);
            customerManager.CustomerList(customer4);
        }
    }
}
