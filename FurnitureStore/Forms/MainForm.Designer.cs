using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace FurnitureStore
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            btnRedactBssket = new Button();
            btnRedactUser = new Button();
            panelExit = new Panel();
            buttonExit = new Button();
            btnRedactProduct = new Button();
            buttonBasket = new Button();
            buttonHome = new Button();
            panelLogo = new Panel();
            panelHome = new Panel();
            labelNameForm = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelExit.SuspendLayout();
            panelHome.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelMenu.Controls.Add(btnRedactBssket);
            panelMenu.Controls.Add(btnRedactUser);
            panelMenu.Controls.Add(panelExit);
            panelMenu.Controls.Add(btnRedactProduct);
            panelMenu.Controls.Add(buttonBasket);
            panelMenu.Controls.Add(buttonHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(168, 651);
            panelMenu.TabIndex = 0;
            // 
            // btnRedactBssket
            // 
            btnRedactBssket.Cursor = Cursors.Hand;
            btnRedactBssket.Dock = DockStyle.Top;
            btnRedactBssket.FlatAppearance.BorderSize = 0;
            btnRedactBssket.FlatStyle = FlatStyle.Flat;
            btnRedactBssket.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRedactBssket.ForeColor = SystemColors.ControlLight;
            btnRedactBssket.Image = Properties.Resources.admin;
            btnRedactBssket.ImageAlign = ContentAlignment.MiddleLeft;
            btnRedactBssket.Location = new Point(0, 282);
            btnRedactBssket.Name = "btnRedactBssket";
            btnRedactBssket.Size = new Size(168, 53);
            btnRedactBssket.TabIndex = 7;
            btnRedactBssket.Text = "basket";
            btnRedactBssket.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRedactBssket.UseVisualStyleBackColor = true;
            btnRedactBssket.Click += btnRedactBsscet_Click;
            // 
            // btnRedactUser
            // 
            btnRedactUser.Cursor = Cursors.Hand;
            btnRedactUser.Dock = DockStyle.Top;
            btnRedactUser.FlatAppearance.BorderSize = 0;
            btnRedactUser.FlatStyle = FlatStyle.Flat;
            btnRedactUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRedactUser.ForeColor = SystemColors.ControlLight;
            btnRedactUser.Image = Properties.Resources.admin;
            btnRedactUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnRedactUser.Location = new Point(0, 229);
            btnRedactUser.Name = "btnRedactUser";
            btnRedactUser.Size = new Size(168, 53);
            btnRedactUser.TabIndex = 6;
            btnRedactUser.Text = "User";
            btnRedactUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRedactUser.UseVisualStyleBackColor = true;
            btnRedactUser.Click += btnRedactUser_Click;
            // 
            // panelExit
            // 
            panelExit.Controls.Add(buttonExit);
            panelExit.Dock = DockStyle.Bottom;
            panelExit.Location = new Point(0, 601);
            panelExit.Name = "panelExit";
            panelExit.Size = new Size(168, 50);
            panelExit.TabIndex = 5;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(54, 54, 54);
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.Dock = DockStyle.Bottom;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.ForeColor = SystemColors.ControlLight;
            buttonExit.Image = Properties.Resources.exitMenu;
            buttonExit.Location = new Point(0, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(168, 48);
            buttonExit.TabIndex = 4;
            buttonExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // btnRedactProduct
            // 
            btnRedactProduct.Cursor = Cursors.Hand;
            btnRedactProduct.Dock = DockStyle.Top;
            btnRedactProduct.FlatAppearance.BorderSize = 0;
            btnRedactProduct.FlatStyle = FlatStyle.Flat;
            btnRedactProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRedactProduct.ForeColor = SystemColors.ControlLight;
            btnRedactProduct.Image = Properties.Resources.admin;
            btnRedactProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnRedactProduct.Location = new Point(0, 176);
            btnRedactProduct.Name = "btnRedactProduct";
            btnRedactProduct.Size = new Size(168, 53);
            btnRedactProduct.TabIndex = 3;
            btnRedactProduct.Text = "Product";
            btnRedactProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRedactProduct.UseVisualStyleBackColor = true;
            btnRedactProduct.Click += btnRedactProduct_Click;
            // 
            // buttonBasket
            // 
            buttonBasket.Cursor = Cursors.Hand;
            buttonBasket.Dock = DockStyle.Top;
            buttonBasket.FlatAppearance.BorderSize = 0;
            buttonBasket.FlatStyle = FlatStyle.Flat;
            buttonBasket.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBasket.ForeColor = SystemColors.ControlLight;
            buttonBasket.Image = Properties.Resources.basket;
            buttonBasket.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBasket.Location = new Point(0, 123);
            buttonBasket.Name = "buttonBasket";
            buttonBasket.Size = new Size(168, 53);
            buttonBasket.TabIndex = 2;
            buttonBasket.Text = "Корзина";
            buttonBasket.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBasket.UseVisualStyleBackColor = true;
            buttonBasket.Click += buttonBasket_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.SlateBlue;
            buttonHome.Cursor = Cursors.Hand;
            buttonHome.Dock = DockStyle.Top;
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHome.ForeColor = SystemColors.ControlLight;
            buttonHome.Image = Properties.Resources.home;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(0, 70);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(168, 53);
            buttonHome.TabIndex = 1;
            buttonHome.Text = "Главная";
            buttonHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.DarkSlateBlue;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(168, 70);
            panelLogo.TabIndex = 0;
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.SlateBlue;
            panelHome.Controls.Add(labelNameForm);
            panelHome.Dock = DockStyle.Top;
            panelHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panelHome.Location = new Point(168, 0);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1099, 70);
            panelHome.TabIndex = 1;
            // 
            // labelNameForm
            // 
            labelNameForm.Anchor = AnchorStyles.Top;
            labelNameForm.AutoSize = true;
            labelNameForm.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNameForm.ForeColor = Color.FromArgb(224, 224, 224);
            labelNameForm.Location = new Point(481, 9);
            labelNameForm.Name = "labelNameForm";
            labelNameForm.Size = new Size(124, 37);
            labelNameForm.TabIndex = 0;
            labelNameForm.Text = "Главная";
            // 
            // panelDesktop
            // 
            panelDesktop.AutoScroll = true;
            panelDesktop.BackColor = SystemColors.ScrollBar;
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(168, 70);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1099, 581);
            panelDesktop.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1267, 651);
            Controls.Add(panelDesktop);
            Controls.Add(panelHome);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1283, 690);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            Load += buttonExit_Click;
            panelMenu.ResumeLayout(false);
            panelExit.ResumeLayout(false);
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button buttonHome;
        private Panel panelLogo;
        private Panel panelHome;
        private Label labelNameForm;
        private Button buttonExit;
        private Button btnRedactProduct;
        private Button buttonBasket;
        private Panel panelDesktop;
        private Panel panelExit;
        private Button btnRedactBssket;
        private Button btnRedactUser;
    }
}