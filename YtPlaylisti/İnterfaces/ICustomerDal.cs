using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added.");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated.");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted.");
        }
    }
    class OracleServerCustomer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added.");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated.");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted.");
        }
    }
    class MySqlServerCustomer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added.");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated.");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted.");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }

}
