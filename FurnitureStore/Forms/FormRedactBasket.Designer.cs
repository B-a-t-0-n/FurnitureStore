using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace FurnitureStore
{
    partial class FormRedactBasket
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
            panelControl = new Panel();
            listBoxUsers = new ListBox();
            buttonSave = new Button();
            listBoxProducts = new ListBox();
            buttonDelete = new Button();
            labelBasket = new Label();
            labelCount = new Label();
            panelCount = new Panel();
            panelInfoCount = new Panel();
            labelInfoCount = new Label();
            buttonPluse = new Button();
            buttonMinus = new Button();
            panelControl.SuspendLayout();
            panelCount.SuspendLayout();
            panelInfoCount.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl
            // 
            panelControl.Controls.Add(listBoxUsers);
            panelControl.Controls.Add(buttonSave);
            panelControl.Dock = DockStyle.Right;
            panelControl.Location = new Point(586, 0);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(214, 417);
            panelControl.TabIndex = 0;
            // 
            // listBoxUsers
            // 
            listBoxUsers.BackColor = Color.FromArgb(74, 74, 74);
            listBoxUsers.BorderStyle = BorderStyle.None;
            listBoxUsers.Cursor = Cursors.Hand;
            listBoxUsers.Dock = DockStyle.Top;
            listBoxUsers.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxUsers.ForeColor = Color.FromArgb(224, 224, 224);
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 23;
            listBoxUsers.Location = new Point(0, 0);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(214, 207);
            listBoxUsers.TabIndex = 1;
            listBoxUsers.DrawItem += listBoxUsers_DrawItem;
            listBoxUsers.SelectedIndexChanged += listBoxUsers_SelectedIndexChanged;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.SlateBlue;
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Dock = DockStyle.Bottom;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.FromArgb(224, 224, 224);
            buttonSave.Location = new Point(0, 370);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(214, 47);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "сохранить изменения";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // listBoxProducts
            // 
            listBoxProducts.BackColor = Color.FromArgb(74, 74, 74);
            listBoxProducts.BorderStyle = BorderStyle.None;
            listBoxProducts.Cursor = Cursors.Hand;
            listBoxProducts.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxProducts.ForeColor = Color.FromArgb(224, 224, 224);
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 23;
            listBoxProducts.Location = new Point(12, 52);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(214, 207);
            listBoxProducts.TabIndex = 2;
            listBoxProducts.DrawItem += listBoxUsers_DrawItem;
            listBoxProducts.SelectedIndexChanged += listBoxProducts_SelectedIndexChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.SlateBlue;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.FromArgb(224, 224, 224);
            buttonDelete.Location = new Point(232, 225);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(92, 34);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelBasket
            // 
            labelBasket.AutoSize = true;
            labelBasket.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelBasket.ForeColor = Color.FromArgb(224, 224, 224);
            labelBasket.Location = new Point(12, 9);
            labelBasket.Name = "labelBasket";
            labelBasket.Size = new Size(99, 30);
            labelBasket.TabIndex = 4;
            labelBasket.Text = "Корзина";
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelCount.ForeColor = Color.FromArgb(224, 224, 224);
            labelCount.Location = new Point(232, 52);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(128, 25);
            labelCount.TabIndex = 5;
            labelCount.Text = "Колличество";
            // 
            // panelCount
            // 
            panelCount.Controls.Add(panelInfoCount);
            panelCount.Controls.Add(buttonPluse);
            panelCount.Controls.Add(buttonMinus);
            panelCount.Location = new Point(232, 80);
            panelCount.Name = "panelCount";
            panelCount.Size = new Size(92, 28);
            panelCount.TabIndex = 6;
            // 
            // panelInfoCount
            // 
            panelInfoCount.BackColor = Color.Gray;
            panelInfoCount.Controls.Add(labelInfoCount);
            panelInfoCount.Dock = DockStyle.Fill;
            panelInfoCount.Location = new Point(29, 0);
            panelInfoCount.Name = "panelInfoCount";
            panelInfoCount.Size = new Size(34, 28);
            panelInfoCount.TabIndex = 2;
            // 
            // labelInfoCount
            // 
            labelInfoCount.AutoSize = true;
            labelInfoCount.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelInfoCount.ForeColor = Color.FromArgb(224, 224, 224);
            labelInfoCount.Location = new Point(6, 0);
            labelInfoCount.Name = "labelInfoCount";
            labelInfoCount.Size = new Size(22, 25);
            labelInfoCount.TabIndex = 0;
            labelInfoCount.Text = "0";
            // 
            // buttonPluse
            // 
            buttonPluse.BackColor = Color.Gray;
            buttonPluse.Cursor = Cursors.Hand;
            buttonPluse.Dock = DockStyle.Right;
            buttonPluse.FlatAppearance.BorderSize = 0;
            buttonPluse.FlatStyle = FlatStyle.Flat;
            buttonPluse.ForeColor = Color.FromArgb(224, 224, 224);
            buttonPluse.Image = Properties.Resources.pluse;
            buttonPluse.Location = new Point(63, 0);
            buttonPluse.Name = "buttonPluse";
            buttonPluse.Size = new Size(29, 28);
            buttonPluse.TabIndex = 1;
            buttonPluse.UseVisualStyleBackColor = false;
            buttonPluse.Click += buttonPluse_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.Gray;
            buttonMinus.Cursor = Cursors.Hand;
            buttonMinus.Dock = DockStyle.Left;
            buttonMinus.FlatAppearance.BorderSize = 0;
            buttonMinus.FlatStyle = FlatStyle.Flat;
            buttonMinus.ForeColor = Color.FromArgb(224, 224, 224);
            buttonMinus.Image = Properties.Resources.minus;
            buttonMinus.Location = new Point(0, 0);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(29, 28);
            buttonMinus.TabIndex = 0;
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // FormRedactBasket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 417);
            Controls.Add(panelCount);
            Controls.Add(labelCount);
            Controls.Add(labelBasket);
            Controls.Add(buttonDelete);
            Controls.Add(listBoxProducts);
            Controls.Add(panelControl);
            Name = "FormRedactBasket";
            Text = "FormRedactBascet";
            panelControl.ResumeLayout(false);
            panelCount.ResumeLayout(false);
            panelInfoCount.ResumeLayout(false);
            panelInfoCount.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelControl;
        private Button buttonSave;
        private ListBox listBoxUsers;
        private ListBox listBoxProducts;
        private Button buttonDelete;
        private Label labelBasket;
        private Label labelCount;
        private Panel panelCount;
        private Button buttonPluse;
        private Button buttonMinus;
        private Panel panelInfoCount;
        private Label labelInfoCount;
    }
}