using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod
{
    class Program
    {   //метод для упражнения 5.1
        static void CompareNumbers(double number_1, double number_2) 
        {
            if (number_1 > number_2)
            {
                Console.WriteLine("1-ое число больше 2-ого");             
            }
            else if (number_1 < number_2)
            {
                Console.WriteLine("2-ое число больше 1-ого");                
            }
            else
            {
                Console.WriteLine("Числа равны");                
            }
        }
        //метод для упражнения 5.2
        static void Swap(ref double number_1, ref double number_2) 
        {
            double swap = number_1;
            number_1 = number_2;
            number_2 = swap;
        }
        //метод дл упражнения 5.3
        static bool CountFactorial(int factorial, out int result) 
        {
            result = 1;
            for (int i = 2; i <= factorial; i++)
            {
                try
                {
                    checked
                    {
                        result *= i;
                    }
                }
                catch (OverflowException)
                {
                    result = 0;
                    return false;
                }
            }
            return true;
        }
        //метод для 5.4
        static int CountRecursionFactorial(int factorial) 
        {
            if (factorial == 0)
            {
                return 1;
            }
            else
            {
                return factorial * CountRecursionFactorial(factorial - 1);
            }
        }
        //метод для 5.1A алгоритм Евклида
        static int GetNOD2(int number1, int number2)
        {
            while ((number1 != 0) & (number2 != 0))
            {
                if (number1 > number2)
                {
                    number1 %= number2;
                }
                else
                {
                    number2 %= number1;
                }
            }
            return number1 + number2;
            
        }
        //метод для 5.1 B
        static int GetNOD3(int number1,int number2,int number3)
        {
            int keeps = GetNOD2(number1, number2);
            return GetNOD2(keeps,number3);

        }

        //метод для упражнение 5.2, вычисление заданного порядкого номера числа ряда Фибоначчи
        static int CountFibonacciNumber(int ordinal_number) 
        {
            if (ordinal_number == 0)
            {
                return 0;
            }
            else if (ordinal_number == 1)
            {
                return 1;
            }
            else
            {
                return CountFibonacciNumber(ordinal_number - 1) + CountFibonacciNumber(ordinal_number - 2);
            }
        }
        
            static void Main(string[] args)
        {    //Упражнение 5.1
            Console.WriteLine("Упражнение 5.1");
            Console.WriteLine("Введите 1-ое число для сравнения:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2-ое число для сравнения:");
            double num2 = double.Parse(Console.ReadLine());
            CompareNumbers(num1, num2);
            //Упражнение 5.2
            Console.WriteLine("Упражнение 5.2");
            Console.WriteLine("Напишите значение 1-ого параметра: ");
            Console.WriteLine("Напишите значение 2-ого параметра: ");            
            Console.WriteLine("До обмена параметров: " + num1 + ", " + num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("После обмена параметров: " + num1 + ", " + num2);
            //Упражнение 5.3
            Console.WriteLine("Упражнение 5.3");
            Console.WriteLine("Введите факториал числа:");
            int factorial = int.Parse(Console.ReadLine());
            int result;
            Console.WriteLine("Результат работы метода: " + CountFactorial(factorial, out result));
            Console.WriteLine("Факториал " + factorial + " равен: " + result);
            //Упражнение 5.4
            Console.WriteLine("Упражнение 5.4");
            Console.WriteLine("Введите факториал числа:");
            factorial = int.Parse(Console.ReadLine());
            Console.WriteLine("Факториал " + factorial + " равен: " + CountRecursionFactorial(factorial));
            //Упражнение 5.1
            Console.WriteLine("Упражнение 5.1");
            Console.WriteLine("Введите 1-ое число для определения НОД:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2-ое число для определения НОД:");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("НОД для 1-ого и 2-ого числа: " + GetNOD2(number1, number2));
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Для 3-х чисел: " + GetNOD3(number1,number2,number3));
            //Упражнение 5.2
            Console.WriteLine("Упражнение 5.2");
            Console.WriteLine("Введите порядковый номер числа ряда Фибоначчи:");
            int ordinal_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Число ряда Фибоначчи порядкого номера " + ordinal_number + ": " + CountFibonacciNumber(ordinal_number));
            


        }
    }
}
