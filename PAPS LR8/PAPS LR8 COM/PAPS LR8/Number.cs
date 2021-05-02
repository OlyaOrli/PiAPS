using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace PAPS_LR8
{
    [Guid("8C034F6A-1D3F-4DB8-BC99-B73873D8C297")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public class Number : INumber
    {
        // нахождение чисел Фибоначчи. На вход получаем натуральное число, на выход список чисел Фибоначчи до заданного
        public List<int> fibon_n(int x)
        {
            List<int> list = new List<int>();
            int first = 0, second = 1, f = 0;
            list.Add(first);
            list.Add(second);
            for (int i = 2; i <= x; i++)
            {
                f = first + second;
                if (f < x)
                {
                    list.Add(f);
                    first = second;
                    second = f;
                }
                else break;
            }
            return list;
        }
        // нахождение факториала числа. На выход поступает число, результат вычислений – факториал заданного числа
        public int factor_n(int x)
        {
            int f = 1;
            for (int i = 1; i <= x; i++)
                f = f * i;
            return f;
        }
        // нахождение простых чисел. На выход поступает список полученных чисел до заданного числа
        public List<int> prost_n(int x)
        {
            List<int> list = new List<int>();
            int[] mas = new int[x + 2];
            for (int i = 2; i <= x; i++)
                mas[i] = 1;
            for (int i = 2; i <= x; i++)
                if (mas[i] == 1)
                {
                    int j = i * i;
                    while (j <= x)
                    {
                        mas[j] = 0;
                        j = j + i;
                    }
                }
            for (int i = 2; i <= x; i++)
                if (mas[i] == 1) list.Add(i);
            return list;
        }

    }
}
