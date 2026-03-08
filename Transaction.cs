using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week_2_Task_01
{
    internal class Transaction
    {
        public int Transaction_Id;
        public string ProductName;
        public double Amount;
        public string DateTime;

        // Parametrixed Constructor to store values.
        public Transaction(int Id, string Name, double amount, string dateTime)
        {
            Transaction_Id = Id;
            ProductName = Name;
            Amount = amount;
            DateTime = dateTime;
        }

        // Copy constructor.
        public Transaction(Transaction t1)
        {
            Transaction_Id = t1.Transaction_Id;
            ProductName = t1.ProductName;
            Amount = t1.Amount;
            DateTime = t1.DateTime;
        }
        public void Display()
        {
            Console.WriteLine("Transaction ID: " + Transaction_Id);
            Console.WriteLine("Product Name: " + ProductName );
            Console.WriteLine("Amount : " + Amount);
            Console.WriteLine("Date Time: " + DateTime);
        }
    }
}
