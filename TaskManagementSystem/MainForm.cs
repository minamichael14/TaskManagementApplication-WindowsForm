using TaskManagementSystem.Forms;

namespace TaskManagementSystem
{
    public partial class MainForm : Form
    {
        Login _login;
        Register _register;
        public MainForm(Login login ,Register register)
        {
            InitializeComponent();
            _register = register;
            _register.OpenLoginForm += _register_OpenLoginForm;
            _login = login;
            _login.CloseMainForm += _login_CloseMainForm;
            _login.OpenRegisterForm += _login_OpenRegisterForm;
        }
       
        private void _login_CloseMainForm(object? sender, EventArgs e)
        {
            this.Hide();
            var form1 = (Form1)Program.ServiceProvider.GetService(typeof(Form1)); // Pass the shared service to Form1
            form1.Show();
        }

        private async void _register_OpenLoginForm(object? sender, EventArgs e)
        {
            await loadform(_login);
        }

        private async void _login_OpenRegisterForm(object? sender, EventArgs e)
        {
            await loadform(_register);
        }

        private async void MainForm_LoadAsync(object sender, EventArgs e)
        {
            await loadform(_login);
        }

        public async Task loadform(object Form)
        {
            if (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }
    }
}
