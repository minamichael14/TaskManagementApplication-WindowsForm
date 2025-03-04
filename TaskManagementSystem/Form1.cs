using TaskManagementSystem.Forms;
using TaskManagementSystem.Helper;
using TaskManagementSystem.Models;
using TaskManagementSystem.Services;

namespace TaskManagementSystem
{
    public partial class Form1 : Form
    {
        bool SidebarExpand = true;
        TaskVW _taskVW;
        TasksService _tasksService;
        private System.Windows.Forms.Timer notificationTimer;
        
        public Form1(TasksService tasksService, TaskVW taskVW)
        {
            InitializeComponent();
            _taskVW = taskVW;
            _tasksService = tasksService;
            CheckTaskDueDates(); 

            // Initialize and start the timer
            notificationTimer = new System.Windows.Forms.Timer();
            notificationTimer.Interval = 30000; // Check every half minute (60000 ms)
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
            var overdueTasks = _tasksService.GetAll()
                .Where(t => t.DueDate < currentTime).ToList();

            foreach (var task in overdueTasks)
            {
                var taskx = new KeyValuePair<int, string>(task.ID, task.Title);
                if (!NotificationsSession.List.Contains(taskx))
                {
                    int notNum = int.Parse(label2.Text);
                    label2.Text = (++notNum).ToString();
                    label2.Visible = true;

                    NotificationsSession.List
                        .Add(new KeyValuePair<int, string>(task.ID, task.Title));
                }
            }
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
                mainpanel.Size = new Size(900, 694);
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
                mainpanel.Size = new Size(771, 694); 

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
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
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
            this.Hide();
            var mainForm = (MainForm)Program.ServiceProvider.GetService(typeof(MainForm));
            mainForm.Show();
            NotificationsSession.List = new List<KeyValuePair<int, string>>();
            notificationTimer.Stop();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = (MainForm)Program.ServiceProvider.GetService(typeof(MainForm));
            mainForm.Show();
            NotificationsSession.List = new List<KeyValuePair<int, string>>();
            notificationTimer.Stop();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await loadform(new NotificationVW());
            label2.Visible = false;
        }

        private async void pictureBox4_Click(object sender, EventArgs e)
        {
            await loadform(new NotificationVW());
            label2.Visible = false;

        }
    }

    //public class TaskItemEqualityComparer : IEqualityComparer<TaskItem>
    //{
    //    public bool Equals(TaskItem x, TaskItem y)
    //    {
    //        return x.ID == y.ID;
    //    }

    //    public int GetHashCode(TaskItem obj)
    //    {
    //        return obj.ID.GetHashCode();
    //    }
    //}
}
