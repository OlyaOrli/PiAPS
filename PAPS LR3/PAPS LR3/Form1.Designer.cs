
namespace PAPS_LR3
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
            this.send = new System.Windows.Forms.Button();
            this.text_send = new System.Windows.Forms.TextBox();
            this.conect = new System.Windows.Forms.Button();
            this.text_user_name = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.user_name = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(352, 523);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(175, 33);
            this.send.TabIndex = 0;
            this.send.Text = "Отправить";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // text_send
            // 
            this.text_send.Location = new System.Drawing.Point(35, 523);
            this.text_send.Multiline = true;
            this.text_send.Name = "text_send";
            this.text_send.Size = new System.Drawing.Size(294, 33);
            this.text_send.TabIndex = 1;
            // 
            // conect
            // 
            this.conect.Location = new System.Drawing.Point(86, 59);
            this.conect.Name = "conect";
            this.conect.Size = new System.Drawing.Size(123, 32);
            this.conect.TabIndex = 2;
            this.conect.Text = "Подключиться";
            this.conect.UseVisualStyleBackColor = true;
            this.conect.Click += new System.EventHandler(this.conect_Click);
            // 
            // text_user_name
            // 
            this.text_user_name.Location = new System.Drawing.Point(223, 19);
            this.text_user_name.Name = "text_user_name";
            this.text_user_name.Size = new System.Drawing.Size(304, 22);
            this.text_user_name.TabIndex = 4;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(35, 109);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(492, 399);
            this.message.TabIndex = 5;
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(32, 19);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(131, 17);
            this.user_name.TabIndex = 7;
            this.user_name.Text = "Имя пользователя";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(366, 59);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(123, 32);
            this.exit.TabIndex = 8;
            this.exit.Text = "Отключиться";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 582);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.message);
            this.Controls.Add(this.text_user_name);
            this.Controls.Add(this.conect);
            this.Controls.Add(this.text_send);
            this.Controls.Add(this.send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox text_send;
        private System.Windows.Forms.Button conect;
        private System.Windows.Forms.TextBox text_user_name;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Button exit;
    }
}

