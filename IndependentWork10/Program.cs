using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle radians;
            {
                do
                {
                    Console.WriteLine("Введите градусы, минуты, секунды");
                    double gradus_ = Convert.ToInt32(Console.ReadLine());
                    double min_ = Convert.ToInt32(Console.ReadLine());
                    double sec_ = Convert.ToInt32(Console.ReadLine());
                    radians = new Circle(gradus_, min_, sec_);
                }
                while (radians.isCorrect == false);
                double totalRadians= radians.ToRadians();
                Console.WriteLine(totalRadians);
                Console.ReadKey();



            }
        }
    }
}
