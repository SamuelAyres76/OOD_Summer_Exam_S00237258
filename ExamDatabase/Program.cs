using System;
using Restaurant_App;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDatabase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new CustomerClass("OODExam_SamuelAyres"))
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        Customer c1 = new Customer() { Name = "Tom Jones", ContactNumber = "086-123 4567" };
                        Customer c2 = new Customer() { Name = "Mary Smith", ContactNumber = "086 546 3214" };
                        Customer c3 = new Customer() { Name = "Jo Doyle", ContactNumber = "087 1221 222" };

                        // Add the customers to the database
                        db.Customers.Add(c1);
                        db.Customers.Add(c2);
                        db.Customers.Add(c3);

                        // Save changes to the database
                        db.SaveChanges();

                        transaction.Commit();
                        Console.WriteLine("Customers added successfully.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error occurred: " + ex.Message);
                    }
                }
            }
        }
    }
}