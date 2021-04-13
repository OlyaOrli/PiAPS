using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace PAPS_LR7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // функция для проверки введенных чисел
        public int data_int(TextBox text)
        {
            int k = -1;
            try
            {
                k = Convert.ToInt32(text.Text);
            }
            catch
            {
                MessageBox.Show("Неверный формат числа", "Предупреждение");
                text.ResetText();
            }
            return k;
        }

        // функция создания файла
        public void text(String kafedra, String number_lr, String tema, String predmet, String avtor, String speciality,
            String grup, String teacher, String year)
        {
            // Получить объект приложения Word.
            Word.Application word_app = new Word.Application();
            word_app.Visible = true;

            // Создаем документ Word.
            object missing = Type.Missing;
            Word.Document word_doc = word_app.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            Word.Paragraph para = word_doc.Paragraphs.Last; // создаем параграф
            //задаем стиль
            para.Range.Font.Name = "Times New Roman";
            para.Range.Font.Size = 14;
            para.Range.Paragraphs.Space1();
            para.Range.Paragraphs.SpaceAfter = 0;

            para.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            
            //сохраняем текст
            para.Range.Text = "МИНИСТЕРСТВО НАУКИ И ВЫСШЕГО ОБРАЗОВАНИЯ\n" +
                "РОССИЙСКОЙ ФЕДЕРАЦИИ\n" +
            "ФЕДЕРАЛЬНОЕ ГОСУДАРСТВЕННОЕ БЮДЖЕТНОЕ ОБРАЗОВАТЕЛЬНОЕ УЧРЕЖДЕНИЕ ВЫСШЕГО ОБРАЗОВАНИЯ\n" +
            "«ОРЛОВСКИЙ ГОСУДАРСТВЕННЫЙ УНИВЕРСИТЕТ\n" +
            "ИМЕНИ И.С.ТУРГЕНЕВА»\n\n" +
            "Кафедра "+kafedra+"\n\n\n\n\n\n";

            para.Range.Text = "ОТЧЕТ";
            para.Range.Bold = 2;
            para.Range.InsertParagraphAfter();
            para.Range.Bold = 0;

            para.Range.Text = "По лабораторной работе №"+ number_lr+ "\n" +
                "на тему: «"+tema+"»\n" +
                "по дисциплине: «"+predmet+"»\n\n\n\n\n\n\n\n\n";

            para.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para.Range.Text = "Выполнил: "+avtor+"\n" +
                "Институт приборостроения, автоматизации и информационных технологий\n" +
                "Направление: "+speciality+"\n" +
                "Группа: "+grup+"\n" +
                "Проверил: "+teacher+"\n\n\n";

            para.Range.Text = "Отметка о зачете: \n";
            

            para.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            para.Range.Text = "Дата: «____» ____________ "+year+" г.\n";
           

            para.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            para.Range.Text = "\n\n\n\n\n\nОрел, "+year;
            para.Range.InsertParagraphAfter();
        }

        // считываем данные введенные пользователем и проверяем поля на пустоту
        private void result_Click(object sender, EventArgs e)
        {
            if ((predmet.Text == "") && (name_kafedra.Text == "") && (name_specialty.Text == "") && (number_grup.Text == "") && (number_specialty.Text == "")
                && (number.Text == "") && (tema.Text == "") && (year.Text == "") && (fio_student.Text == "") && (fio_teacher.Text == ""))
                MessageBox.Show("Заполните все поля", "Предупреждение");
            else
            {
                String s_kafedra, s_number_lr, s_tema, s_predmet, s_avtor, s_grup, s_teacher, s_year, speciality;
               
                int n1 = data_int(number);
                int n2 = data_int(year);
                if ((n1>0)&&(n2>1980))
                {
                    s_kafedra = name_kafedra.Text;
                    s_predmet = name_kafedra.Text;
                    s_number_lr = number.Text;
                    s_tema = tema.Text;
                    s_predmet = predmet.Text;
                    s_avtor = fio_student.Text;
                    speciality = number_specialty.Text + " " + name_specialty.Text;
                    s_grup = number_grup.Text;
                    s_teacher = fio_teacher.Text;
                    s_year = year.Text;
                    text(s_kafedra, s_number_lr, s_tema, s_predmet, s_avtor, speciality, s_grup, s_teacher, s_year);
                }
                
            }


        }
    }
}
