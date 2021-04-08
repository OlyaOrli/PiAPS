using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Используемый веб-сервис работает с двумя целыми числами и выполняет следующие функции:
// сложение, вычитание, умножение, деление.

namespace PAPS_LR5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int number1, number2;
        bool f=false, f1=false;

        //Веб-сервис -  калькулятор, создаем и подключаем клиента
        ServiceReference1.CalculatorSoap calculator = new ServiceReference1.CalculatorSoapClient();
        
        
        // функция для считывыния данных. Проверка на пустоту полей и верный формат введенных чисел.
        public void data()
        {
            if ((first.Text == "") && (second.Text == "")) MessageBox.Show("Сначала введите числа", "Предупреждение");
            else if (first.Text == "") MessageBox.Show("Введите первое число", "Предупреждение");
            else if (second.Text == "") MessageBox.Show("Введите второе число", "Предупреждение");
            else
            {
                try
                {
                    number1 = Convert.ToInt32(first.Text);
                    f = true;
                }
                catch (Exception ex)
                {
                    first.ResetText();
                    MessageBox.Show("Неверный формат первого числа.\nВведите целое число", "Предупреждение");
                }
                try
                {
                    number2 = Convert.ToInt32(second.Text);
                    f1 = true;
                }
                catch (Exception ex)
                {
                    second.ResetText();
                    MessageBox.Show("Неверный формат второго числа.\nВведите целое число", "Предупреждение");
                }
                
            }
        }

        // метод отвечающий за сложение. Запуск функции считывыния данных, отправка чисел на сервер, получение ответа и отображение
        private void add_Click(object sender, EventArgs e)
        {
            data();
            if (f && f1)
            {
                String str = "Результат: " + calculator.Add(number1, number2).ToString();
                result.Text = str;
            }
        }

        // метод отвечающий за вычитание. Запуск функции считывыния данных, отправка чисел на сервер, получение ответа и отображение
        private void minus_Click(object sender, EventArgs e)
        {
            data();
            if (f && f1)
            {
                String str = "Результат: " + calculator.Subtract(number1, number2).ToString();
                result.Text = str;
            }
        }

        // метод отвечающий за умножение. Запуск функции считывыния данных, отправка чисел на сервер, получение ответа и отображение
        private void multiplication_Click(object sender, EventArgs e)
        {
            data();
            if (f && f1)
            {
                String str = "Результат: " + calculator.Multiply(number1, number2).ToString();
                result.Text = str;
            }
        }

        // метод отвечающий за деление. Запуск функции считывыния данных, отправка чисел на сервер, получение ответа и отображение
        private void division_Click(object sender, EventArgs e)
        {
            data();
            if (f && f1)
            {
                if (number2 == 0)
                {
                    result.Text = "Результат: Ошибка. На 0 делить нельзя";

                }
                else
                {
                    String str = "Результат: " + calculator.Divide(number1, number2).ToString();
                    result.Text = str;
                }
            }
        }
    }
}
