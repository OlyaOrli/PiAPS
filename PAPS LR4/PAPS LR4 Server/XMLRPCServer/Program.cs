using System;
using System.Collections;
using Nwc.XmlRpc;

namespace PAPS_LR4_Server
{
    class Program
    {
        static int port = 8031;
        static void Main(string[] args)
        {
            // создание и запуск сервера
            XmlRpcServer server = new XmlRpcServer(port);
            server.Add("sample", new Program());
            Console.WriteLine("Сервер запущен");
            server.Start(); //Запуск сервера
        }

        // функция обработки квадратной матрицы
        public ArrayList massiv(ArrayList list, int n)
        {
            Console.WriteLine("Началась обработка массива...\n");
            int k = 0;
            //создание списка для хранения измененной матрицы
            ArrayList result = new ArrayList(n * n + 1);
            result.Clear();
            //  создание двумерного массива и заполнение
            int[,] mas = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = Convert.ToInt32(list[k]);
                    k++;
                }
            }

            // нахождение минимального элемента в массиве и его индексов
            int min = 999999999, i_min = -1, j_min = -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((mas[i, j] < min) && ((i == j) || (i + j == n - 1)))
                    {
                        min = mas[i, j];
                        i_min = i;
                        j_min = j;
                    }
                }
            }
            bool index = false;
            if (j_min + i_min == n-1) index = true; //флаг который говорит, что это главная диагональ
            result.Add(min); // добавить минимальный массив в список


            // перевод диагонали с минимальным элементом в 0. 
            // Если диагональ главная, то сумма индексов равна размеру матрицы. Если побочная, то индексы равны
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (index)
                    {
                        if (i + j == n - 1) mas[i, j] = 0;
                    }
                    else
                    {
                        if (i == j) mas[i, j] = 0;
                    }
                }
            }
            // возведение в квадрат ниже диагонали.
            //Если диагональ главная работа с матрицей идет построчно начиная справа, иначе слева
            //Все элементы до нуля в строке возводим в квадрат
            for (int i = 0; i < n; i++)
            {
                if (!index)
                {
                    int s = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if ((mas[i, j] != 0) && (s == 0))
                        { mas[i, j] = mas[i, j] * mas[i, j]; }
                        else s = 1;
                    }
                }
                else
                {
                    int s = 0;
                    for (int j = n - 1; j >= 0; j--)
                    {
                        if ((mas[i, j] != 0) && (s == 0))
                        { mas[i, j] = mas[i, j] * mas[i, j]; }
                        else s = 1;
                    }
                }
                for (int j = 0; j < n; j++)
                {
                    result.Add(mas[i, j]);
                }
            }

            Console.WriteLine("... Обработка массива закончилась\n");
            return result;  // возвращаем список

        }
    }
}
