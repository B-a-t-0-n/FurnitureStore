using System.ComponentModel.Design;
using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using System.Drawing.Imaging;
namespace FurnitureStore
{
    public partial class LoginForm : Form
    {
        public DatabaseManagement databaseManagement;
        public User ActiveUser;


        public LoginForm()
        {
            InitializeComponent();
            databaseManagement = new DatabaseManagement();
            databaseManagement.ConectTable("users", ref databaseManagement.activeUser);
            databaseManagement.ConectTable("basket", ref databaseManagement.activeBasket);
        }

        public LoginForm(DatabaseManagement databaseManagement)
        {
            InitializeComponent();
            this.databaseManagement = databaseManagement;
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            foreach (var user in databaseManagement.usersRepository.GetAll())
            {
                if (user.Login == textBoxLogin.Text && user.PaswordUser == textBoxPassword.Text)
                {
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    ActiveUser = user;
                    var mainForm = new MainForm(this);
                    mainForm.Show();
                    this.Hide();
                }
            }
        }

        private void labelReg_Click(object sender, EventArgs e)
        {
            var FormReg = new RegisterForm(this);
            this.Hide();
            FormReg.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = Properties.Resources._1;
            byte[] bytes;
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, ImageFormat.Bmp);
                bytes = stream.ToArray();
            }
        }
    }
}