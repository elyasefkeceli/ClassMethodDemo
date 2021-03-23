using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Müsteri adi eklendi :" + customer.CustomerName);
        }
        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Müsteri adi silindi : " + customer.CustomerName);
        }
        public void CustomerList(Customer customer)
        {
            Console.WriteLine("Müsteri bilgileri listelendi : " + customer.CustomerName + ":" + customer.CustomerLastName+ ":"+ customer.TcNo+ ":"+ customer.PlaceOfBirth);
        }
    }
}
