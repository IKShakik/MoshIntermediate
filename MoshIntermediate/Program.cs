using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshIntermediate
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }



















        static void UseTry()
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
