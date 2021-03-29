using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace PAPS_LR3
{
    public partial class Form1 : Form
    {
        static int port = 8005;
        static Socket soket;
        static String text_str, name;
        static bool f=false;
        static IPEndPoint ipPoint;
        static Thread clientThread;
        //обновление графического интерфейса из второго потока
        public void ChangeText(string text)
        {
            if (InvokeRequired)
                Invoke(new Action<string>(ChangeText), text);
            else
            message.AppendText(text + Environment.NewLine);
        }

        public Form1()
        {
            InitializeComponent();
        }
        // метод для потока в котором происходит получение ответов от сервера в бесконечном цикле
        public void server()
        {
            while(true)
            {
             
                byte[] data = new byte[1024];
                StringBuilder text = new StringBuilder();
                try
                {
                    // если есть сообщение, то узнаем какое именно, считываем его и запускаем метод для обновления графического интерфейса 
                    if (soket.Available > 0)
                    {
                        int read_bytes = soket.Receive(data, data.Length, 0);
                        text.Append(Encoding.Unicode.GetString(data, 0, read_bytes));
                        text_str = text.ToString() + "\n";
                        ChangeText(text_str);
                    }
                }catch (Exception ex){ break; }
            }
        }

        private void Invoke()
        {
            throw new NotImplementedException();
        }


        // обработка нажатия на кнопку подключится
        private void conect_Click(object sender, EventArgs e)
        {
            // проверка полей на пустоту, а после проверяем подключен ли пользователь
            
            if (text_user_name.Text == "") MessageBox.Show("Напишите ваше имя", "Предупреждение");
            else
            {
                if (!f)
                {
                    f = true;
                    ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                    // создаем сокет
                    soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soket.Connect(ipPoint);
                    clientThread = new Thread(new ThreadStart(server));
                    clientThread.Start();
                    
                    // создоем сообщения для отправки: ключечевое слово + имя пользователя с клавиатуры, 
                    // после переводим строку в байты и отправляем ее
                    name =text_user_name.Text;
                    String mes = "/CONECT" + name;
                    byte[] data = Encoding.Unicode.GetBytes(mes);
                    soket.Send(data);
                } else MessageBox.Show("Вы уже подключены", "Предупреждение");
            }
        }

        // обработка нажатия на кнопку отправить
        private void send_Click(object sender, EventArgs e)
        {
            // проверка поля на пустоту, а после проверяем подключен ли пользователь
            if (text_send.Text == "") MessageBox.Show("Напишите сообщение", "Предупреждение");
            else
            {
                if (f)
                {
                    // создоем сообщения для отправки: ключечевое слово + техст сообщения введенное с клавиатуры, 
                    // после переводим строку в байты и отправляем ее
                    String mes = "/SEND"  + text_send.Text;
                    byte[] data = Encoding.Unicode.GetBytes(mes);
                    soket.Send(data);
                    text_send.ResetText();
                } else MessageBox.Show("Напишите IP сервера", "Сначала подключитесь к чату");
            }
        }

        // обработка нажатия на кнопку отключится
        private void exit_Click(object sender, EventArgs e)
        {
            // проверка зарегестрирован ли пользователь
            if(f)
            {
                // создоем сообщения для отправки: ключечевое слово для выхода, 
                // после переводим строку в байты и отправляем ее
                String mes = "/EXIT";
                byte[] data = Encoding.Unicode.GetBytes(mes); 
                soket.Send(data); 
               // закрываем сокет, обнуляем поля и флаг подключения
                soket.Shutdown(SocketShutdown.Both);
                soket.Close();
                clientThread.Interrupt();
                text_user_name.ResetText();
                f = false;
                
                
            }
            else
            {
                // вывод предупреждения о том, что нужно войти в чат
                MessageBox.Show("Сначала войдите в чат", "Предупреждение");
            }
        }
    }
    
}
