using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Customer:Person
    {
        public string CustomerId { get; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }

        private static int customerIdSeed = 1;
        public Customer()
        {
            CustomerId = customerIdSeed.ToString();
            customerIdSeed++;
            Email = "0";
            Password = "0";
            FirstName = "0";
            MiddleName = "0";
            LastName = "0";
            Address = "0";
            Company = "0";
        }
        public Customer(string e, string p, string f, string m,string l, string a,string c)
        {
            CustomerId = customerIdSeed.ToString();
            customerIdSeed++;
            Email = e;
            Password = p;
            FirstName = f;
            MiddleName = m;
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
