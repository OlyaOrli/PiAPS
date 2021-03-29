using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;


namespace PiAPS_LR2
{
    class Program
    { 
        static int port = 8005;
        static Socket soket;
        static Thread clientThread;

        public static void users()
        {
            Socket client = soket.Accept();
            String name = "";
            while (true)
            {
                byte[] data = new byte[1024];
                StringBuilder text = new StringBuilder();
                // если есть сообщение, то узнаем какое именно 
                try
                {
                    if (client.Available > 0)
                    {
                        int read_bytes = client.Receive(data, data.Length, 0);
                        // байты переводим в строку
                        text.Append(Encoding.Unicode.GetString(data, 0, read_bytes));
                        String text_str = text.ToString();
                        // если пользователь решил подключится, узнаем его имя, пишем что он подключился и отправляем ответ
                        if (text_str.Contains("/CONECT"))
                        {
                            name = text_str.Trim('/', 'C', 'O', 'N', 'E', 'C', 'T');
                            Console.WriteLine(name + ": подключился к чату");
                            String mes = name + ": подключился к чату";
                            data = Encoding.Unicode.GetBytes(mes);
                            client.Send(data);
                        }
                        // если пользователь решил выйти, закрываем сокет, пишем что он отключился и отправляем ответ
                        if (text_str.Contains("/EXIT"))
                        {
                            Console.WriteLine(name + ": отключился от чата");
                            String mes = name + ": отключился от чата";
                            data = Encoding.Unicode.GetBytes(mes);
                            client.Send(data);
                            client.Shutdown(SocketShutdown.Both);
                            client.Close();
                            clientThread.Interrupt();
                        }
                        // если пользователь решил написать сообщение, узнаем это сообщение, пишем что он написал сообщение и отправляем ответ
                        if (text_str.Contains("/SEND"))
                        {
                            String mes = name + ": " + text_str.Trim('/', 'S', 'E', 'N', 'D');
                            Console.WriteLine(mes);
                            data = Encoding.Unicode.GetBytes(mes);
                            client.Send(data);
                        }

                    }
                }   catch (Exception ex){   }
            }      
        }

        static void Main(string[] args)
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            // создаем сокет и прослушиваем его
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            soket.Bind(ipPoint);
            soket.Listen(10);
            Console.WriteLine("Сервер запущен");
            while (true)
            {
                if(soket.Poll(-1, SelectMode.SelectRead))
                    { // создаем поток для клиента и запускаем его
                 clientThread = new Thread(new ThreadStart(users));
                clientThread.Start();}

            }
            
        }
    }
}
