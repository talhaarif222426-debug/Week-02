using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction(1, "Mobile", 70000, "03-07-2026");

            // copying existing object into new object.
            Transaction t2 = new Transaction(t1);

            // these are some new values to check wherther changing values effect the existing value or not.
            //t2.Transaction_Id = 2;
            //t2.ProductName = "Laptop";
            //t2.Amount = 120000;
            //t2.DateTime = "12-8-2025";

            Console.WriteLine("Original Transaction:");
            t1.Display();

            Console.WriteLine("\nCopied Transaction:");
            t2.Display();
        }
    }
}
