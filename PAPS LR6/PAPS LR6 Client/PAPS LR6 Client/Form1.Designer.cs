
namespace PAPS_LR6_Client
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
            this.kuda = new System.Windows.Forms.RadioButton();
            this.otkuda_kuda = new System.Windows.Forms.RadioButton();
            this.otkuda = new System.Windows.Forms.RadioButton();
            this.ok_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.mesto_pribut = new System.Windows.Forms.TextBox();
            this.mesto_otpravlen = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kuda
            // 
            this.kuda.AutoSize = true;
            this.kuda.Location = new System.Drawing.Point(885, 68);
            this.kuda.Name = "kuda";
            this.kuda.Size = new System.Drawing.Size(61, 21);
            this.kuda.TabIndex = 59;
            this.kuda.TabStop = true;
            this.kuda.Text = "Куда";
            this.kuda.UseVisualStyleBackColor = true;
            this.kuda.CheckedChanged += new System.EventHandler(this.kuda_CheckedChanged);
            // 
            // otkuda_kuda
            // 
            this.otkuda_kuda.AutoSize = true;
            this.otkuda_kuda.Location = new System.Drawing.Point(914, 95);
            this.otkuda_kuda.Name = "otkuda_kuda";
            this.otkuda_kuda.Size = new System.Drawing.Size(113, 21);
            this.otkuda_kuda.TabIndex = 58;
            this.otkuda_kuda.TabStop = true;
            this.otkuda_kuda.Text = "Откуда/Куда";
            this.otkuda_kuda.UseVisualStyleBackColor = true;
            this.otkuda_kuda.CheckedChanged += new System.EventHandler(this.otkuda_kuda_CheckedChanged);
            // 
            // otkuda
            // 
            this.otkuda.AutoSize = true;
            this.otkuda.Location = new System.Drawing.Point(989, 68);
            this.otkuda.Name = "otkuda";
            this.otkuda.Size = new System.Drawing.Size(77, 21);
            this.otkuda.TabIndex = 57;
            this.otkuda.TabStop = true;
            this.otkuda.Text = "Откуда";
            this.otkuda.UseVisualStyleBackColor = true;
            this.otkuda.CheckedChanged += new System.EventHandler(this.otkuda_CheckedChanged);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(874, 472);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(180, 41);
            this.ok_btn.TabIndex = 56;
            this.ok_btn.Text = "Найти билеты";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(852, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Количество мест";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(852, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Номер рейса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(852, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Дата отправления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(852, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Место прибытия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(852, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Место отправления";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(989, 423);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(100, 22);
            this.count.TabIndex = 50;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(989, 378);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 22);
            this.number.TabIndex = 49;
            // 
            // mesto_pribut
            // 
            this.mesto_pribut.Location = new System.Drawing.Point(855, 240);
            this.mesto_pribut.Name = "mesto_pribut";
            this.mesto_pribut.Size = new System.Drawing.Size(234, 22);
            this.mesto_pribut.TabIndex = 48;
            // 
            // mesto_otpravlen
            // 
            this.mesto_otpravlen.Location = new System.Drawing.Point(855, 173);
            this.mesto_otpravlen.Name = "mesto_otpravlen";
            this.mesto_otpravlen.Size = new System.Drawing.Size(234, 22);
            this.mesto_otpravlen.TabIndex = 47;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(855, 316);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(234, 22);
            this.date.TabIndex = 46;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(49, 57);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(765, 462);
            this.result.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 573);
            this.Controls.Add(this.kuda);
            this.Controls.Add(this.otkuda_kuda);
            this.Controls.Add(this.otkuda);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.count);
            this.Controls.Add(this.number);
            this.Controls.Add(this.mesto_pribut);
            this.Controls.Add(this.mesto_otpravlen);
            this.Controls.Add(this.date);
            this.Controls.Add(this.result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton kuda;
        private System.Windows.Forms.RadioButton otkuda_kuda;
        private System.Windows.Forms.RadioButton otkuda;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox mesto_pribut;
        private System.Windows.Forms.TextBox mesto_otpravlen;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox result;
    }
}

