using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace FurnitureStore
{
    partial class FormRedactProduct
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
            components = new System.ComponentModel.Container();
            panelNewProduct = new Panel();
            buttonSaveNewProduct = new Button();
            textBoxPriceNewProduct = new TextBox();
            labelPriceNewProduct = new Label();
            textBoxTypeNewProduct = new TextBox();
            labelTypeNewProduct = new Label();
            textBoxNameNewProduct = new TextBox();
            labelNameNewProduct = new Label();
            buttonAddImageNewProduct = new Button();
            pictureBoxNewProduct = new PictureBox();
            panelVoid = new Panel();
            panelInfo = new Panel();
            panelProduct = new Panel();
            buttonDelete = new Button();
            panel1 = new Panel();
            listBoxProducts = new ListBox();
            buttonSaveChanges = new Button();
            textBoxPriceProduct = new TextBox();
            labelPriceProduct = new Label();
            textBoxTypeProduct = new TextBox();
            labelTypeProduct = new Label();
            textBoxNameProduct = new TextBox();
            labelNameProduct = new Label();
            buttonSavePictureProduct = new Button();
            pictureBoxProduct = new PictureBox();
            timerNotification = new System.Windows.Forms.Timer(components);
            panelNewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNewProduct).BeginInit();
            panelVoid.SuspendLayout();
            panelProduct.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // panelNewProduct
            // 
            panelNewProduct.BorderStyle = BorderStyle.FixedSingle;
            panelNewProduct.Controls.Add(buttonSaveNewProduct);
            panelNewProduct.Controls.Add(textBoxPriceNewProduct);
            panelNewProduct.Controls.Add(labelPriceNewProduct);
            panelNewProduct.Controls.Add(textBoxTypeNewProduct);
            panelNewProduct.Controls.Add(labelTypeNewProduct);
            panelNewProduct.Controls.Add(textBoxNameNewProduct);
            panelNewProduct.Controls.Add(labelNameNewProduct);
            panelNewProduct.Controls.Add(buttonAddImageNewProduct);
            panelNewProduct.Controls.Add(pictureBoxNewProduct);
            panelNewProduct.Controls.Add(panelVoid);
            panelNewProduct.Dock = DockStyle.Top;
            panelNewProduct.Location = new Point(0, 0);
            panelNewProduct.Name = "panelNewProduct";
            panelNewProduct.Size = new Size(929, 245);
            panelNewProduct.TabIndex = 0;
            // 
            // buttonSaveNewProduct
            // 
            buttonSaveNewProduct.BackColor = Color.SlateBlue;
            buttonSaveNewProduct.Cursor = Cursors.Hand;
            buttonSaveNewProduct.FlatAppearance.BorderSize = 0;
            buttonSaveNewProduct.FlatStyle = FlatStyle.Flat;
            buttonSaveNewProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveNewProduct.ForeColor = Color.FromArgb(224, 224, 224);
            buttonSaveNewProduct.Location = new Point(531, 12);
            buttonSaveNewProduct.Name = "buttonSaveNewProduct";
            buttonSaveNewProduct.Size = new Size(120, 34);
            buttonSaveNewProduct.TabIndex = 9;
            buttonSaveNewProduct.Text = "добавить";
            buttonSaveNewProduct.UseVisualStyleBackColor = false;
            buttonSaveNewProduct.Click += buttonSaveNewProduct_Click;
            // 
            // textBoxPriceNewProduct
            // 
            textBoxPriceNewProduct.BackColor = Color.DimGray;
            textBoxPriceNewProduct.BorderStyle = BorderStyle.None;
            textBoxPriceNewProduct.Cursor = Cursors.IBeam;
            textBoxPriceNewProduct.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPriceNewProduct.ForeColor = Color.White;
            textBoxPriceNewProduct.Location = new Point(194, 150);
            textBoxPriceNewProduct.Name = "textBoxPriceNewProduct";
            textBoxPriceNewProduct.Size = new Size(238, 24);
            textBoxPriceNewProduct.TabIndex = 8;
            // 
            // labelPriceNewProduct
            // 
            labelPriceNewProduct.AutoSize = true;
            labelPriceNewProduct.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelPriceNewProduct.ForeColor = Color.FromArgb(224, 224, 224);
            labelPriceNewProduct.Location = new Point(194, 122);
            labelPriceNewProduct.Name = "labelPriceNewProduct";
            labelPriceNewProduct.Size = new Size(56, 25);
            labelPriceNewProduct.TabIndex = 7;
            labelPriceNewProduct.Text = "Цена";
            // 
            // textBoxTypeNewProduct
            // 
            textBoxTypeNewProduct.BackColor = Color.DimGray;
            textBoxTypeNewProduct.BorderStyle = BorderStyle.None;
            textBoxTypeNewProduct.Cursor = Cursors.IBeam;
            textBoxTypeNewProduct.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTypeNewProduct.ForeColor = Color.White;
            textBoxTypeNewProduct.Location = new Point(194, 95);
            textBoxTypeNewProduct.Name = "textBoxTypeNewProduct";
            textBoxTypeNewProduct.Size = new Size(238, 24);
            textBoxTypeNewProduct.TabIndex = 6;
            // 
            // labelTypeNewProduct
            // 
            labelTypeNewProduct.AutoSize = true;
            labelTypeNewProduct.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelTypeNewProduct.ForeColor = Color.FromArgb(224, 224, 224);
            labelTypeNewProduct.Location = new Point(194, 67);
            labelTypeNewProduct.Name = "labelTypeNewProduct";
            labelTypeNewProduct.Size = new Size(43, 25);
            labelTypeNewProduct.TabIndex = 5;
            labelTypeNewProduct.Text = "Тип";
            // 
            // textBoxNameNewProduct
            // 
            textBoxNameNewProduct.BackColor = Color.DimGray;
            textBoxNameNewProduct.BorderStyle = BorderStyle.None;
            textBoxNameNewProduct.Cursor = Cursors.IBeam;
            textBoxNameNewProduct.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNameNewProduct.ForeColor = Color.White;
            textBoxNameNewProduct.Location = new Point(194, 40);
            textBoxNameNewProduct.Name = "textBoxNameNewProduct";
            textBoxNameNewProduct.Size = new Size(238, 24);
            textBoxNameNewProduct.TabIndex = 4;
            // 
            // labelNameNewProduct
            // 
            labelNameNewProduct.AutoSize = true;
            labelNameNewProduct.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelNameNewProduct.ForeColor = Color.FromArgb(224, 224, 224);
            labelNameNewProduct.Location = new Point(194, 12);
            labelNameNewProduct.Name = "labelNameNewProduct";
            labelNameNewProduct.Size = new Size(93, 25);
            labelNameNewProduct.TabIndex = 3;
            labelNameNewProduct.Text = "Название";
            // 
            // buttonAddImageNewProduct
            // 
            buttonAddImageNewProduct.BackColor = Color.SlateBlue;
            buttonAddImageNewProduct.Cursor = Cursors.Hand;
            buttonAddImageNewProduct.FlatAppearance.BorderSize = 0;
            buttonAddImageNewProduct.FlatStyle = FlatStyle.Flat;
            buttonAddImageNewProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddImageNewProduct.ForeColor = Color.FromArgb(224, 224, 224);
            buttonAddImageNewProduct.Location = new Point(12, 180);
            buttonAddImageNewProduct.Name = "buttonAddImageNewProduct";
            buttonAddImageNewProduct.Size = new Size(159, 34);
            buttonAddImageNewProduct.TabIndex = 2;
            buttonAddImageNewProduct.Text = "добавить фото";
            buttonAddImageNewProduct.UseVisualStyleBackColor = false;
            buttonAddImageNewProduct.Click += buttonAddImage_Click;
            // 
            // pictureBoxNewProduct
            // 
            pictureBoxNewProduct.BackColor = Color.White;
            pictureBoxNewProduct.Image = Properties.Resources._1;
            pictureBoxNewProduct.Location = new Point(12, 12);
            pictureBoxNewProduct.Name = "pictureBoxNewProduct";
            pictureBoxNewProduct.Size = new Size(159, 162);
            pictureBoxNewProduct.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxNewProduct.TabIndex = 1;
            pictureBoxNewProduct.TabStop = false;
            // 
            // panelVoid
            // 
            panelVoid.BackColor = Color.FromArgb(64, 64, 64);
            panelVoid.Controls.Add(panelInfo);
            panelVoid.Dock = DockStyle.Right;
            panelVoid.Location = new Point(655, 0);
            panelVoid.Name = "panelVoid";
            panelVoid.Size = new Size(272, 243);
            panelVoid.TabIndex = 0;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(84, 84, 84);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(272, 81);
            panelInfo.TabIndex = 0;
            // 
            // panelProduct
            // 
            panelProduct.BorderStyle = BorderStyle.FixedSingle;
            panelProduct.Controls.Add(buttonDelete);
            panelProduct.Controls.Add(panel1);
            panelProduct.Controls.Add(buttonSaveChanges);
            panelProduct.Controls.Add(textBoxPriceProduct);
            panelProduct.Controls.Add(labelPriceProduct);
            panelProduct.Controls.Add(textBoxTypeProduct);
            panelProduct.Controls.Add(labelTypeProduct);
            panelProduct.Controls.Add(textBoxNameProduct);
            panelProduct.Controls.Add(labelNameProduct);
            panelProduct.Controls.Add(buttonSavePictureProduct);
            panelProduct.Controls.Add(pictureBoxProduct);
            panelProduct.Dock = DockStyle.Fill;
            panelProduct.Location = new Point(0, 245);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(929, 258);
            panelProduct.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.SlateBlue;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.FromArgb(224, 224, 224);
            buttonDelete.Location = new Point(557, 192);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 34);
            buttonDelete.TabIndex = 20;
            buttonDelete.Text = "удалить";
            buttonDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 74, 74);
            panel1.Controls.Add(listBoxProducts);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(655, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 256);
            panel1.TabIndex = 19;
            // 
            // listBoxProducts
            // 
            listBoxProducts.BackColor = Color.FromArgb(74, 74, 74);
            listBoxProducts.BorderStyle = BorderStyle.None;
            listBoxProducts.Cursor = Cursors.Hand;
            listBoxProducts.Dock = DockStyle.Fill;
            listBoxProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxProducts.ForeColor = Color.White;
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 21;
            listBoxProducts.Location = new Point(0, 0);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(272, 256);
            listBoxProducts.TabIndex = 0;
            listBoxProducts.DrawItem += listBoxProducts_DrawItem;
            listBoxProducts.SelectedIndexChanged += listBoxProducts_SelectedIndexChanged;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.BackColor = Color.SlateBlue;
            buttonSaveChanges.Cursor = Cursors.Hand;
            buttonSaveChanges.FlatAppearance.BorderSize = 0;
            buttonSaveChanges.FlatStyle = FlatStyle.Flat;
            buttonSaveChanges.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveChanges.ForeColor = Color.FromArgb(224, 224, 224);
            buttonSaveChanges.Location = new Point(463, 24);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(188, 34);
            buttonSaveChanges.TabIndex = 18;
            buttonSaveChanges.Text = "сохранить изменения";
            buttonSaveChanges.UseVisualStyleBackColor = false;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // textBoxPriceProduct
            // 
            textBoxPriceProduct.BackColor = Color.DimGray;
            textBoxPriceProduct.BorderStyle = BorderStyle.None;
            textBoxPriceProduct.Cursor = Cursors.IBeam;
            textBoxPriceProduct.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPriceProduct.ForeColor = Color.White;
            textBoxPriceProduct.Location = new Point(194, 162);
            textBoxPriceProduct.Name = "textBoxPriceProduct";
            textBoxPriceProduct.Size = new Size(238, 24);
            textBoxPriceProduct.TabIndex = 17;
            // 
            // labelPriceProduct
            // 
            labelPriceProduct.AutoSize = true;
            labelPriceProduct.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelPriceProduct.ForeColor = Color.FromArgb(224, 224, 224);
            labelPriceProduct.Location = new Point(194, 134);
            labelPriceProduct.Name = "labelPriceProduct";
            labelPriceProduct.Size = new Size(56, 25);
            labelPriceProduct.TabIndex = 16;
            labelPriceProduct.Text = "Цена";
            // 
            // textBoxTypeProduct
            // 
            textBoxTypeProduct.BackColor = Color.DimGray;
            textBoxTypeProduct.BorderStyle = BorderStyle.None;
            textBoxTypeProduct.Cursor = Cursors.IBeam;
            textBoxTypeProduct.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTypeProduct.ForeColor = Color.White;
            textBoxTypeProduct.Location = new Point(194, 107);
            textBoxTypeProduct.Name = "textBoxTypeProduct";
            textBoxTypeProduct.Size = new Size(238, 24);
            textBoxTypeProduct.TabIndex = 15;
            // 
            // labelTypeProduct
            // 
            labelTypeProduct.AutoSize = true;
            labelTypeProduct.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelTypeProduct.ForeColor = Color.FromArgb(224, 224, 224);
            labelTypeProduct.Location = new Point(194, 79);
            labelTypeProduct.Name = "labelTypeProduct";
            labelTypeProduct.Size = new Size(43, 25);
            labelTypeProduct.TabIndex = 14;
            labelTypeProduct.Text = "Тип";
            // 
            // textBoxNameProduct
            // 
            textBoxNameProduct.BackColor = Color.DimGray;
            textBoxNameProduct.BorderStyle = BorderStyle.None;
            textBoxNameProduct.Cursor = Cursors.IBeam;
            textBoxNameProduct.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNameProduct.ForeColor = Color.White;
            textBoxNameProduct.Location = new Point(194, 52);
            textBoxNameProduct.Name = "textBoxNameProduct";
            textBoxNameProduct.Size = new Size(238, 24);
            textBoxNameProduct.TabIndex = 13;
            // 
            // labelNameProduct
            // 
            labelNameProduct.AutoSize = true;
            labelNameProduct.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelNameProduct.ForeColor = Color.FromArgb(224, 224, 224);
            labelNameProduct.Location = new Point(194, 24);
            labelNameProduct.Name = "labelNameProduct";
            labelNameProduct.Size = new Size(93, 25);
            labelNameProduct.TabIndex = 12;
            labelNameProduct.Text = "Название";
            // 
            // buttonSavePictureProduct
            // 
            buttonSavePictureProduct.BackColor = Color.SlateBlue;
            buttonSavePictureProduct.Cursor = Cursors.Hand;
            buttonSavePictureProduct.FlatAppearance.BorderSize = 0;
            buttonSavePictureProduct.FlatStyle = FlatStyle.Flat;
            buttonSavePictureProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSavePictureProduct.ForeColor = Color.FromArgb(224, 224, 224);
            buttonSavePictureProduct.Location = new Point(12, 192);
            buttonSavePictureProduct.Name = "buttonSavePictureProduct";
            buttonSavePictureProduct.Size = new Size(159, 34);
            buttonSavePictureProduct.TabIndex = 11;
            buttonSavePictureProduct.Text = "изменить фото";
            buttonSavePictureProduct.UseVisualStyleBackColor = false;
            buttonSavePictureProduct.Click += buttonAddImage_Click;
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.BackColor = Color.White;
            pictureBoxProduct.Image = Properties.Resources._1;
            pictureBoxProduct.Location = new Point(12, 24);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(159, 162);
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProduct.TabIndex = 10;
            pictureBoxProduct.TabStop = false;
            // 
            // timerNotification
            // 
            timerNotification.Tick += timerNotification_Tick;
            // 
            // FormRedactProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(929, 503);
            Controls.Add(panelProduct);
            Controls.Add(panelNewProduct);
            Name = "FormRedactProduct";
            Text = "FormRedactProduct";
            panelNewProduct.ResumeLayout(false);
            panelNewProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNewProduct).EndInit();
            panelVoid.ResumeLayout(false);
            panelProduct.ResumeLayout(false);
            panelProduct.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNewProduct;
        private TextBox textBoxNameNewProduct;
        private Label labelNameNewProduct;
        private Button buttonAddImageNewProduct;
        private PictureBox pictureBoxNewProduct;
        private Panel panelVoid;
        private Panel panelInfo;
        private Panel panelProduct;
        private Button buttonSaveNewProduct;
        private TextBox textBoxPriceNewProduct;
        private Label labelPriceNewProduct;
        private TextBox textBoxTypeNewProduct;
        private Label labelTypeNewProduct;
        private Button buttonSaveChanges;
        private TextBox textBoxPriceProduct;
        private Label labelPriceProduct;
        private TextBox textBoxTypeProduct;
        private Label labelTypeProduct;
        private TextBox textBoxNameProduct;
        private Label labelNameProduct;
        private Button buttonSavePictureProduct;
        private PictureBox pictureBoxProduct;
        private Panel panel1;
        private ListBox listBoxProducts;
        private Button buttonDelete;
        private System.Windows.Forms.Timer timerNotification;
    }
}