using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace FurnitureStore
{
    partial class FormHome
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
            flowLayoutPanelProducts = new FlowLayoutPanel();
            panelSearch = new Panel();
            textBoxSearch = new TextBox();
            panelVoidSearchUp = new Panel();
            panelVoidSearchBottom = new Panel();
            buttonSearch = new Button();
            panelFilter = new Panel();
            panelSelectType = new Panel();
            panelType = new Panel();
            labelType = new Label();
            panelPrice = new Panel();
            textBoxPriceStop = new TextBox();
            textBoxPriceStart = new TextBox();
            labelPrice = new Label();
            panelvoid2 = new Panel();
            buttonSave = new Button();
            buttonReset = new Button();
            panelVoid = new Panel();
            labelNameColum = new Label();
            panel = new Panel();
            panel1 = new Panel();
            panelSearch.SuspendLayout();
            panelFilter.SuspendLayout();
            panelSelectType.SuspendLayout();
            panelPrice.SuspendLayout();
            panelVoid.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanelProducts.Dock = DockStyle.Fill;
            flowLayoutPanelProducts.Location = new Point(0, 0);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(1271, 576);
            flowLayoutPanelProducts.TabIndex = 0;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(64, 64, 64);
            panelSearch.Controls.Add(textBoxSearch);
            panelSearch.Controls.Add(panelVoidSearchUp);
            panelSearch.Controls.Add(panelVoidSearchBottom);
            panelSearch.Controls.Add(buttonSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(5, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1271, 55);
            panelSearch.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(64, 64, 64);
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Cursor = Cursors.IBeam;
            textBoxSearch.Dock = DockStyle.Fill;
            textBoxSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.ForeColor = Color.FromArgb(224, 224, 224);
            textBoxSearch.Location = new Point(0, 16);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.RightToLeft = RightToLeft.No;
            textBoxSearch.Size = new Size(1205, 25);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.Enter += textBoxSearch_Enter;
            textBoxSearch.Leave += textBoxSearch_Leave;
            // 
            // panelVoidSearchUp
            // 
            panelVoidSearchUp.Dock = DockStyle.Top;
            panelVoidSearchUp.Location = new Point(0, 0);
            panelVoidSearchUp.Name = "panelVoidSearchUp";
            panelVoidSearchUp.Size = new Size(1205, 16);
            panelVoidSearchUp.TabIndex = 4;
            // 
            // panelVoidSearchBottom
            // 
            panelVoidSearchBottom.Dock = DockStyle.Bottom;
            panelVoidSearchBottom.Location = new Point(0, 39);
            panelVoidSearchBottom.Name = "panelVoidSearchBottom";
            panelVoidSearchBottom.Size = new Size(1205, 16);
            panelVoidSearchBottom.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.SlateBlue;
            buttonSearch.Dock = DockStyle.Right;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.ForeColor = Color.FromArgb(224, 224, 224);
            buttonSearch.Image = Properties.Resources.search;
            buttonSearch.Location = new Point(1205, 0);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(66, 55);
            buttonSearch.TabIndex = 1;
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.FromArgb(64, 64, 64);
            panelFilter.BorderStyle = BorderStyle.FixedSingle;
            panelFilter.Controls.Add(panelSelectType);
            panelFilter.Controls.Add(panelPrice);
            panelFilter.Controls.Add(panelvoid2);
            panelFilter.Controls.Add(buttonSave);
            panelFilter.Controls.Add(buttonReset);
            panelFilter.Controls.Add(panelVoid);
            panelFilter.Dock = DockStyle.Right;
            panelFilter.Location = new Point(1276, 0);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(201, 631);
            panelFilter.TabIndex = 2;
            // 
            // panelSelectType
            // 
            panelSelectType.Controls.Add(panelType);
            panelSelectType.Controls.Add(labelType);
            panelSelectType.Dock = DockStyle.Fill;
            panelSelectType.Location = new Point(0, 127);
            panelSelectType.Name = "panelSelectType";
            panelSelectType.Size = new Size(199, 410);
            panelSelectType.TabIndex = 11;
            // 
            // panelType
            // 
            panelType.Dock = DockStyle.Fill;
            panelType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelType.ForeColor = Color.FromArgb(224, 224, 224);
            panelType.Location = new Point(0, 25);
            panelType.Name = "panelType";
            panelType.Size = new Size(199, 385);
            panelType.TabIndex = 8;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Dock = DockStyle.Top;
            labelType.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelType.ForeColor = Color.FromArgb(224, 224, 224);
            labelType.Location = new Point(0, 0);
            labelType.Name = "labelType";
            labelType.Size = new Size(42, 25);
            labelType.TabIndex = 7;
            labelType.Text = "тип";
            // 
            // panelPrice
            // 
            panelPrice.Controls.Add(textBoxPriceStop);
            panelPrice.Controls.Add(textBoxPriceStart);
            panelPrice.Controls.Add(labelPrice);
            panelPrice.Dock = DockStyle.Top;
            panelPrice.Location = new Point(0, 53);
            panelPrice.Name = "panelPrice";
            panelPrice.Size = new Size(199, 74);
            panelPrice.TabIndex = 10;
            // 
            // textBoxPriceStop
            // 
            textBoxPriceStop.BackColor = Color.FromArgb(64, 64, 64);
            textBoxPriceStop.BorderStyle = BorderStyle.FixedSingle;
            textBoxPriceStop.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPriceStop.ForeColor = Color.FromArgb(224, 224, 224);
            textBoxPriceStop.Location = new Point(113, 42);
            textBoxPriceStop.Name = "textBoxPriceStop";
            textBoxPriceStop.Size = new Size(82, 27);
            textBoxPriceStop.TabIndex = 8;
            textBoxPriceStop.KeyPress += textBoxPrice_KeyPress;
            // 
            // textBoxPriceStart
            // 
            textBoxPriceStart.BackColor = Color.FromArgb(64, 64, 64);
            textBoxPriceStart.BorderStyle = BorderStyle.FixedSingle;
            textBoxPriceStart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPriceStart.ForeColor = Color.FromArgb(224, 224, 224);
            textBoxPriceStart.Location = new Point(4, 42);
            textBoxPriceStart.Name = "textBoxPriceStart";
            textBoxPriceStart.Size = new Size(84, 27);
            textBoxPriceStart.TabIndex = 7;
            textBoxPriceStart.KeyPress += textBoxPrice_KeyPress;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrice.ForeColor = Color.FromArgb(224, 224, 224);
            labelPrice.Location = new Point(4, 5);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(55, 25);
            labelPrice.TabIndex = 6;
            labelPrice.Text = "цена";
            // 
            // panelvoid2
            // 
            panelvoid2.Dock = DockStyle.Bottom;
            panelvoid2.Location = new Point(0, 537);
            panelvoid2.Name = "panelvoid2";
            panelvoid2.Size = new Size(199, 12);
            panelvoid2.TabIndex = 9;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.SlateBlue;
            buttonSave.Dock = DockStyle.Bottom;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.FromArgb(224, 224, 224);
            buttonSave.Location = new Point(0, 549);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(199, 40);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Применить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.FromArgb(64, 64, 64);
            buttonReset.Dock = DockStyle.Bottom;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReset.ForeColor = Color.FromArgb(224, 224, 224);
            buttonReset.Location = new Point(0, 589);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(199, 40);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "сбросить";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // panelVoid
            // 
            panelVoid.Controls.Add(labelNameColum);
            panelVoid.Dock = DockStyle.Top;
            panelVoid.Location = new Point(0, 0);
            panelVoid.Name = "panelVoid";
            panelVoid.Size = new Size(199, 53);
            panelVoid.TabIndex = 1;
            // 
            // labelNameColum
            // 
            labelNameColum.AutoSize = true;
            labelNameColum.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point);
            labelNameColum.ForeColor = Color.FromArgb(224, 224, 224);
            labelNameColum.Location = new Point(42, 8);
            labelNameColum.Name = "labelNameColum";
            labelNameColum.Size = new Size(110, 31);
            labelNameColum.TabIndex = 4;
            labelNameColum.Text = "фильтры";
            // 
            // panel
            // 
            panel.BackColor = Color.RosyBrown;
            panel.Controls.Add(flowLayoutPanelProducts);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(5, 55);
            panel.Name = "panel";
            panel.Size = new Size(1271, 576);
            panel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 631);
            panel1.TabIndex = 4;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Silver;
            ClientSize = new Size(1477, 631);
            Controls.Add(panel);
            Controls.Add(panelSearch);
            Controls.Add(panelFilter);
            Controls.Add(panel1);
            Name = "FormHome";
            Text = "FormHome";
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelFilter.ResumeLayout(false);
            panelSelectType.ResumeLayout(false);
            panelSelectType.PerformLayout();
            panelPrice.ResumeLayout(false);
            panelPrice.PerformLayout();
            panelVoid.ResumeLayout(false);
            panelVoid.PerformLayout();
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private HScrollBar hScrollBar1;
        private FlowLayoutPanel flowLayoutPanelProducts;
        private Panel panelSearch;
        private Button buttonSearch;
        private Panel panelFilter;
        private Panel panel;
        private TextBox textBoxSearch;
        private Panel panelVoidSearchUp;
        private Panel panelVoidSearchBottom;
        private Panel panel1;
        private Button buttonSave;
        private Button buttonReset;
        private Panel panelVoid;
        private Label labelNameColum;
        private Panel panelvoid2;
        private Panel panelPrice;
        private TextBox textBoxPriceStop;
        private TextBox textBoxPriceStart;
        private Label labelPrice;
        private Panel panelSelectType;
        private Label labelType;
        private Panel panelType;

    }
}