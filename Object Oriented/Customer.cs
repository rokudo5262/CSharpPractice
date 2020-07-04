using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Customer:Person
    {
        public int customerId;
        public int CustomerId
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
            }
        }
        public string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string address;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string company;
        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }
        public Customer()
        {
            customerId = 0;
            email = "0";
            password = "0";
            firstName = "0";
            lastName = "0";
            address = "0";
            company = "0";
        }
        public Customer(int id, string e, string p, string f, string a, string l,string c)
        {
            customerId = id;
            email = e;
            password = p;
            firstName = f;
            lastName = l;
            address = a;
            company = c;
        }

        public static void AddCustomer(int id, string e, string p, string f, string a, string l, string c)
        {
            
        }
        public static void CustomerDetail()
        {

        }
    }
}
