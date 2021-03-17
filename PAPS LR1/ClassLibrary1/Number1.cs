using System;

namespace ClassLibrary1
{
    public class Number1
    {
        private string[] str;

        public Number1(string[] args)
        {
            this.str = new string[args.Length];
            for (int i = 0; i < args.Length; i++)
                this.str[i] = args[i];
        }

        public void write()
        {
            Console.WriteLine("Переданные аргументы:");
            for (int i = 0; i < this.str.Length; i++)
                Console.Write(this.str[i] + " ");
        }
    }
}
