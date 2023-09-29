using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace FurnitureStore
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            buttonReg = new Button();
            textBoxPasswCopy = new TextBox();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // buttonReg
            // 
            buttonReg.BackColor = Color.PaleTurquoise;
            buttonReg.Cursor = Cursors.Hand;
            buttonReg.FlatAppearance.BorderSize = 0;
            buttonReg.FlatStyle = FlatStyle.Flat;
            buttonReg.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReg.ForeColor = Color.FromArgb(64, 64, 64);
            buttonReg.Location = new Point(61, 271);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(179, 34);
            buttonReg.TabIndex = 1;
            buttonReg.Text = "Зарегестрироваться";
            buttonReg.UseVisualStyleBackColor = false;
            buttonReg.Click += buttonReg_Click;
            // 
            // textBoxPasswCopy
            // 
            textBoxPasswCopy.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswCopy.Location = new Point(12, 212);
            textBoxPasswCopy.Multiline = true;
            textBoxPasswCopy.Name = "textBoxPasswCopy";
            textBoxPasswCopy.Size = new Size(228, 36);
            textBoxPasswCopy.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(12, 143);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(228, 36);
            textBoxPassword.TabIndex = 5;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(12, 75);
            textBoxLogin.Multiline = true;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(228, 36);
            textBoxLogin.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 7;
            label1.Text = "Регистрация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 8;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 189);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 10;
            label4.Text = "Повторите пароль";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(64, 64, 64);
            buttonBack.BackgroundImageLayout = ImageLayout.Stretch;
            buttonBack.Cursor = Cursors.Hand;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Image = Properties.Resources.back;
            buttonBack.ImageAlign = ContentAlignment.MiddleRight;
            buttonBack.Location = new Point(12, 271);
            buttonBack.Name = "buttonBack";
            buttonBack.RightToLeft = RightToLeft.No;
            buttonBack.Size = new Size(43, 34);
            buttonBack.TabIndex = 11;
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(253, 314);
            Controls.Add(buttonBack);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxPasswCopy);
            Controls.Add(buttonReg);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReg;
        private TextBox textBoxPasswCopy;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonBack;
    }
}