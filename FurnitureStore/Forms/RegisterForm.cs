using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace FurnitureStore
{
    public partial class RegisterForm : Form
    {
        private LoginForm logForm;

        public RegisterForm(LoginForm logForm)
        {
            InitializeComponent();
            this.logForm = logForm;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            logForm.Show();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Length >= 4)
            {
                if (textBoxPassword.Text.Length >= 5)
                {
                    if (textBoxPassword.Text == textBoxPasswCopy.Text)
                    {
                        bool noCopy = true;
                        foreach (var item in logForm.databaseManagement.usersRepository.GetAll())
                        {
                            if (item.Login == textBoxLogin.Text)
                                noCopy = false;
                        }

                        if (noCopy)
                        {
                            logForm.databaseManagement.usersRepository.Add(new User(
                                                            logForm.databaseManagement.usersRepository.GetIdLastUser() + 1,
                                                            textBoxLogin.Text,
                                                            textBoxPassword.Text, "false"));
                            logForm.databaseManagement.UpdateTables("users");
                            this.Hide();
                            logForm.Show();
                        }
                        else
                            MessageBox.Show("данный логин уже используется");

                    }
                    else
                        MessageBox.Show("пароли не совпадают");
                }
                else
                    MessageBox.Show("пароль должен состоять минимум из 5 символов");
            }
            else
                MessageBox.Show("логин должен состоять минимум из 4 символов");
        }
    }
}
