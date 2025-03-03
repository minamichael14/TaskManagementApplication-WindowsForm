using TaskManagementSystem.Services;

namespace TaskManagementSystem.Forms
{
    public partial class Login : Form
    {
        UserService _userService;
        //Form1 _form1;
        public event EventHandler CloseMainForm;

        public event EventHandler OpenRegisterForm;

        public Login(UserService userService, Register register)
        {
            InitializeComponent();
            _userService = userService;
            //_form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (_userService.login(txtUsername.Text, txtPassword.Text))
            {
                //MessageBox.Show("Login successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //_form1.ShowDialog();
                CloseMainForm?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Login Not successful!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public async Task loadform(object Form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenRegisterForm?.Invoke(this, e);

        }

    }
}
