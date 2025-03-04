using TaskManagementSystem.Forms;
using TaskManagementSystem.Models;
using TaskManagementSystem.Models.Enums;
using TaskManagementSystem.Services;

namespace TaskManagementSystem.Custom_Control
{
    public partial class TaskControl : UserControl
    {
        TaskFieldsForm _fieldsForm;
        public event EventHandler EditButtonClick;
        public event EventHandler DeleteButtonClick;
        TasksService _taskService;
        public TaskControl(TaskFieldsForm fieldsForm, TasksService tasksService)
        {
            InitializeComponent();
            _fieldsForm = fieldsForm;
            _taskService = tasksService;
            
        }

        public Color ControlBackgroundColor
        {
            set { this.BackColor = value; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public int ID
        {
            get { return int.Parse(IDTxt.Text); }
            set { IDTxt.Text = value.ToString(); }
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; Titlelabel.Text = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; DescLabel.Text = value; }
        }
        private string _status;
        public string Status
        {
            get { return _status; }
            set { _status = value; StatusLabel.Text = value; }
        }

        private string _user;
        public string User
        {
            get { return _user; }
            set { _user = value; CategoryLabel.Text = value; }
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; DateLabel.Text = value.ToString("dd/MM HH:mm"); }
        }

        private TaskPriority _priority;
        public TaskPriority Priority
        {
            get { return _priority; }
            set {
                _priority = value;

                label1.Text = value switch
                {
                    TaskPriority.Low => "L",
                    TaskPriority.Medium => "M",
                    TaskPriority.High => "H",
                    TaskPriority.None => "N"
                };
            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            EditButtonClick?.Invoke(this, e);
        }

        private async void Deletebutton_ClickAsync(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
            "Are you sure you want to delete this item?",
            "Delete Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                await _taskService.DeleteAsync(ID);
            }
            
            DeleteButtonClick?.Invoke(this, e);

        }
    }
}
