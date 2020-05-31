using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshIntermediate
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var num = int.TryParse("abc", out number);
            if (num)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion fails.");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine(point.X);
                Console.WriteLine(point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected problm occures.");
            }
        }
    }
}
