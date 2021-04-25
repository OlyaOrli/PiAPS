using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAPS_LR6_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // При запуске делаем поля невидимыми
            label4.Visible = false;
            label5.Visible = false;
            number.Visible = false;
            count.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            mesto_otpravlen.Visible = false;
            mesto_pribut.Visible = false;
            date.Visible = false;
        }


        // функция обработки введенных данных, проверка, чтобы это было число
        static int data_int(TextBox text)
        {
            int res = -1;
            try
            {
                res = Convert.ToInt32(text.Text);
            }
            catch
            {
                MessageBox.Show("Неверный формат введенных данных.\nВведите натуральное число", "Предупреждение");
                text.ResetText();
            }
            return res;
        }

        // создание клиента веб сервиса
        webservice.IService1 client = new webservice.Service1Client();

        static void obnovlen(List<String> list, TextBox result)
        {
            result.ResetText();
            for (int i = 0; i < list.Count - 4; i++)
            {
                result.AppendText(list[i] + "   " + list[i + 1] + "   " + list[i + 2] + "   " + list[i + 3] + "   " + list[i + 4] + Environment.NewLine);
                i = i + 4;
            }
        }

        static int f = 0, flag_reise = 0;

        // при нажатии на радио кнопку делаем нужные поля видимыми и обнуляем все значения
        private void otkuda_CheckedChanged(object sender, EventArgs e)
        {
            flag_reise = 2;
            f = 0;

            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = true;
            mesto_otpravlen.Visible = true;
            mesto_pribut.Visible = false;
            date.Visible = true;


            label4.Visible = false;
            label5.Visible = false;
            number.Visible = false;
            count.Visible = false;

            ok_btn.Text = "Найти билеты";
            mesto_otpravlen.ResetText();
            mesto_pribut.ResetText();
            count.ResetText();
            number.ResetText();
            result.ResetText();

        }

        // при нажатии на радио кнопку делаем нужные поля видимыми и обнуляем все значения
        private void kuda_CheckedChanged(object sender, EventArgs e)
        {
            flag_reise = 1;
            f = 0;

            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            mesto_otpravlen.Visible = false;
            mesto_pribut.Visible = true;
            date.Visible = true;


            label4.Visible = false;
            label5.Visible = false;
            number.Visible = false;
            count.Visible = false;

            ok_btn.Text = "Найти билеты";
            mesto_otpravlen.ResetText();
            mesto_pribut.ResetText();
            count.ResetText();
            number.ResetText();
            result.ResetText();
        }

        // при нажатии на радио кнопку делаем нужные поля видимыми и обнуляем все значения
        private void otkuda_kuda_CheckedChanged(object sender, EventArgs e)
        {
            flag_reise = 3;
            f = 0;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            mesto_otpravlen.Visible = true;
            mesto_pribut.Visible = true;
            date.Visible = true;


            label4.Visible = false;
            label5.Visible = false;
            number.Visible = false;
            count.Visible = false;


            ok_btn.Text = "Найти билеты";
            mesto_otpravlen.ResetText();
            mesto_pribut.ResetText();
            count.ResetText();
            number.ResetText();
            result.ResetText();
        }



        private void ok_btn_Click(object sender, EventArgs e)
        {
            // проверка полей на пустоту
            if ((mesto_otpravlen.Text != "") || (mesto_pribut.Text != ""))
            {
                List<String> marshrut = new List<String>();

                //выбрана одна из радио кнопок, иначе выводим предупреждение 
                if ((flag_reise == 1) || (flag_reise == 2) || (flag_reise == 3))
                {
                    // в зависимости от флага запускаем нужную функцию нахождения рейса
                    if (flag_reise == 3) marshrut = new List<String>(client.reise(mesto_otpravlen.Text, mesto_pribut.Text));
                    if (flag_reise == 2) marshrut = new List<String>(client.reise_otkuda(mesto_otpravlen.Text));
                    if (flag_reise == 1) marshrut = new List<String>(client.reise_kuda(mesto_pribut.Text));
                    // если лист пустой, выводим сообщение о том что нет маршутов
                    if (marshrut.Count > 0)
                    {
                        // если в листе что-то есть делаем поля бронирования видимыми и отображаем рейсы
                        f++;
                        label4.Visible = true;
                        label5.Visible = true;
                        number.Visible = true;
                        count.Visible = true;
                        ok_btn.Text = "Забронировать";
                        obnovlen(marshrut, result);
                        if (f > 1)
                        {
                            int k = data_int(count);
                            int n = data_int(number);
                            if ((k > 0) && (n > 0))
                            {
                                // отправляем номер рейса и количество мест, после отображаем измененную информацию о рейсах
                                bool flag = false;
                                for (int j = 0; j < marshrut.Count; j++)
                                    if (n.ToString() == marshrut[j])
                                    {
                                        MessageBox.Show(client.bron(n, k), "Предупреждение");
                                        List<String> marshrut1 = new List<String>();
                                        if (flag_reise == 3) marshrut1 = new List<String>(client.reise(mesto_otpravlen.Text, mesto_pribut.Text));
                                        if (flag_reise == 2) marshrut1 = new List<String>(client.reise_otkuda(mesto_otpravlen.Text));
                                        if (flag_reise == 1) marshrut1 = new List<String>(client.reise_kuda(mesto_pribut.Text));
                                        obnovlen(marshrut1, result);
                                        j = j + 4;
                                        flag = true;
                                        break;
                                    }
                                    else j = j + 4;
                                if (!flag) { MessageBox.Show("Нет такого рейса", "Предупреждение"); number.ResetText(); }
                            }
                            else
                            {
                                MessageBox.Show("Введите натуральное число", "Предупреждение");
                                if (k <= 0) count.ResetText();
                                if (n <= 0) number.ResetText();
                            }
                        }

                    }
                    else result.Text = "Нет маршрутов";
                }
                else MessageBox.Show("Выбирете вид маршута", "Предупреждение");
            }
            else MessageBox.Show("Заполните все поля", "Предупреждение");
        }
    }
}
