using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace FurnitureStore
{
    public partial class FormRedactProduct : Form
    {
        private LoginForm loginForm;
        Product product;
        Label labelNotification;
        int tic;
        public FormRedactProduct(LoginForm loginForm)
        {
            InitializeComponent();
            listBoxProducts.DrawMode = DrawMode.OwnerDrawFixed;
            this.loginForm = loginForm;
            tic = 0;
            UpdateListBoxItem();

            labelNotification = new Label();
            labelNotification.AutoSize = true;
            labelNotification.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNotification.ForeColor = Color.FromArgb(0, 192, 0);
            labelNotification.Location = new Point(54, 12);
            labelNotification.Name = "labellabelNotification";
            labelNotification.Size = new Size(163, 47);
            labelNotification.TabIndex = 0;
            labelNotification.Text = "";
            panelInfo.Controls.Add(labelNotification);


        }

        private void UpdateListBoxItem()
        {
            listBoxProducts.Items.Clear();
            foreach (var item in loginForm.databaseManagement.productsRepository.GetAll())
            {
                listBoxProducts.Items.Add($"{item.TypeFurniture} {item.ProductName}");
            }
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex >= 0)
            {
                product = loginForm.databaseManagement.productsRepository.GetAll()[listBoxProducts.SelectedIndex];
                textBoxNameProduct.Text = product.ProductName;
                textBoxTypeProduct.Text = product.TypeFurniture;
                textBoxPriceProduct.Text = product.Price.ToString();
                byte[] bytes = product.Image;
                System.Drawing.Image image;

                using (MemoryStream stream = new MemoryStream(bytes))
                {
                    image = System.Drawing.Image.FromStream(stream);
                }

                pictureBoxProduct.Image = image;
            }
        }

        private void listBoxProducts_DrawItem(object sender, DrawItemEventArgs e)
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
            e.Graphics.DrawString(listBoxProducts.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault);

            // если у текущеного элемента есть фокус, эта функция нарисует фокус
            e.DrawFocusRectangle();
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            Bitmap image; //Bitmap для открываемого изображения

            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    Button button = (Button)sender;
                    Panel panel = button.Parent as Panel;
                    PictureBox pictureBox = null;

                    foreach (var item in panel.Controls)
                    {
                        if (item.GetType() == typeof(PictureBox))
                        {
                            pictureBox = (PictureBox)item;
                        }
                    }

                    image = new Bitmap(open_dialog.FileName);
                    pictureBox.Image = image;
                    pictureBox.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSaveNewProduct_Click(object sender, EventArgs e)
        {
            int idProduct = loginForm.databaseManagement.productsRepository.GetIdLastProduct() + 1;
            string productName = textBoxNameNewProduct.Text;
            string typeFurniture = textBoxTypeNewProduct.Text;
            decimal price;
            decimal.TryParse(textBoxPriceNewProduct.Text, out price);
            System.Drawing.Image image = pictureBoxNewProduct.Image;
            byte[] bytes;

            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, image.RawFormat);
                bytes = stream.ToArray();
            }

            if (CheckProduct(productName, typeFurniture, price.ToString()))
            {
                Product newProduct = new Product(idProduct, productName, typeFurniture, price, bytes);
                loginForm.databaseManagement.productsRepository.Add(newProduct);
                loginForm.databaseManagement.UpdateTables("products");
                textBoxNameNewProduct.Text = "";
                textBoxTypeNewProduct.Text = "";
                textBoxPriceNewProduct.Text = "";
                pictureBoxNewProduct.Image = Properties.Resources._1;
                UpdateListBoxItem();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (product != null)
            {
                loginForm.databaseManagement.productsRepository.Remove(product);
                UpdateListBoxItem();
                textBoxNameProduct.Text = "";
                textBoxTypeProduct.Text = "";
                textBoxPriceProduct.Text = "";
                pictureBoxProduct.Image = Properties.Resources._1;
                loginForm.databaseManagement.UpdateTables("products");
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (product != null)
            {
                string productName = textBoxNameProduct.Text;
                string typeFurniture = textBoxTypeProduct.Text;
                string price = textBoxPriceProduct.Text;
                if (CheckProduct(productName, typeFurniture, price))
                {
                    loginForm.databaseManagement.productsRepository.Update(product.ProductId, "name", productName);
                    loginForm.databaseManagement.productsRepository.Update(product.ProductId, "type", typeFurniture);
                    loginForm.databaseManagement.productsRepository.Update(product.ProductId, "price", price);
                    loginForm.databaseManagement.productsRepository.UpdateImage(product.ProductId, new Bitmap(pictureBoxProduct.Image));
                    loginForm.databaseManagement.UpdateTables("products");

                }
            }
        }

        bool CheckProduct(string name, string type, string price)
        {
            decimal priceP;
            if (decimal.TryParse(price, out priceP))
            {
                if (name.Length >= 3)
                {
                    if (type.Length >= 3)
                    {
                        if (priceP > 0)
                        {
                            tic = 0;
                            timerNotification.Enabled = true;
                            timerNotification.Start();

                            return true;
                        }
                        else
                            MessageBox.Show("цена за товар должна быть больше 0");
                    }
                    else
                        MessageBox.Show("тип товара должен состоять минимум из 3 символов");
                }
                else
                    MessageBox.Show("название товара должно состоять минимум из 3 символов");
            }
            else
                MessageBox.Show("вводите цену правильно");
            return false;
        }

        private void timerNotification_Tick(object sender, EventArgs e)
        {
            labelNotification.Text = "успешно";
            tic++;
            if (tic == 10)
            {
                labelNotification.Text = "";
                timerNotification.Stop();
                timerNotification.Enabled = false;
            }
        }
    }
}
