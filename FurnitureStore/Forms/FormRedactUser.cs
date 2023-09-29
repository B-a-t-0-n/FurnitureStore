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
    public partial class FormRedactUser : Form
    {
        private LoginForm loginForm;
        private User user;
        public FormRedactUser(LoginForm loginForm)
        {
            InitializeComponent();
            listBoxUsers.DrawMode = DrawMode.OwnerDrawFixed;
            this.loginForm = loginForm;
            UpdateListBox();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                loginForm.databaseManagement.usersRepository.Update(user.UserId, "admin", checkBoxAdmin.Checked.ToString());
                loginForm.databaseManagement.UpdateTables("users");
            }
        }

        private void UpdateListBox()
        {
            listBoxUsers.Items.Clear();
            foreach (var item in loginForm.databaseManagement.usersRepository.GetAll())
            {
                listBoxUsers.Items.Add(item.Login);
            }
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex >= 0)
            {
                user = loginForm.databaseManagement.usersRepository.GetAll()[listBoxUsers.SelectedIndex];
                labelIdUser.Text = "Id :: " + user.UserId.ToString();
                labelLoginUser.Text = "Login :: " + user.Login;
                checkBoxAdmin.Checked = user.IsAdmin;
            }
        }

        private void listBoxUsers_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            // задаем параметры для рисования текущего элемента
            // Если элемент имеет состояние 'выбран' мы изменяем цвет его кисти бэкграунда на желтую, 
            //остальные параемтры оставим по умолчанию взятые из параметра `e`
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.SlateBlue);// <- обратить внимание сюда
            // Начинаем рисовать
            // Рисуем Background для каждого элемента
            e.DrawBackground();
            // Рисуем текст для каждого элемента
            e.Graphics.DrawString(listBoxUsers.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault);
            // если у текущеного элемента есть фокус, эта функция нарисует фокус
            e.DrawFocusRectangle();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                loginForm.databaseManagement.usersRepository.Remove(user);
                UpdateListBox();
                labelIdUser.Text = "Id :: ";
                labelLoginUser.Text = "Login :: ";
                loginForm.databaseManagement.UpdateTables("users");
            }
        }
    }
}
