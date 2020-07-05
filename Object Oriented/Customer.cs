using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Customer:Person
    {
        public string CustomerId
        {
            get
            {
                return CustomerId;
            }
            set
            {
                CustomerId = value;
            }
        }
        public string Email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        public string Password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
        public string FirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }
        public string Address
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public string Company
        {
            get
            {
                return Company;
            }
            set
            {
                Company = value;
            }
        }

        private static int customerIdSeed = 1;
        public Customer()
        {
            CustomerId = customerIdSeed.ToString();
            customerIdSeed++;
            Email = "0";
            Password = "0";
            FirstName = "0";
            LastName = "0";
            Address = "0";
            Company = "0";
        }
        public Customer(string e, string p, string f, string a, string l,string c)
        {
            CustomerId = customerIdSeed.ToString();
            customerIdSeed++;
            Email = e;
            Password = p;
            FirstName = f;
            LastName = l;
            Address = a;
            Company = c;
        }
        public void CustomerDetail()
        {
            Console.WriteLine("Tên Khách Hàng: {0}.",FirstName);
            Console.WriteLine("Họ Khách Hàng: {0}.",LastName);
            Console.WriteLine("Tài Khoản Khách Hàng: {0}.",Email);
            Console.WriteLine("Mật Khẩu Hàng: {0}.",Password);
            Console.WriteLine("Địa Chỉ Khách Hàng: {0}.",Address);
            Console.WriteLine("Tên Công Ty: {0}.",Company);
        }
    }
}
