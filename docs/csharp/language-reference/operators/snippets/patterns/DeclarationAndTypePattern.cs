using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    public static class DeclarationAndTypePattern
    {
        public static void Examples()
        {
            ReferenceConversion();
            NullableAndUnboxing();
        }

        private static void ReferenceConversion()
        {
            // <ReferenceConversion>
            var numbers = new int[] { 10, 20, 30 };
            Console.WriteLine(GetSourceLabel(numbers));  // output: 1

            var letters = new List<char> { 'a', 'b', 'c', 'd' };
            Console.WriteLine(GetSourceLabel(letters));  // output: 2

            static int GetSourceLabel<T>(IEnumerable<T> source) => source switch
            {
                Array a => 1,
                ICollection<T> c => 2,
                _ => 3,
            };
            // </ReferenceConversion>
        }

        private static void NullableAndUnboxing()
        {
            // <NullableAndUnboxing>
            int? xNullable = 7;
            int y = 23;
            object yBoxed = y;
            if (xNullable is int a && yBoxed is int b)
            {
                Console.WriteLine(a + b);  // output: 30
            }
            // </NullableAndUnboxing>
        }
    }

    namespace Vehicles
    {
        // <DiscardVariable>
        public abstract class Vehicle {}
        public class Car : Vehicle {}
        public class Truck : Vehicle {}

        public static class TollCalculator
        {
            public static decimal CalculateToll(this Vehicle vehicle) => vehicle switch
            {
                Car _ => 2.00m,
                Truck _ => 7.50m,
                null => throw new ArgumentNullException(nameof(vehicle)),
                _ => throw new ArgumentException("Unknown type of a vehicle", nameof(vehicle)),
            };
        }
        // </DiscardVariable>

        public static class TollCalculatorWithTypePattern
        {
            // <TypePattern>
            public static decimal CalculateToll(this Vehicle vehicle) => vehicle switch
            {
                Car => 2.00m,
                Truck => 7.50m,
                null => throw new ArgumentNullException(nameof(vehicle)),
                _ => throw new ArgumentException("Unknown type of a vehicle", nameof(vehicle)),
            };
            // </TypePattern>
        }
    }
}