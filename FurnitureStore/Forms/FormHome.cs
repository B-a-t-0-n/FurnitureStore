using FurnitureStore.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace FurnitureStore
{
    public partial class FormHome : Form
    {
        LoginForm loginForm;

        public FormHome(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.loginForm.databaseManagement.ConectTable("products", ref this.loginForm.databaseManagement.activeProduct);
            textBoxSearch.Text = "Поиск";
            foreach (var product in loginForm.databaseManagement.productsRepository.GetAll())
            {
                AddProductPanel(product);
                bool noCopy = true;

                foreach (var item in panelType.Controls)
                {
                    if (item.GetType() == typeof(CheckBox))
                    {
                        CheckBox chk = (CheckBox)item;
                        if (chk.Text == product.TypeFurniture)
                            noCopy = false;
                    }
                }

                if (noCopy)
                {
                    CheckBox checkBoxType = new CheckBox();
                    panelType.Controls.Add(checkBoxType);
                    checkBoxType.AutoSize = true;
                    checkBoxType.Dock = DockStyle.Top;
                    checkBoxType.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
                    checkBoxType.Location = new Point(0, 0);
                    checkBoxType.Name = "checkBoxType";
                    checkBoxType.Size = new Size(199, 29);
                    checkBoxType.TabIndex = 0;
                    checkBoxType.Text = product.TypeFurniture;
                    checkBoxType.UseVisualStyleBackColor = true;
                    checkBoxType.Checked = true;
                }
            }
        }

        private int GetIdProduct(Panel pan)
        {
            string idProduct = "";

            foreach (var a in pan.Name)
            {
                int id = 0;
                if (int.TryParse(a.ToString(), out id))
                    idProduct += a;
            }

            if (idProduct != "")
                return int.Parse(idProduct);
            else
                return 0;
        }

        private void buttonInBasket_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Panel panel = button.Parent as Panel;

            if (loginForm.ActiveUser.CheckAddBasket(GetIdProduct(panel)))
            {
                button.Image = Properties.Resources.chekProduct;
                loginForm.ActiveUser.AddBasket(GetIdProduct(panel));
            }
            else
            {
                button.Image = Properties.Resources.addBasket;
                loginForm.ActiveUser.RemoveBasket(GetIdProduct(panel));
            }
            loginForm.databaseManagement.UpdateTables("basket");
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Поиск")
                textBoxSearch.Text = "";
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
                textBoxSearch.Text = "Поиск";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.ToLower();
            if (search != "поиск")
            {
                flowLayoutPanelProducts.Controls.Clear();
                SearchProduct(search);
            }
        }

        private void SearchProduct(string search)
        {
            foreach (var item in loginForm.databaseManagement.productsRepository.GetAll())
            {

                if ($"{item.TypeFurniture} {item.ProductName}".ToLower().Contains(search) || $"{item.ProductName} {item.TypeFurniture}".ToLower().Contains(search))
                {
                    bool noCopy = true;
                    foreach (var product in GetArrayProducts(flowLayoutPanelProducts))
                    {
                        if (product.ProductId == item.ProductId)
                            noCopy = false;


                    }
                    if (noCopy)
                        AddProductPanel(item);
                }
            }
        }

        private Product[] GetArrayProducts(FlowLayoutPanel flowLayoutPanel)
        {
            List<Product> products = new List<Product>();
            foreach (var item in flowLayoutPanelProducts.Controls)
            {
                if (item.GetType() == typeof(Panel))
                {
                    foreach (var product in loginForm.databaseManagement.productsRepository.GetAll())
                    {
                        if (product.ProductId == GetIdProduct((Panel)item))
                            products.Add(product);

                    }

                }
            }
            return products.ToArray();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            decimal minPrice = 0;
            decimal maxPrice = decimal.MaxValue;
            List<string> types = new List<string>();
            if (textBoxPriceStart.Text != "")
                decimal.TryParse(textBoxPriceStart.Text, out minPrice);
            if (textBoxPriceStop.Text != "")
                decimal.TryParse(textBoxPriceStop.Text, out maxPrice);

            if (minPrice > maxPrice)
            {
                minPrice = 0;
                textBoxPriceStart.Text = "";
            }

            foreach (var item in panelType.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    CheckBox checkBox = (CheckBox)item;
                    if (checkBox.Checked)
                        types.Add(checkBox.Text);

                }
            }
            SortProductPanel(minPrice, maxPrice, types.ToArray());
        }


        private void SortProductPanel(decimal minPrice, decimal maxPrice, string[] types)
        {
            foreach (var item in flowLayoutPanelProducts.Controls)
            {
                if (item.GetType() == typeof(Panel))
                {
                    Panel panel = (Panel)item;
                    panel.Visible = false;
                    panel.Enabled = false;
                }
            }

            foreach (var item in flowLayoutPanelProducts.Controls)
            {
                if (item.GetType() == typeof(Panel))
                {
                    foreach (var product in loginForm.databaseManagement.productsRepository.GetAll())
                    {
                        if (product.ProductId == GetIdProduct((Panel)item))
                        {
                            foreach (var type in types)
                            {
                                if (product.TypeFurniture.ToLower() == type.ToLower() && product.Price >= minPrice && product.Price <= maxPrice)
                                {
                                    Panel panel = (Panel)item;
                                    panel.Visible = true;
                                    panel.Enabled = true;
                                }
                            }
                        }

                    }
                }
            }
        }

        private void AddProductPanel(Product product)
        {
            Panel panelProduct = new Panel();
            Button buttonInBasket = new Button();
            Panel panelPrice = new Panel();
            Label labelPrice = new Label();
            Panel panelProductName = new Panel();
            Label labelProduct = new Label();
            PictureBox pictureBoxProductImage = new PictureBox();
            panelProduct.SuspendLayout();
            panelPrice.SuspendLayout();
            panelProductName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).BeginInit();
            flowLayoutPanelProducts.Controls.Add(panelProduct);
            // 
            // panelProduct
            // 
            panelProduct.BackColor = Color.DimGray;
            panelProduct.Controls.Add(buttonInBasket);
            panelProduct.Controls.Add(panelPrice);
            panelProduct.Controls.Add(panelProductName);
            panelProduct.Controls.Add(pictureBoxProductImage);
            panelProduct.Location = new Point(7, 3);
            panelProduct.Margin = new Padding(2, 3, 3, 3);
            panelProduct.Name = $"panelProduct{product.ProductId}";
            panelProduct.Size = new Size(260, 248);
            panelProduct.TabIndex = 5;

            // 
            // buttonInBasket
            // 
            buttonInBasket.BackColor = Color.SlateBlue;
            buttonInBasket.Cursor = Cursors.Hand;
            buttonInBasket.Dock = DockStyle.Fill;
            buttonInBasket.FlatAppearance.BorderSize = 0;
            buttonInBasket.FlatStyle = FlatStyle.Flat;
            if (loginForm.ActiveUser.CheckAddBasket(product.ProductId))
                buttonInBasket.Image = Properties.Resources.addBasket;
            else
                buttonInBasket.Image = Properties.Resources.chekProduct;

            buttonInBasket.Location = new Point(203, 206);
            buttonInBasket.Name = "buttonInBasket";
            buttonInBasket.Size = new Size(57, 42);
            buttonInBasket.TabIndex = 3;
            buttonInBasket.UseVisualStyleBackColor = false;
            buttonInBasket.Click += buttonInBasket_Click;
            // 
            // panelPrice
            // 
            panelPrice.Controls.Add(labelPrice);
            panelPrice.Dock = DockStyle.Left;
            panelPrice.Location = new Point(0, 206);
            panelPrice.Name = "panelPrice";
            panelPrice.Size = new Size(203, 42);
            panelPrice.TabIndex = 2;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrice.ForeColor = Color.Transparent;
            labelPrice.Location = new Point(9, 8);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(128, 25);
            labelPrice.TabIndex = 0;
            labelPrice.Text = $"{product.Price} руб";
            // 
            // panelProductName
            // 
            panelProductName.Controls.Add(labelProduct);
            panelProductName.Dock = DockStyle.Top;
            panelProductName.Location = new Point(0, 163);
            panelProductName.Name = "panelProductName";
            panelProductName.Size = new Size(260, 43);
            panelProductName.TabIndex = 1;
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelProduct.ForeColor = Color.White;
            labelProduct.Location = new Point(3, 3);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(148, 30);
            labelProduct.TabIndex = 0;
            labelProduct.Text = $"{product.TypeFurniture} {product.ProductName}";
            // 
            // pictureBoxProductImage
            // 
            pictureBoxProductImage.Dock = DockStyle.Top;
            pictureBoxProductImage.Image = (Bitmap)((new ImageConverter()).ConvertFrom(product.Image));
            pictureBoxProductImage.Location = new Point(0, 0);
            pictureBoxProductImage.Name = "pictureBoxProductImage";
            pictureBoxProductImage.Size = new Size(260, 163);
            pictureBoxProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProductImage.TabIndex = 0;
            pictureBoxProductImage.TabStop = false;
            pictureBoxProductImage.BackColor = Color.White;
            //
            //
            //
            panelProduct.ResumeLayout(false);
            panelPrice.ResumeLayout(false);
            panelPrice.PerformLayout();
            panelProductName.ResumeLayout(false);
            panelProductName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).EndInit();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxPriceStart.Text = "";
            textBoxPriceStop.Text = "";
            foreach (var checkBox in panelType.Controls)
            {
                if (checkBox.GetType() == typeof(CheckBox))
                {
                    CheckBox box = (CheckBox)checkBox;
                    box.Checked = true;
                }
            }

            flowLayoutPanelProducts.Controls.Clear();

            foreach (var product in loginForm.databaseManagement.productsRepository.GetAll())
            {
                AddProductPanel(product);
            }
        }
    }
}
