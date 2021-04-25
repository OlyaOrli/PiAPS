using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PAPS_LR6_Server
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        // массив с информацией о рейсах
        static String[,] mas = { { "1", "Москва", "Резань", "07.15", "250" },
                                 { "2", "Калуга", "Омск", "09.23", "345" },
                                 { "3", "Брянск", "Москва", "20.00", "273" },
                                 { "4", "Омск", "Калуга", "16.00", "95" },
                                 { "5", "Санкт-Петербург", "Омск", "18.53", "290" },
                                 { "6", "Санкт-Петербург", "Москва", "16.00", "87" },
                                 { "7", "Москва", "Брянск", "06.20", "95" },
                                 { "8", "Санкт-Петербург", "Калуга", "16.00", "470" },
                                 { "9", "Калуга", "Санкт-Петербург", "14.29", "380" },
                                 { "10", "Санкт-Петербург", "Москва", "19.00", "289" } };


        // нахождение рейса по месту отправления и прибытия 
        public List<string> reise(String m1, String m2)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                if ((mas[i, 1] == m1) && (mas[i, 2] == m2))
                    for (int j = 0; j < 5; j++)
                        list.Add(mas[i, j]);
            }
            return list;
        }

        // нахождение рейса по месту отправления
        public List<string> reise_otkuda(String m)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                if ((mas[i, 1] == m))
                    for (int j = 0; j < 5; j++)
                        list.Add(mas[i, j]);
            }
            return list;
        }

        // нахождения рейса по месту прибытия
        public List<string> reise_kuda(String m)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                if ((mas[i, 2] == m))
                    for (int j = 0; j < 5; j++)
                        list.Add(mas[i, j]);
            }
            return list;
        }

        // бронирование билетов
        public String bron(int n, int k)
        {
            String s = "Ошибка в бронировании билетов";
            if (Convert.ToInt32(mas[n - 1, 4]) > k)
            { mas[n - 1, 4] = (Convert.ToInt32(mas[n - 1, 4]) - k).ToString(); s = "Места забронированы"; }
            else s = "Мест не хватает";
            return s;
        }
    }
}
