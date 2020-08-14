using System;
using System.Collections.Generic;
using Implementation.Entities;
using Polymorfi.Entities;

namespace ManualTests.ConsoleApp
{
    public class Program
    {
        static void Main()
        {
            CloneTest();
        }

        #region Clone Implementation Test
        public static void CloneTest()
        {
            // Arrange
            Temperature firstTemperature = new Temperature(69, 156.2, "Nicely Hot");
            Temperature secondTemperature;

            // Act
            secondTemperature = firstTemperature.Clone() as Temperature;

            // Assert
            Console.WriteLine(secondTemperature);
            Console.ReadLine();
        }
        #endregion

        #region CompareTo Implementation Test
        public static void CompareToTest()
        {
            // Arrange
            Temperature firstTemperature = new Temperature(69, 156.2, "Nicely Hot");
            Temperature secondTemperature = new Temperature(69, 156.2, "Nicely Hot");

            // Act
            int result = firstTemperature.CompareTo(secondTemperature);

            // Assert
            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region IPayable Test
        public static void IPayableTest()
        {
            // PayableProcessor for processing payables
            PayableProcessor processor = new PayableProcessor(new Account(100000), new Account(250000));


            // Output current values
            Console.WriteLine($"Expenses Account: {processor.ExpensesAccount.Balance}");
            Console.WriteLine($"Sales Account: {processor.SalesAccount.Balance}");


            // List containing different classes implementing IPayable
            List<IPayable> payables = new List<IPayable>() {
                // Salary
                new Salary(1, 1, 2020, 3, DateTime.UtcNow, 27000),
                // ProductSale
                new ProductSale(new Dictionary<Product, int>() { { new Product("Mundbind", 5), 5 }, }, DateTime.UtcNow, 1),
                // ServiceSale
                new ServiceSale(250, DateTime.UtcNow, 1),
            };


            // Process payables
            processor.Process(payables);


            // Output new values
            Console.WriteLine($"\nExpenses Account: {processor.ExpensesAccount.Balance}");
            Console.WriteLine($"Sales Account: {processor.SalesAccount.Balance}");

            Console.ReadLine();
        }
        #endregion
    }
}