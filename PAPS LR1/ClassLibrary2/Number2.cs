using System;

namespace ClassLibrary2
{
    public class Number2
    {
        public void year()
        {
            for (int i = 1900; i <= 2000; i++)
                if (((i % 100 != 0) || (i % 400 == 0)) && (i % 4 == 0))
                    Console.WriteLine(i + " - Високосный год");
                else Console.WriteLine(i + " - Не високосный год");
        }

    }
}
