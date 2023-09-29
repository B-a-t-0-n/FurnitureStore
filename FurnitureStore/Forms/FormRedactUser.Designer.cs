using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;
namespace FurnitureStore
{
    partial class FormRedactUser
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
            buttonDelete = new Button();
            buttonSave = new Button();
            panelInfo = new Panel();
            labelLoginUser = new Label();
            labelIdUser = new Label();
            checkBoxAdmin = new CheckBox();
            panelControl.SuspendLayout();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl
            // 
            panelControl.BackColor = Color.FromArgb(64, 64, 64);
            panelControl.BorderStyle = BorderStyle.FixedSingle;
            panelControl.Controls.Add(listBoxUsers);
            panelControl.Controls.Add(buttonDelete);
            panelControl.Controls.Add(buttonSave);
            panelControl.Dock = DockStyle.Right;
            panelControl.Location = new Point(393, 0);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(234, 306);
            panelControl.TabIndex = 0;
            // 
            // listBoxUsers
            // 
            listBoxUsers.BackColor = Color.FromArgb(74, 74, 74);
            listBoxUsers.BorderStyle = BorderStyle.None;
            listBoxUsers.Dock = DockStyle.Top;
            listBoxUsers.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxUsers.ForeColor = Color.FromArgb(224, 224, 224);
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 20;
            listBoxUsers.Location = new Point(0, 42);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(232, 200);
            listBoxUsers.TabIndex = 2;
            listBoxUsers.DrawItem += listBoxUsers_DrawItem;
            listBoxUsers.SelectedIndexChanged += listBoxUsers_SelectedIndexChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top;
            buttonDelete.BackColor = Color.SlateBlue;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.FromArgb(224, 224, 224);
            buttonDelete.Location = new Point(138, 264);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(95, 30);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.SlateBlue;
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Dock = DockStyle.Top;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.FromArgb(224, 224, 224);
            buttonSave.Location = new Point(0, 0);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(232, 42);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить изменения";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(64, 64, 64);
            panelInfo.BorderStyle = BorderStyle.FixedSingle;
            panelInfo.Controls.Add(labelLoginUser);
            panelInfo.Controls.Add(labelIdUser);
            panelInfo.Controls.Add(checkBoxAdmin);
            panelInfo.Dock = DockStyle.Fill;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(393, 306);
            panelInfo.TabIndex = 1;
            // 
            // labelLoginUser
            // 
            labelLoginUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLoginUser.AutoSize = true;
            labelLoginUser.FlatStyle = FlatStyle.Flat;
            labelLoginUser.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelLoginUser.ForeColor = Color.FromArgb(224, 224, 224);
            labelLoginUser.Location = new Point(11, 55);
            labelLoginUser.Name = "labelLoginUser";
            labelLoginUser.Size = new Size(85, 30);
            labelLoginUser.TabIndex = 2;
            labelLoginUser.Text = "Login ::";
            // 
            // labelIdUser
            // 
            labelIdUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelIdUser.AutoSize = true;
            labelIdUser.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelIdUser.ForeColor = Color.FromArgb(224, 224, 224);
            labelIdUser.Location = new Point(11, 10);
            labelIdUser.Name = "labelIdUser";
            labelIdUser.Size = new Size(54, 30);
            labelIdUser.TabIndex = 1;
            labelIdUser.Text = "Id :: ";
            // 
            // checkBoxAdmin
            // 
            checkBoxAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxAdmin.AutoSize = true;
            checkBoxAdmin.Checked = true;
            checkBoxAdmin.CheckState = CheckState.Checked;
            checkBoxAdmin.Cursor = Cursors.Hand;
            checkBoxAdmin.FlatAppearance.BorderSize = 0;
            checkBoxAdmin.FlatStyle = FlatStyle.Flat;
            checkBoxAdmin.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxAdmin.ForeColor = Color.FromArgb(224, 224, 224);
            checkBoxAdmin.Location = new Point(265, 11);
            checkBoxAdmin.Name = "checkBoxAdmin";
            checkBoxAdmin.Size = new Size(95, 34);
            checkBoxAdmin.TabIndex = 0;
            checkBoxAdmin.Text = "Admin";
            checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // FormRedactUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(627, 306);
            Controls.Add(panelInfo);
            Controls.Add(panelControl);
            Name = "FormRedactUser";
            Text = "FormRedactUser";
            panelControl.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelControl;
        private ListBox listBoxUsers;
        private Button buttonDelete;
        private Button buttonSave;
        private Panel panelInfo;
        private Label labelLoginUser;
        private Label labelIdUser;
        private CheckBox checkBoxAdmin;
    }
}