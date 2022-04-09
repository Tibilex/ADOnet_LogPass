namespace Dapper
{
    partial class MainForm
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
            this.SignInbutton = new System.Windows.Forms.Button();
            this.SignUpbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignInbutton
            // 
            this.SignInbutton.Location = new System.Drawing.Point(100, 34);
            this.SignInbutton.Name = "SignInbutton";
            this.SignInbutton.Size = new System.Drawing.Size(100, 40);
            this.SignInbutton.TabIndex = 0;
            this.SignInbutton.Text = "Sign In";
            this.SignInbutton.UseVisualStyleBackColor = true;
            // 
            // SignUpbutton
            // 
            this.SignUpbutton.Location = new System.Drawing.Point(100, 80);
            this.SignUpbutton.Name = "SignUpbutton";
            this.SignUpbutton.Size = new System.Drawing.Size(100, 40);
            this.SignUpbutton.TabIndex = 1;
            this.SignUpbutton.Text = "Sign Up";
            this.SignUpbutton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SignUpbutton);
            this.Controls.Add(this.SignInbutton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SignInbutton;
        private System.Windows.Forms.Button SignUpbutton;
    }
}

