using Microsoft.Extensions.DependencyInjection;
using TaskManagementSystem.Forms;
using TaskManagementSystem.Services;

namespace TaskManagementSystem
{
    public partial class MainForm : Form
    {
        Login _login;
        Register _register;
        //Form1 _form1;
        //public Action NavigateToForm1Action;
        private readonly NavigationService _navigationService;
        private readonly IServiceProvider _serviceProvider;
        public MainForm(Login login ,Register register, NavigationService navigationService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _register = register;
            _register.OpenLoginForm += _register_OpenLoginForm;
            _login = login;
            _login.CloseMainForm += _login_CloseMainForm;
            _login.OpenRegisterForm += _login_OpenRegisterForm;
            //_form1 = form1;
            //_form1.NavigateToMainFormAction += ShowMainForm;
            _navigationService = navigationService;
            _navigationService.NavigateToForm1 += NavigateToForm1;
            _serviceProvider = serviceProvider;
        }
        private void NavigateToForm1()
        {
            this.Hide();
            var form1 = (Form1)Program.ServiceProvider.GetService(typeof(Form1)); // Pass the shared service to Form1
            //var form1 = _serviceProvider.GetRequiredService<Form1>(); // Pass the shared service to Form1
            form1.Show();
        }
        
        private void _login_CloseMainForm(object? sender, EventArgs e)
        {
            _navigationService.GoToForm1();
            //_navigationService.NavigateToForm1?.Invoke();
            //_form1.ShowDialog();
            //NavigateToForm1Action?.Invoke();
            //this.Close();
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
                this.panel2.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }
    }
}
