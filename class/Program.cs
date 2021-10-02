using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {
        public double Square(double a,double b,double c)
        {
            double diskrimainant = b * b - 4 * a * c;
            if (a == 0)
            {
                double decision1 = (-c) / b;
            }
            else 
            {
                if (diskrimainant == 0)
                {
                    double decision2 = -b / (2 * a);
                }
                else if(diskrimainant>0)
                {
                    double root1 = (-b + Math.Sqrt(diskrimainant)) / (2 * a);
                    double root2 = (-b - Math.Sqrt(diskrimainant)) / (2 * a);
                }
              
            }    
        }
        static void Main(string[] args)
        {
            Console.WriteLine("task1");
            Console.WriteLine("Введите коэффициент a ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c");
            double c = int.Parse(Console.ReadLine());
            
            



        }
    }
}
