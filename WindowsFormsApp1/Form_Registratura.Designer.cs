
namespace WindowsFormsApp1
{
    partial class Form_Registratura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_CreateNewRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_CreateNewRecord
            // 
            this.button_CreateNewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CreateNewRecord.Location = new System.Drawing.Point(200, 200);
            this.button_CreateNewRecord.Name = "button_CreateNewRecord";
            this.button_CreateNewRecord.Size = new System.Drawing.Size(412, 23);
            this.button_CreateNewRecord.TabIndex = 0;
            this.button_CreateNewRecord.Text = "Создать новую запись";
            this.button_CreateNewRecord.UseVisualStyleBackColor = true;
            this.button_CreateNewRecord.Click += new System.EventHandler(this.button_CreateNewRecord_Click);
            // 
            // Form_Registratura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_CreateNewRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Registratura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Registratura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CreateNewRecord;
    }
}