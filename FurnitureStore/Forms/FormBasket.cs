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
using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using IronXL;
using IronXL.Styles;


namespace FurnitureStore
{
    public partial class FormBasket : Form
    {
        private LoginForm loginForm;

        public FormBasket(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            PrintBasket(this.loginForm.ActiveUser);

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

        private Panel GetProductPanel(Button btn)
        {
            foreach (var item in panelBasket.Controls)
            {
                Panel pan = (Panel)item;
                foreach (var c in pan.Controls)
                {
                    if (c.GetType() == typeof(Button))
                    {
                        if (c == btn)
                            return pan;
                    }
                    else if (c.GetType() == typeof(Panel))
                    {
                        Panel countP = (Panel)c;
                        foreach (var b in countP.Controls)
                        {
                            if (b.GetType() == typeof(Button))
                            {
                                if (b == btn)
                                    return pan;
                            }
                        }
                    }
                }
            }
            return null;
        }

        private Panel GetCountPanel(Button btn)
        {
            foreach (var item in panelBasket.Controls)
            {
                Panel pan = (Panel)item;
                foreach (var c in pan.Controls)
                {
                    if (c.GetType() == typeof(Panel))
                    {
                        Panel countP = (Panel)c;
                        foreach (var b in countP.Controls)
                        {
                            if (b.GetType() == typeof(Button))
                            {
                                if (b == btn)
                                    return countP;
                            }
                        }
                    }
                }
            }
            return null;
        }

        private void btnPlaceAnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                IronXL.License.LicenseKey = "IRONXL.BATONBATONOV.32684-F732F7CC3E-UKJ4DKNM5OZGHPOH-QU5L3X266OWX-EALXFGLC4ZA6-LRPUAQCOGAAO-YKFKPEDMNHIG-X6E6EW-TEOOZ2HIPDOKEA-DEPLOYMENT.TRIAL-A2W3TR.TRIAL.EXPIRES.10.JUL.2023";
                WorkBook xlsWorkbook = WorkBook.Create(ExcelFileFormat.XLS);
                xlsWorkbook.Metadata.Author = "IronXL";
                WorkSheet xlsSheet = xlsWorkbook.CreateWorkSheet("new_sheet");
                xlsSheet.Style.ShrinkToFit = true;
                xlsSheet[$"A1"].Value = $"№";
                xlsSheet[$"B1"].Value = $"Название товара";
                xlsSheet[$"C1"].Value = $"Кол-во";
                xlsSheet[$"D1"].Value = $"Сумма";
                xlsSheet[$"A1:D1"].Style.Font.Bold = true;
                xlsSheet[$"A1:D1"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                xlsSheet[$"A1:D1"].Style.TopBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet[$"A1:D1"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet[$"A1:D1"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet[$"A1:D1"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                for (int i = 0; i < loginForm.ActiveUser.basketList.Count; i++)
                {
                    Product product = loginForm.databaseManagement.productsRepository.GetProduct(loginForm.ActiveUser.basketList[i].ProductId);
                    xlsSheet[$"A{i + 2}"].Value = i + 1;
                    xlsSheet[$"B{i + 2}"].Value = $"{product.TypeFurniture} {product.ProductName}";
                    xlsSheet[$"C{i + 2}"].Value = loginForm.ActiveUser.basketList[i].Count;
                    xlsSheet[$"D{i + 2}"].Value = product.Price * loginForm.ActiveUser.basketList[i].Count;
                    xlsSheet[$"A{i + 2}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                    xlsSheet[$"C{i + 2}:D{i + 2}"].Style.HorizontalAlignment = IronXL.Styles.HorizontalAlignment.Center;
                    xlsSheet[$"A{i + 2}:D{i + 2}"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;
                    xlsSheet[$"A{i + 2}:D{i + 2}"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                    xlsSheet[$"A{i + 2}:D{i + 2}"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                }
                
                int last = loginForm.ActiveUser.basketList.Count;
                xlsSheet[$"C{last + 2}"].Value = $"Итого::";
                xlsSheet[$"D{last + 2}"].Value = $"{SumBasket()} руб";
                xlsSheet[$"C{last + 2}:D{last + 2}"].Style.Font.Bold = true;
                xlsSheet[$"C{last + 2}:D{last + 2}"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet[$"D{last + 2}"].Style.RightBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet[$"C{last + 2}"].Style.LeftBorder.Type = IronXL.Styles.BorderType.Thin;
                xlsSheet.AutoSizeColumn(0, true);
                xlsSheet.AutoSizeColumn(1, true);
                xlsSheet.AutoSizeColumn(2, true);
                xlsSheet.AutoSizeColumn(3, true);
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "xls files (*.xls)|*.xls";
                sf.ShowDialog();
                var path = sf.FileName;
                xlsWorkbook.SaveAs(path); //Save the excel file
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Panel pan = GetProductPanel((Button)sender);
            for (int i = 0; i < loginForm.ActiveUser.basketList.Count; i++)
            {
                if (loginForm.ActiveUser.basketList[i].ProductId == GetIdProduct(pan))
                    loginForm.ActiveUser.basketList.Remove(loginForm.ActiveUser.basketList[i]);
            }
            panelBasket.Controls.Remove(pan);
            labelSumPriceProduct.Text = $"{SumBasket()} руб";
            loginForm.databaseManagement.UpdateTables("basket");
        }

        private void buttonOperation_Click(object sender, int operand)
        {
            Panel pan = GetProductPanel((Button)sender);
            Panel panCount = GetCountPanel((Button)sender);
            int Count = 0;
            for (int i = 0; i < loginForm.ActiveUser.basketList.Count; i++)
            {
                if (loginForm.ActiveUser.basketList[i].ProductId == GetIdProduct(pan))
                {
                    if (loginForm.ActiveUser.basketList[i].Count + operand >= 1)
                    {
                        loginForm.ActiveUser.basketList[i].Count += operand;
                        loginForm.databaseManagement.UpdateTables("basket");
                    }
                    Count = loginForm.ActiveUser.basketList[i].Count;
                    break;
                }
            }

            foreach (var item in pan.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    Label lbl = (Label)item;
                    int i;
                    if (int.TryParse(lbl.Text[0].ToString(), out i))
                    {
                        decimal productPrice = loginForm.databaseManagement.productsRepository.GetProduct(GetIdProduct(pan)).Price;
                        lbl.Text = $"{Count * productPrice} руб";
                    }
                }
            }

            foreach (var item in panCount.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    Label lbl = (Label)item;
                    lbl.Text = Count.ToString();
                }
            }
            labelSumPriceProduct.Text = $"{SumBasket()} руб";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            buttonOperation_Click(sender, -1);
        }

        private void buttonPluse_Click(object sender, EventArgs e)
        {
            buttonOperation_Click(sender, 1);
        }

        private decimal SumBasket()
        {
            decimal sum = 0;

            for (int i = 0; i < loginForm.ActiveUser.basketList.Count; i++)
            {
                decimal productPrice = loginForm.databaseManagement.productsRepository.GetProduct(loginForm.ActiveUser.basketList[i].ProductId).Price;
                sum += productPrice * loginForm.ActiveUser.basketList[i].Count;
            }
            return sum;
        }

        public void PrintBasket(User activeUser)
        {
            for (int i = 0; i < activeUser.basketList.Count; i++)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBasket));//
                Panel panelProduct = new Panel();
                Button buttonDelete = new Button();
                Label labelPriceProduct = new Label();
                Panel panelCount = new Panel();
                Label labelCount = new Label();
                Button buttonPluse = new Button();
                Button buttonMinus = new Button();
                Label labelNameProduct = new Label();
                PictureBox pictureBoxProduct = new PictureBox();
                panelProduct.SuspendLayout();//
                panelCount.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
                // buttonDelete//
                buttonDelete.Cursor = Cursors.Hand;
                buttonDelete.FlatAppearance.BorderSize = 0;
                buttonDelete.FlatStyle = FlatStyle.Flat;
                buttonDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                buttonDelete.ForeColor = Color.FromArgb(224, 224, 224);
                buttonDelete.Image = Properties.Resources.delete;
                buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
                buttonDelete.Location = new Point(167, 83);
                buttonDelete.Name = "buttonDelete";
                buttonDelete.Size = new Size(84, 28);
                buttonDelete.TabIndex = 4;
                buttonDelete.Text = "Удалить";
                buttonDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
                buttonDelete.UseVisualStyleBackColor = true;
                buttonDelete.Click += buttonDelete_Click;
                // 
                // labelPriceProduct//
                // 
                labelPriceProduct.Anchor = AnchorStyles.Right;
                labelPriceProduct.AutoSize = true;
                labelPriceProduct.Font = new Font("Unispace", 13.7499981F, FontStyle.Bold, GraphicsUnit.Point);
                labelPriceProduct.ForeColor = Color.FromArgb(224, 224, 224);
                labelPriceProduct.Location = new Point(429, 14);
                labelPriceProduct.Name = "labelPriceProduct";
                labelPriceProduct.Size = new Size(97, 23);
                labelPriceProduct.TabIndex = 3;
                decimal productPrice = loginForm.databaseManagement.productsRepository.GetProduct(activeUser.basketList[i].ProductId).Price;
                labelPriceProduct.Text = $"{activeUser.basketList[i].Count * productPrice} руб";
                // 
                // panelCount
                // 
                panelCount.Anchor = AnchorStyles.Right;
                panelCount.BackColor = Color.FromArgb(104, 104, 104);
                panelCount.Controls.Add(labelCount);
                panelCount.Controls.Add(buttonPluse);
                panelCount.Controls.Add(buttonMinus);
                panelCount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
                panelCount.Location = new Point(429, 83);
                panelCount.Name = "panelCount";
                panelCount.Size = new Size(83, 28);
                panelCount.TabIndex = 2;
                // 
                // labelCount
                // 
                labelCount.AutoSize = true;
                labelCount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
                labelCount.ForeColor = Color.FromArgb(224, 224, 224);
                labelCount.Location = new Point(34, 5);
                labelCount.Name = "labelCount";
                labelCount.Size = new Size(17, 19);
                labelCount.TabIndex = 2;
                labelCount.Text = $"{activeUser.basketList[i].Count}";
                // 
                // buttonPluse
                // 
                buttonPluse.Cursor = Cursors.Hand;
                buttonPluse.Dock = DockStyle.Right;
                buttonPluse.FlatAppearance.BorderSize = 0;
                buttonPluse.FlatStyle = FlatStyle.Flat;
                buttonPluse.ForeColor = Color.FromArgb(224, 224, 224);
                buttonPluse.Image = Properties.Resources.pluse;
                buttonPluse.Location = new Point(55, 0);
                buttonPluse.Name = "buttonPluse";
                buttonPluse.Size = new Size(28, 28);
                buttonPluse.TabIndex = 1;
                buttonPluse.UseVisualStyleBackColor = true;
                buttonPluse.Click += buttonPluse_Click;
                // 
                // buttonMinus
                // 
                buttonMinus.Cursor = Cursors.Hand;
                buttonMinus.Dock = DockStyle.Left;
                buttonMinus.FlatAppearance.BorderSize = 0;
                buttonMinus.FlatStyle = FlatStyle.Flat;
                buttonMinus.ForeColor = Color.FromArgb(224, 224, 224);
                buttonMinus.Image = Properties.Resources.minus;
                buttonMinus.Location = new Point(0, 0);
                buttonMinus.Name = "buttonMinus";
                buttonMinus.Size = new Size(28, 28);
                buttonMinus.TabIndex = 0;
                buttonMinus.UseVisualStyleBackColor = true;
                buttonMinus.Click += buttonMinus_Click;
                // 
                // labelNameProduct
                // 
                labelNameProduct.AutoSize = true;
                labelNameProduct.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
                labelNameProduct.ForeColor = Color.FromArgb(224, 224, 224);
                labelNameProduct.Location = new Point(167, 12);
                labelNameProduct.Name = "labelNameProduct";
                labelNameProduct.Size = new Size(125, 25);
                labelNameProduct.TabIndex = 1;
                string productName = loginForm.databaseManagement.productsRepository.GetProduct(activeUser.basketList[i].ProductId).ProductName;
                string productType = loginForm.databaseManagement.productsRepository.GetProduct(activeUser.basketList[i].ProductId).TypeFurniture;
                labelNameProduct.Text = $"{productType} {productName}";
                // 
                // pictureBoxProduct//
                // 
                pictureBoxProduct.BackColor = Color.White;
                Bitmap image = (Bitmap)((new ImageConverter()).ConvertFrom(loginForm.databaseManagement.productsRepository.GetProduct(activeUser.basketList[i].ProductId).Image));
                pictureBoxProduct.Image = image;
                pictureBoxProduct.Location = new Point(12, 12);
                pictureBoxProduct.Name = "pictureBoxProduct";
                pictureBoxProduct.Size = new Size(133, 99);
                pictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxProduct.TabIndex = 0;
                pictureBoxProduct.TabStop = false;
                // 
                // panelProduct//
                // 
                panelProduct.BackColor = Color.FromArgb(74, 74, 74);
                panelProduct.Controls.Add(buttonDelete);
                panelProduct.Controls.Add(labelPriceProduct);
                panelProduct.Controls.Add(panelCount);
                panelProduct.Controls.Add(labelNameProduct);
                panelProduct.Controls.Add(pictureBoxProduct);
                panelProduct.Dock = DockStyle.Top;
                panelProduct.Location = new Point(0, 0);
                panelProduct.Name = $"panelProduct{activeUser.basketList[i].ProductId}";
                panelProduct.Size = new Size(570, 131);
                panelProduct.TabIndex = 1;
                panelProduct.ResumeLayout(false);
                panelProduct.PerformLayout();
                panelCount.ResumeLayout(false);
                panelCount.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
                panelBasket.Controls.Add(panelProduct);
                labelSumPriceProduct.Text = $"{SumBasket()} руб"; 
            }
        }
    }
}
