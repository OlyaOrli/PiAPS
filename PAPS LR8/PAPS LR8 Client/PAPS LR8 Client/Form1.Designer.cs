
namespace PAPS_LR8_Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.factor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.prost = new System.Windows.Forms.RadioButton();
            this.fibon = new System.Windows.Forms.RadioButton();
            this.number = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.text_result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // factor
            // 
            this.factor.AutoSize = true;
            this.factor.Location = new System.Drawing.Point(109, 80);
            this.factor.Name = "factor";
            this.factor.Size = new System.Drawing.Size(195, 21);
            this.factor.TabIndex = 0;
            this.factor.TabStop = true;
            this.factor.Text = "Нахождение факториала";
            this.factor.UseVisualStyleBackColor = true;
            this.factor.CheckedChanged += new System.EventHandler(this.factor_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Задача";
            // 
            // prost
            // 
            this.prost.AutoSize = true;
            this.prost.Location = new System.Drawing.Point(109, 125);
            this.prost.Name = "prost";
            this.prost.Size = new System.Drawing.Size(211, 21);
            this.prost.TabIndex = 2;
            this.prost.TabStop = true;
            this.prost.Text = "Нахождение простых чисел";
            this.prost.UseVisualStyleBackColor = true;
            this.prost.CheckedChanged += new System.EventHandler(this.prost_CheckedChanged);
            // 
            // fibon
            // 
            this.fibon.AutoSize = true;
            this.fibon.Location = new System.Drawing.Point(109, 165);
            this.fibon.Name = "fibon";
            this.fibon.Size = new System.Drawing.Size(234, 21);
            this.fibon.TabIndex = 3;
            this.fibon.TabStop = true;
            this.fibon.Text = "Нахождение чисел Фибоначчи";
            this.fibon.UseVisualStyleBackColor = true;
            this.fibon.CheckedChanged += new System.EventHandler(this.fibon_CheckedChanged);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(271, 221);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 22);
            this.number.TabIndex = 4;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(61, 224);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(106, 17);
            this.text.TabIndex = 5;
            this.text.Text = "Введите число";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(161, 260);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(99, 37);
            this.result.TabIndex = 6;
            this.result.Text = "Найти";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // text_result
            // 
            this.text_result.Location = new System.Drawing.Point(64, 342);
            this.text_result.Multiline = true;
            this.text_result.Name = "text_result";
            this.text_result.Size = new System.Drawing.Size(307, 121);
            this.text_result.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ответ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_result);
            this.Controls.Add(this.result);
            this.Controls.Add(this.text);
            this.Controls.Add(this.number);
            this.Controls.Add(this.fibon);
            this.Controls.Add(this.prost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.factor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton factor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton prost;
        private System.Windows.Forms.RadioButton fibon;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.TextBox text_result;
        private System.Windows.Forms.Label label2;
    }
}

