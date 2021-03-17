using System;

namespace ClassLibrary4
{
    public class Number4
    {
        private int x;

        public Number4(int X)
        { this.x = X; }

        public void write()
        {
            long f = 1;
            for (int i = 1; i <= this.x; i++)
                f = f * i;
            Console.WriteLine(this.x + "! = " + f);
        }
    }
}
