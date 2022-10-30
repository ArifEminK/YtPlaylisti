using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager(); 
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "Arif Emin";
            customer.LastName = "Köklü";
            customer.Id = 1;
            customer.City = "Konya";

            Customer customer2 = new Customer()
            {
                FirstName = "Bedirhan",
                LastName = "Özmen",
                City = "Bartın",
                Id = 2,
            };

            Console.WriteLine(customer.FirstName);

            Console.ReadLine();


        }
    }
    
}
