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
    public partial class MainForm : Form
    {
        private LoginForm logForm;
        private Form activeForm;

        public MainForm(LoginForm logForm)
        {
            InitializeComponent();
            this.logForm = logForm;
            AdminMenu(this.logForm.ActiveUser.IsAdmin);
            OpenChildForm(new FormHome(logForm), buttonHome);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHome(logForm), (Button)sender);
        }

        private void buttonBasket_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBasket(logForm), (Button)sender);

        }

        private void btnRedactProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRedactProduct(logForm), (Button)sender);
        }

        private void btnRedactUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRedactUser(logForm), (Button)sender);
        }

        private void btnRedactBsscet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRedactBasket(logForm), (Button)sender);
        }

        private void AdminMenu(bool isAdmin)
        {
            btnRedactProduct.Enabled = isAdmin;
            btnRedactProduct.Visible = isAdmin;

            btnRedactUser.Enabled = isAdmin;
            btnRedactUser.Visible = isAdmin;

            btnRedactBssket.Enabled = isAdmin;
            btnRedactBssket.Visible = isAdmin;

        }

        private void OpenChildForm(Form childForm, Object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            FocusingTheButton((Button)sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Button btn = (Button)sender;
            labelNameForm.Text = btn.Text;
        }

        private void FocusingTheButton(Button button)
        {
            foreach (Control a in panelMenu.Controls)
            {
                if (a.GetType() == typeof(Button))
                {
                    a.BackColor = Color.FromArgb(64, 64, 64);
                    a.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                }
            }

            button.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button.BackColor = Color.SlateBlue;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            logForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            logForm.Close();
        }
    }
}
