using Microsoft.Extensions.DependencyInjection;
using TaskManagementSystem.Forms;
using TaskManagementSystem.Helper;
using TaskManagementSystem.Services;

namespace TaskManagementSystem
{
    public partial class Form1 : Form
    {
        bool SidebarExpand = true;
        TaskVW _taskVW;
        private readonly NavigationService _navigationService;
        private readonly IServiceProvider _serviceProvider;

        public Form1(TaskVW taskVW, NavigationService navigationService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _taskVW = taskVW;
            _navigationService = navigationService;
            _navigationService.NavigateToMainForm += NavigateToMainForm;
            _serviceProvider = serviceProvider;
        }

        private void NavigateToMainForm()
        {
            this.Hide();
            var mainForm = _serviceProvider.GetRequiredService<MainForm>();  // Resolve MainForm from DI container
            mainForm.Show();
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            await loadform(_taskVW);
            label1.Text = UserSession.Username;

        }



        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                SidebarContainer.Width -= 10;
                mainpanel.Size = new Size(900, 694);//900; 620
                //mainpanel. = 12;
                mainpanel.Location = new Point(90, 62);
                if (SidebarContainer.Width == SidebarContainer.MinimumSize.Width)
                {
                    SidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                SidebarContainer.Width += 10;
                mainpanel.Size = new Size(771, 694); // 771; 694
                //mainpanel.Location = new Point(216, 62);//219; 62

                if (SidebarContainer.Width == SidebarContainer.MaximumSize.Width)
                {
                    SidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            //SidebarTimer.Start();
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            await loadform(_taskVW);
        }
        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            await loadform(_taskVW);
        }

        public async Task loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await loadform(new Report());
        }


        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            await loadform(new Report());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //_mainForm.ShowDialog();
            //NavigateToMainFormAction?.Invoke();
            _navigationService.GoToMainForm();

            //this.Close();
        }

        
    }
}
