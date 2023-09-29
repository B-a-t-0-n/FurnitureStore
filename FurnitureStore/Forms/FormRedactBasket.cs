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
    public partial class FormRedactBasket : Form
    {
        LoginForm loginForm;
        User user;
        Product product;
        public FormRedactBasket(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            listBoxUsers.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxProducts.DrawMode = DrawMode.OwnerDrawFixed;
            UpdateListBoxUsers();
        }

        private void UpdateListBoxUsers()
        {
            listBoxUsers.Items.Clear();
            foreach (var item in loginForm.databaseManagement.usersRepository.GetAll())
            {
                listBoxUsers.Items.Add(item.Login);
            }
        }

        private void UpdatelistBoxProducts()
        {
            listBoxProducts.Items.Clear();
            foreach (var item in user.basketList)
            {
                Product pr = loginForm.databaseManagement.productsRepository.GetProduct(item.ProductId);
                listBoxProducts.Items.Add($"{pr.TypeFurniture} {pr.ProductName}");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            loginForm.databaseManagement.UpdateTables("basket");
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex >= 0)
            {
                user = loginForm.databaseManagement.usersRepository.GetAll()[listBoxUsers.SelectedIndex];
                UpdatelistBoxProducts();
            }

        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex >= 0)
            {
                product = loginForm.databaseManagement.productsRepository.GetProduct(user.basketList[listBoxProducts.SelectedIndex].ProductId);
                foreach (var item in user.basketList)
                {
                    if (item.ProductId == product.ProductId)
                        labelInfoCount.Text = item.Count.ToString();
                }

            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (product != null)
            {
                for (int i = 0; i < user.basketList.Count; i++)
                {
                    if (user.basketList[i].ProductId == product.ProductId)
                    {
                        user.basketList.Remove(user.basketList[i]);
                        UpdatelistBoxProducts();
                        loginForm.databaseManagement.UpdateTables("basket");
                        break;
                    }
                }
            }
        }

        private void buttonPluse_Click(object sender, EventArgs e)
        {
            buttonOperation_Click(1);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            buttonOperation_Click(-1);
        }

        private void buttonOperation_Click(int operand)
        {
            if(product != null)
            {
                int Count = 0;
                for (int i = 0; i < user.basketList.Count; i++)
                {
                    if (user.basketList[i].ProductId == product.ProductId)
                    {
                        if (user.basketList[i].Count + operand >= 1)
                            user.basketList[i].Count += operand;
 
                        Count = user.basketList[i].Count;
                        labelInfoCount.Text = Count.ToString();
                        break;
                    }
                }
            }
        }

        private void listBoxUsers_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
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
            e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault);
            // если у текущеного элемента есть фокус, эта функция нарисует фокус
            e.DrawFocusRectangle();
        }
    }
}
