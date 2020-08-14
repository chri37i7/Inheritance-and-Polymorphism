using System;
using Implementation.Entities;

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
            Temperature firstTemperature;
            Temperature secondTemperature;

            // Act
            firstTemperature = new Temperature(69);
            secondTemperature = firstTemperature.Clone() as Temperature;

            // Assert
            Console.WriteLine(secondTemperature);
            Console.ReadLine();
        }
        #endregion

        #region CompareTo Implementation Test
        public static void CompareTest()
        {
            // Arrange
            Temperature firstTemperature = new Temperature(69);
            Temperature secondTemperature = new Temperature(69);

            // Act
            int result = firstTemperature.CompareTo(secondTemperature);

            // Assert
            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region Equals Tests
        public static void TrueEqualityTest()
        {
            // Arrange
            Temperature firstTemperature;
            Temperature secondTemperature;

            // Act
            firstTemperature = new Temperature(69);
            secondTemperature = new Temperature(69);

            // Assert
            Console.WriteLine(firstTemperature.Equals(secondTemperature));
            Console.ReadLine();
        }

        public static void FalseEqualityTest()
        {
            // Arrange
            Temperature firstTemperature;
            Temperature secondTemperature;

            // Act
            firstTemperature = new Temperature(69);
            secondTemperature = new Temperature(69);

            // Assert
            Console.WriteLine(firstTemperature.Equals(secondTemperature));
            Console.ReadLine();
        }
        #endregion

        #region GetHashCode Test
        public static void GetHashCodeTest()
        {
            // Arrange
            Temperature firstTemperature = new Temperature(69);
            Temperature secondTemperature = new Temperature(69);

            // Act
            int firstHash = firstTemperature.GetHashCode();
            int secondHash = secondTemperature.GetHashCode();

            // Assert
            Console.WriteLine(firstHash);
            Console.WriteLine(secondHash);
            Console.ReadLine();
        }
        #endregion
    }
}