using System.Drawing;
using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace FurnitureStore
{
    partial class FormBasket
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
            
            panelBasket = new Panel();
            panelVoid = new Panel();
            panelInfo = new Panel();
            labelTotal = new Label();
            labelSumPriceProduct = new Label();
            btnPlaceAnOrder = new Button();
            panelBasket.SuspendLayout();
            panelVoid.SuspendLayout();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelBasket
            // 
            panelBasket.AutoScroll = true;
            panelBasket.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panelBasket.BackgroundImageLayout = ImageLayout.Stretch;
            panelBasket.Controls.Add(panelVoid);
            panelBasket.Dock = DockStyle.Fill;
            panelBasket.Location = new Point(0, 0);
            panelBasket.Name = "panelBasket";
            panelBasket.Size = new Size(963, 530);
            panelBasket.TabIndex = 0;
            // 
            // panelVoid
            // 
            panelVoid.BackColor = Color.FromArgb(64, 64, 64);
            panelVoid.Controls.Add(panelInfo);
            panelVoid.Dock = DockStyle.Top;
            panelVoid.Location = new Point(0, 0);
            panelVoid.Name = "panelVoid";
            panelVoid.Size = new Size(963, 85);
            panelVoid.TabIndex = 0;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(84, 84, 84);
            panelInfo.Controls.Add(labelTotal);
            panelInfo.Controls.Add(labelSumPriceProduct);
            panelInfo.Controls.Add(btnPlaceAnOrder);
            panelInfo.Dock = DockStyle.Right;
            panelInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panelInfo.ForeColor = Color.FromArgb(224, 224, 224);
            panelInfo.Location = new Point(593, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(370, 85);
            panelInfo.TabIndex = 0;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Right;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Unispace", 17.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotal.ForeColor = Color.FromArgb(224, 224, 224);
            labelTotal.Location = new Point(4, 8);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(71, 28);
            labelTotal.TabIndex = 5;
            labelTotal.Text = "Итого";
            // 
            // labelSumPriceProduct
            // 
            labelSumPriceProduct.Anchor = AnchorStyles.Right;
            labelSumPriceProduct.AutoSize = true;
            labelSumPriceProduct.Font = new Font("Unispace", 17.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelSumPriceProduct.ForeColor = Color.FromArgb(224, 224, 224);
            labelSumPriceProduct.Location = new Point(81, 8);
            labelSumPriceProduct.Name = "labelSumPriceProduct";
            labelSumPriceProduct.Size = new Size(74, 28);
            labelSumPriceProduct.TabIndex = 4;
            labelSumPriceProduct.Text = "0 руб";
            // 
            // btnPlaceAnOrder
            // 
            btnPlaceAnOrder.BackColor = Color.SlateBlue;
            btnPlaceAnOrder.Cursor = Cursors.Hand;
            btnPlaceAnOrder.Dock = DockStyle.Bottom;
            btnPlaceAnOrder.FlatAppearance.BorderSize = 0;
            btnPlaceAnOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceAnOrder.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlaceAnOrder.Location = new Point(0, 46);
            btnPlaceAnOrder.Name = "btnPlaceAnOrder";
            btnPlaceAnOrder.Size = new Size(370, 39);
            btnPlaceAnOrder.TabIndex = 0;
            btnPlaceAnOrder.Text = "перейти к оформлению";
            btnPlaceAnOrder.UseVisualStyleBackColor = false;
            btnPlaceAnOrder.Click += btnPlaceAnOrder_Click;
            // 
            // FormBasket
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(963, 530);
            Controls.Add(panelBasket);
            Name = "FormBasket";
            Text = "FormBasket";
            panelBasket.ResumeLayout(false);
            panelVoid.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBasket;
        private Panel panelVoid;
        private Panel panelInfo;
        private Button btnPlaceAnOrder;
        private Label labelTotal;
        private Label labelSumPriceProduct;
    }
}