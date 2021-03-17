using System;

namespace ClassLibrary3
{
    public class Number3
    {
        private int x;

        public Number3(int X)
        { this.x = X; }

        public void write()
        {
            int first = 0, second = 1, f = 0;
            Console.Write("Числа Фибоначи:\n" + first + " " + second + " ");
            for (int i = 2; i <= this.x; i++)
            {
                f = first + second;
                if (f < this.x)
                {
                    Console.Write(f + " ");
                    first = second;
                    second = f;
                }
                else break;

            }
        }
    }
}
