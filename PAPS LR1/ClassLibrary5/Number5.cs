using System;

namespace ClassLibrary5
{
    public class Number5
    {
        private int[] mas;
        private int x;

        public Number5(int X)
        {
            this.x = X;
            this.mas = new int[this.x + 2];
            for (int i = 2; i <= this.x; i++)
                this.mas[i] = 1;
        }

        public void write()
        {

            for (int i = 2; i <= this.x; i++)
                if (this.mas[i] == 1)
                {
                    int j = i * i;
                    while (j <= this.x)
                    {
                        this.mas[j] = 0;
                        j = j + i;
                    }
                }
            Console.WriteLine("Простые числа: ");
            for (int i = 2; i <= this.x; i++)
                if (this.mas[i] == 1) Console.Write(i + " ");

        }
    }
}
