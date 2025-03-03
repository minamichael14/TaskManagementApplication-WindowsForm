using TaskManagementSystem.Models;
using TaskManagementSystem.Services;

namespace TaskManagementSystem.Forms
{
    public partial class Register : Form
    {
        UserService _userService;
        //Login _login;
        public event EventHandler OpenLoginForm;
        public Register(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
            //_login = login;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            await _userService.RegisterAsync(user);
            OpenLoginForm?.Invoke(this, e);

        }

        private void Register_Load(object sender, EventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLoginForm?.Invoke(this, e);
        }
        
    }
}
