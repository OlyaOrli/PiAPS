using System;
using ClassLibrary1;
using ClassLibrary2;
using ClassLibrary3;
using ClassLibrary4;
using ClassLibrary5;

namespace PAPS_LR1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\nМеню программы\n" +
                    "1. Вывод переданных аргументов.\n" +
                    "2. Определение високосного года в период с 1900 до 2000.\n" +
                    "3. Вывод чисел фибоначи до заданого.\n" +
                    "4. Вывод фактариалла заданного числа.\n" +
                    "5. Вывод простых чисел не превышающих заданного.\n\n" +
                    "Введите номер задачи: ");
                int nm = Convert.ToInt32(Console.ReadLine());
                switch (nm)
                {
                    case 1:
                        {
                            Number1 n1 = new Number1(args);
                            n1.write();
                        }
                        break;
                    case 2:
                        {
                            Number2 n2 = new Number2();
                            n2.year();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Введите число:");
                            int X = Convert.ToInt32(Console.ReadLine());
                            Number3 n3 = new Number3(X);
                            n3.write();
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Введите число:");
                            int X = Convert.ToInt32(Console.ReadLine());
                            Number4 n4 = new Number4(X);
                            n4.write();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Введите число:");
                            int X = Convert.ToInt32(Console.ReadLine());
                            Number5 n5 = new Number5(X);
                            n5.write();
                        }
                        break;
                    default: Console.WriteLine("Нет такой задачи"); break;

                }
            }    
        }
    }
}
