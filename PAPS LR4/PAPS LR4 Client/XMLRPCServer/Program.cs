using System;
using System.Collections;
using Nwc.XmlRpc;

namespace PAPS_LR4_Client
{
    class Program
    {
        static string adres = "http://127.0.0.1:8031";
        static void Main(string[] args)
        {
            bool f = true;
            int n = -1;
            // ввод размера матрицы. Проверка на то, чтобы было натуральное число.
            while (f)
                try
                {
                    Console.Write("Введите размер квадратной матрицы: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    f = false;
                    if (n <= 0)
                    {
                        Console.WriteLine("ПРЕДУПРЕЖДЕНИЕ! Введите натуральное число");
                        f = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ПРЕДУПРЕЖДЕНИЕ! Введите натуральное число");
                }

            // Создаем список для хранения и передачи элементов массива. Заполняем его элементами, проверяем на то, чтобы было введено целое число
            ArrayList list = new ArrayList(n * n);
            int k = 0;
            while (k < n * n)
                try
                {
                    Console.Write("Элемент " + (k + 1) + ": ");
                    list.Add(Convert.ToInt32(Console.ReadLine()));
                    k++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ПРЕДУПРЕЖДЕНИЕ! Введите целое число");
                }
            
            // вывод введеных данных в виде квадратной матрицы
            k = 0;
            Console.WriteLine("Введенная матрица");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(list[k] + " ");
                    k++;
                }
                Console.WriteLine("");
            }


            // Создание клиента сервера и подключение к нему
            XmlRpcRequest client = new XmlRpcRequest();
            XmlRpcResponse response;
            client.MethodName = "sample.massiv";
            client.Params.Clear();
            client.Params.Add(list);
            client.Params.Add(n);
            response = client.Send(adres);
            // Создание списка для элементов измененной матрицы и минимального числа. 
            //Элементы в списке расположены в следующем порядке: минимальный элемент, элемнты матрицы 
            ArrayList resualt = new ArrayList( n * n + 1);
            resualt = (ArrayList)response.Value;
            
            
            int kk = 0;
            Console.WriteLine("");
            // Вывод минимального элемента
            Console.WriteLine("Минимальный элемент: " + resualt[kk]);
            kk++;
            Console.WriteLine("");
            // Вывод измененной матрицы
            Console.WriteLine("Измененная матрица ");
            for (int i =0; i<n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    Console.Write(resualt[kk] + " ");
                    kk++;
                }
                Console.WriteLine("");
            }

            
            Console.ReadLine();
        }
    }
}