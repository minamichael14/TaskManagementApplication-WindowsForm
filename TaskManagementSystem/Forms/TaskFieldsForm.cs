using System.Data;
using TaskManagementSystem.Models;
using TaskManagementSystem.Models.Enums;
using TaskManagementSystem.Services;

namespace TaskManagementSystem.Forms
{
    public partial class TaskFieldsForm : Form
    {
        AppDBContext _context;
        TasksService _tasksService;
        CategoryService _categoryService;

        public TaskFieldsForm(TasksService tasksService, AppDBContext context, CategoryService categoryService)
        {
            InitializeComponent();
            _context = context;
            _tasksService = tasksService;
            _categoryService = categoryService;
        }

        private void TaskFieldsForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new List<string> { "Low", "Medium", "High" };
            comboBox3.DataSource = new List<string> { "Pending", "InProgress", "Completed" };
            comboBox4.DataSource = _categoryService.GetAll().Select(x => x.Name).ToList();
        }
        public string FormType
        {
            set
            {
                label1.Text = value;
                parrotSuperButton1.ButtonText = value;
            }
        }


        public async void AddDataToFields(int id)
        {
            var taskItem = await _tasksService.GetByID(id);

            IDTxt.Text = id.ToString();
            textBox1.Text = taskItem.Title;
            textBox2.Text = taskItem.Description;
            dateTimePicker1.Value = taskItem.DueDate;
            comboBox1.Text = taskItem.Priority.ToString();
            comboBox3.Text = taskItem.Status.ToString();
            comboBox4.Text = taskItem.Category.Name;
        }

        private void parrotSuperButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private TaskItem GetObjectFromFields()
        {
            int id;
            int.TryParse(IDTxt.Text, out id);
            string title = textBox1.Text;
            string description = textBox2.Text;
            DateTime dateTime = dateTimePicker1.Value;
            TaskPriority taskPriority = (TaskPriority)Enum.Parse(typeof(TaskPriority), comboBox1.Text);
            TaskStatusValue taskStatus = (TaskStatusValue)Enum.Parse(typeof(TaskStatusValue), comboBox3.Text);
            string taskCategory = comboBox4.Text;

            //var userID = _context.Users.Where(x => x.Name == userName).Select(x => x.ID).FirstOrDefault();
            var CategoryID = _context.Categories.Where(x => x.Name == taskCategory).Select(x => x.ID).FirstOrDefault();
            var task = new TaskItem
            {
                ID = id,
                Title = title,
                Description = description,
                DueDate = dateTime,
                Priority = taskPriority,
                Status = taskStatus,
                //UserId = userID,
                CategoryID = CategoryID
            };
            return task;
        }
        private async void parrotSuperButton1_ClickAsync(object sender, EventArgs e)
        {
            if (parrotSuperButton1.ButtonText == "Add Task")
            {
                await AddProcess();

            }
            else
            {
                EditProcess();
            }

            this.Close();
        }

        private async Task AddProcess()
        {
            await _tasksService.AddAsync(GetObjectFromFields());
        }
        private void EditProcess()
        {
            _tasksService.Update(GetObjectFromFields());
        }

        private void parrotSuperButton3_Click(object sender, EventArgs e)
        {
            var addingCategory = new CategoryAdd(_categoryService);
            addingCategory.ShowDialog();
            comboBox4.DataSource = _categoryService.GetAll().Select(x => x.Name).ToList();


        }
    }
}
