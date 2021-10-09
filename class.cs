using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace @class
{         
   class Program
   {    // метод для задания 1
        static void Square(double a, double b, double c)
        {                        
          if (a == 0)
          {
           double decision1 = (-c) / b;
           Console.WriteLine("корень уравнения "+decision1);
          }
          else
          {
            double diskriminant = b * b - 4 * a * c;
            if (diskriminant == 0)
            {
             double decision2 = -b / (2 * a);
             Console.WriteLine("корень уравнения "+decision2);
            }
            else if (diskriminant > 0)
            {
              double root1 = (-b + Math.Sqrt(diskriminant)) / (2 * a);
              double root2 = (-b - Math.Sqrt(diskriminant)) / (2 * a);
              Console.WriteLine("1-ый корень " + root1);
              Console.WriteLine("2-ой корень " + root2);
            }
            else
            {
              Console.WriteLine("решений нет");
            }
          }

        }
           //метод для задания 3
           static void BubbleSort(int[] number)
           {
             for (int i = 0; i < number.Length; i++)
             {                
               for (int j = 0; j < number.Length -1-i; j++)
               {
                 if (number[j] > number[j + 1])
                 {
                   int local = number[j];
                   number[j] = number[j + 1];
                   number[j + 1] = local;                    
                 }
               }             
             }         
           } 
        //метод для задания 4
        static int Massives(ref int product, out double average, params int[] order)
        {
            int sumofarray = 0;
            for (int i = 0; i < order.Length; i++)
            {
                product *= order[i];
                sumofarray += order[i];
            }
            average = sumofarray / order.Length;
            return sumofarray;
        }
       
        static void Main(string[] args)
        {
            //задание 1
             Console.WriteLine("task1");
             try
             {
                 Console.WriteLine("Введите коэффициент a");
                 double a = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите коэффициент b");
                 double b = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите коэффициент c");
                 double c = double.Parse(Console.ReadLine());
                 Square(a, b, c);
             }
             catch (System.FormatException)
             {
                 Console.WriteLine("Вы ввели не числа");
             }
             //задание2
             Console.WriteLine("task2");
             int[] succesion = new int[20];
             Random random = new Random();
             for (int g = 0; g < succesion.Length; g++)
             {
                 succesion[g] = random.Next(100);
                 Console.Write(succesion[g] + " ");
             }
             Console.WriteLine("\n");
             Console.WriteLine("Выберите 2 элемента массива,которые хотите поменять местами");
             int input1 = int.Parse(Console.ReadLine());
             int input2 = int.Parse(Console.ReadLine());
             int include1 = 0;
             int include2 = 0;
             for (int i = 0; i < succesion.Length; i++)
             {
                 if (succesion[i] == input1)
                 {
                     include1 = i;
                 }
                 if (succesion[i] == input2)
                 {
                     include2 = i;
                 }
             }
             int exchange = succesion[include1];
             succesion[include1] = succesion[include2];
             succesion[include2] = exchange;
             for (int h = 0; h < succesion.Length; h++)
             {
                 Console.Write(succesion[h] + " ");
             }
             //задание 3
             Console.WriteLine("\n");
             Console.WriteLine("task3");
             Console.WriteLine("Введите кол-во элементов массива");
             int num = int.Parse(Console.ReadLine());
             int[] numbers = new int[num];
             int k = numbers[0];
             Random random2 = new Random();

             for (int i = 1; i < numbers.Length; i++)
             {
                 numbers[i] = random.Next(100);

             }

             BubbleSort(numbers);
             for (int j = 0; j < numbers.Length; j++)
             {
                 Console.Write(numbers[j] + " ");
             }
             //задание 4
             Console.WriteLine("\n");
             Console.WriteLine("task 4");
             int product = 1;
             double average = 0;
             int sum = Massives(ref product, out average, 1, 2, 3, 4, 5, 6, 7);
             Console.WriteLine("Сумма всех элементов массива " + sum + "\n" + "Произведение всех элементов " + product + "\n"+"Среднее алгебраическое " + average + " ");
            

            Console.WriteLine("task 5");
            Console.WriteLine("Введите число ");
           
            try
            {
                Console.WriteLine("Напечайте закрыть или exit для выхода");
                string name = Console.ReadLine();
                if (name == "exit" || name == "закрыть")
                {
                    Console.WriteLine("Вы вышли из консоли");
                }
                else
                {
                    int Inputnumbers = int.Parse(Console.ReadLine());
                    switch (Inputnumbers)
                    {
                        case 0:
                            Console.WriteLine("###\n# #\n# #\n# #\n###");
                            break;
                        case 1:
                            Console.WriteLine(" #\n #\n #\n #\n #");
                            break;
                        case 2:
                            Console.WriteLine("###\n #\n###\n# \n###");
                            break;
                        case 3:
                            Console.WriteLine("###\n #\n###\n #\n###");
                            break;
                        case 4:
                            Console.WriteLine("# #\n# #\n###\n #\n #");
                            break;
                        case 5:
                            Console.WriteLine("###\n# \n###\n #\n###");
                            break;
                        case 6:
                            Console.WriteLine("###\n# \n###\n# #\n###");
                            break;
                        case 7:
                            Console.WriteLine("###\n #\n #\n #\n #");
                            break;
                        case 8:
                            Console.WriteLine("###\n# #\n###\n# #\n###");
                            break;
                        case 9:
                            Console.WriteLine("###\n# #\n###\n #\n###");
                            break;
                        default:
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.WriteLine("ERROR");
                                Thread.Sleep(3000);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                break;
                            }

                    }
                }   
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели не числа");

            }
           
            
        } 

   }
}
