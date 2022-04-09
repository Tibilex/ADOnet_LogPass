namespace Dapper
{
    partial class SignUp
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
            this.PasstextBox = new System.Windows.Forms.TextBox();
            this.MailtextBox = new System.Windows.Forms.TextBox();
            this.SignInbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasstextBox
            // 
            this.PasstextBox.Location = new System.Drawing.Point(90, 90);
            this.PasstextBox.Name = "PasstextBox";
            this.PasstextBox.Size = new System.Drawing.Size(120, 20);
            this.PasstextBox.TabIndex = 5;
            // 
            // MailtextBox
            // 
            this.MailtextBox.Location = new System.Drawing.Point(90, 50);
            this.MailtextBox.Name = "MailtextBox";
            this.MailtextBox.Size = new System.Drawing.Size(120, 20);
            this.MailtextBox.TabIndex = 4;
            // 
            // SignInbutton
            // 
            this.SignInbutton.Location = new System.Drawing.Point(90, 130);
            this.SignInbutton.Name = "SignInbutton";
            this.SignInbutton.Size = new System.Drawing.Size(120, 23);
            this.SignInbutton.TabIndex = 3;
            this.SignInbutton.Text = "button1";
            this.SignInbutton.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PasstextBox);
            this.Controls.Add(this.MailtextBox);
            this.Controls.Add(this.SignInbutton);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasstextBox;
        private System.Windows.Forms.TextBox MailtextBox;
        private System.Windows.Forms.Button SignInbutton;
    }
}