using System.Diagnostics;
using TaskManagementSystem.Forms;
using TaskManagementSystem.Helper;
using TaskManagementSystem.Models;
using TaskManagementSystem.Services;

namespace TaskManagementSystem
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer notificationTimer;
        private NotifyIcon taskNotifyIcon;
        private HashSet<TaskItem> notifiedTasks;

        bool SidebarExpand = true;
        TaskVW _taskVW;
        private readonly NavigationService _navigationService;
        private readonly IServiceProvider _serviceProvider;
        Report _report;
        TasksService _tasksService;

        public Form1(TasksService tasksService, Report report, TaskVW taskVW, NavigationService navigationService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _taskVW = taskVW;
            _navigationService = navigationService;
            _navigationService.NavigateToMainForm += NavigateToMainForm;
            _serviceProvider = serviceProvider;
            _report = report;
            _tasksService = tasksService;


            notifiedTasks = new HashSet<TaskItem>(new TaskItemEqualityComparer());

            // Initialize and start the timer
            notificationTimer = new System.Windows.Forms.Timer();
            notificationTimer.Interval = 10000; // Check every minute (60000 ms)
            notificationTimer.Tick += NotificationTimer_Tick;
            notificationTimer.Start();
        }
        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            CheckTaskDueDates();
        }

        private void CheckTaskDueDates()
        {
            DateTime currentTime = DateTime.Now;

            // Get tasks where the due date has passed
            var overdueTasks = _tasksService.GetAll().Where(t => t.DueDate < currentTime).ToList();

            foreach (var task in overdueTasks)
            {
                if (!notifiedTasks.Contains(task))
                {
                    int notNum = int.Parse(label2.Text);

                    label2.Text = (++notNum).ToString();
                    label2.Visible = true;
                    notifiedTasks.Add(task);
                    NotificationsSession.List.Add(new KeyValuePair<int, string>(task.ID, task.Title));

                    //Console.WriteLine($"Task '{task.Title}' is overdue! It was due on {task.DueDate}.");
                }
            }
        }


        private void NavigateToMainForm()
        {
            this.Hide();
            var mainForm = (MainForm)Program.ServiceProvider.GetService(typeof(MainForm));  // Resolve MainForm from DI container
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
            await loadform(new Report(_tasksService));

        }


        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            await loadform(new Report(_tasksService));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _navigationService.GoToMainForm();
            NotificationsSession.List.Clear();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            _navigationService.GoToMainForm();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await loadform(new NotificationVW());
        }

        private async void pictureBox4_Click(object sender, EventArgs e)
        {
            await loadform(new NotificationVW());
        }
    }

    public class TaskItemEqualityComparer : IEqualityComparer<TaskItem>
    {
        public bool Equals(TaskItem x, TaskItem y)
        {
            // Tasks are considered equal if their names and due dates are the same
            return x.ID == y.ID;
        }

        public int GetHashCode(TaskItem obj)
        {
            // Combine hash codes of ID and DueDate
            return obj.ID.GetHashCode();
        }
    }
}
