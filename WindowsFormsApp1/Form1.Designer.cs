
namespace WindowsFormsApp1
{
    partial class Form_Authorization
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
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_authorization = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_text1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(57, 169);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(41, 13);
            this.label_login.TabIndex = 0;
            this.label_login.Text = "Логин:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(57, 195);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(48, 13);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Пароль:";
            // 
            // button_authorization
            // 
            this.button_authorization.Location = new System.Drawing.Point(104, 218);
            this.button_authorization.Name = "button_authorization";
            this.button_authorization.Size = new System.Drawing.Size(100, 23);
            this.button_authorization.TabIndex = 2;
            this.button_authorization.Text = "Войти";
            this.button_authorization.UseVisualStyleBackColor = true;
            this.button_authorization.Click += new System.EventHandler(this.button_authorization_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(104, 166);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(104, 192);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 4;
            // 
            // label_text1
            // 
            this.label_text1.AutoSize = true;
            this.label_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_text1.Location = new System.Drawing.Point(100, 126);
            this.label_text1.Name = "label_text1";
            this.label_text1.Size = new System.Drawing.Size(109, 20);
            this.label_text1.TabIndex = 5;
            this.label_text1.Text = "Авторизация";
            // 
            // Form_Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.label_text1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button_authorization);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_authorization;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_text1;
    }
}

