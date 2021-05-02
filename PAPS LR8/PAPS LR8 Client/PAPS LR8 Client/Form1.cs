using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAPS_LR8_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // делаем элементы невидимыми
            text.Visible = false;
            number.Visible = false;
            text_result.Visible = false;
            label2.Visible = false;
            
        }

        // флаг для определения задачи
        static int flag = 0;

        // функция для проверки введенных данных
        static int data(TextBox text)
        {
            int r = -1;
            try
            {
                r = Convert.ToInt32(text.Text); 
            }
            catch
            {
                text.ResetText();
            }
            return r;
        }

        // создание клиента для com объекта
        PAPS_LR8.Number client = new PAPS_LR8.Number();

        
        private void result_Click(object sender, EventArgs e)
        {
            // если задача не выбрана выводим предупреждение
            if (flag == 0) MessageBox.Show("Выберете задачу", "Предупреждение");
            else
            {
                // иначе проверяем правильность введенных данных. Если число не натуральное выводим предупреждение
                int r = data(number);
                if (r<0) MessageBox.Show("Введите натуральное число", "Предупреждение");
                else
                {
                    // иначе делаем объект для вывода результата видимым
                    text_result.Visible = true;
                    label2.Visible = true;
                    int res = 0;
                    List<int> list = new List<int>();
                    // если выбрана первая задача (нахождение факториала) запускаем соответствующую функцию и печатаем результат
                    if (flag == 1)
                    {
                        res = client.factor_n(r);
                        text_result.Text = r + "! = " + res;
                    }
                    // если выбрана вторая задача (нахождение простых чисел до заданного) запускаем соответствующую функцию и печатаем результат
                    if (flag == 2)
                    {
                        list = client.prost_n(r);
                        text_result.Text = "Простые числа до " + r + ": " ;
                        for (int i = 0; i < list.Count; i++)
                            text_result.AppendText(list[i].ToString() + " " );
                    }
                    // если выбрана третья задача (нахождение чисел Фибоначчи до заданного) запускаем соответствующую функцию и печатаем результат
                    if (flag == 3)
                    {
                        list = client.fibon_n(r);
                        text_result.Text = "Числа Фибоначчи до " + r + ": ";
                        for (int i = 0; i < list.Count; i++)
                            text_result.AppendText(list[i].ToString() + " ");
                    }

                }
            }
            
        }

        // задача на нахождение факториала. Приравниваем флаг единице, делаем объекты невидимыми
        private void factor_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
            text.Visible = true;
            number.Visible = true;
            number.ResetText();
            text_result.ResetText();
            text_result.Visible = false;
            label2.Visible = false;
        }
        // задача на нахождение простых чисел. Приравниваем флаг двойке, делаем объекты невидимыми
        private void prost_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
            text.Visible = true;
            number.Visible = true;
            number.ResetText();
            text_result.ResetText();
            text_result.Visible = false;
            label2.Visible = false;
        }
        // задача на нахождение чисел Фибоначчи. Приравниваем флаг тройке, делаем объекты невидимыми
        private void fibon_CheckedChanged(object sender, EventArgs e)
        {
           flag = 3;
            text.Visible = true;
            number.Visible = true;
            number.ResetText();
            text_result.ResetText();
            text_result.Visible = false;
            label2.Visible = false;
        }
    }
}
