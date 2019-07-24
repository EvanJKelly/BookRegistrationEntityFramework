using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationEntityFramework
{
    static class CustomerDB
        {
        /// <summary>
        /// Returns all customers from the database
        /// </summary>
        /// <returns></returns>
        public static List<Customer> GetCustomers()
        {
            //Create instance of DB Context
            var db = new BookRegistrationEntities();

            //Use DB Context to retreive all customers
            //Use LINQ (Language Integrated Query)
            //to query database


            //LINQ Query Syntax
            //List<Customer> customers =
            //     (from c in db.Customer
            //     select c).ToList();

            //LINQ Method syntax- Same query as aboe
            List<Customer> customers =
                db.Customer.ToList();
            return customers;

        }

        /// <summary>
        /// Adds a customer. Returns the newly added customer
        /// with the CustomerId populated
        /// </summary>
        /// <param name="c">The new Customer to be added</param>
        /// <returns></returns>
        public static Customer AddCustomer(Customer c)
        {
            using (var context = new BookRegistrationEntities())
            {
                context.Customer.Add(c);
                //SaveChanges MUST BE CALLED FOR insert/update/delete
                context.SaveChanges();

                //Return newly added customer with CustomerId (Identity column) populated
                return c;
            }
        }
    }
}
