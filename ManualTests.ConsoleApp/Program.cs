using System;
using System.Collections.Generic;
using Polymorfi.Entities;

namespace ManualTests.ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            // PayableProcessor for processing payables
            PayableProcessor processor = new PayableProcessor(new Account(100000), new Account(250000));

            // Output current values
            Console.WriteLine($"Expenses Account: {processor.ExpensesAccount.Balance}");
            Console.WriteLine($"Sales Account: {processor.SalesAccount.Balance}");

            // List containing different payable classes
            List<IPayable> payables = new List<IPayable>() {
                new Salary(1, 1, 2020, 3, DateTime.UtcNow, 27000),
                new ProductSale(new Dictionary<Product, int>() { { new Product("Mundbind", 5), 5 }, }, DateTime.UtcNow, 1),
                new ServiceSale(250, DateTime.UtcNow, 1),
            };

            // Process payables
            processor.Process(payables);

            // Output new values
            Console.WriteLine($"\nExpenses Account: {processor.ExpensesAccount.Balance}");
            Console.WriteLine($"Sales Account: {processor.SalesAccount.Balance}");
        }
    }
}