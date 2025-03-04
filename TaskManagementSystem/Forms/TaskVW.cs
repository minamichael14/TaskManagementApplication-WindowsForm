using System.Data;
using TaskManagementSystem.Custom_Control;
using TaskManagementSystem.Models;
using TaskManagementSystem.Models.Enums;
using TaskManagementSystem.Services;

namespace TaskManagementSystem.Forms
{
    public partial class TaskVW : Form
    {
        public delegate IEnumerable<TaskItem> GetTaskItemDelegate(int pageNum);
        TasksService _tasksService;
        CategoryService _categoryService;
        TaskFieldsForm _form;
        int pageSize = 4;
        int CurrentPageNum = 1;
        GetTaskItemDelegate itemDelegate;
        TaskControl[] taskControls = new TaskControl[4];


        public TaskVW(TasksService tasksService, TaskFieldsForm form, CategoryService categoryService)
        {
            InitializeComponent();
            _tasksService = tasksService;
            _categoryService = categoryService;
            _form = form;
            itemDelegate = GetDataFromDatabase;
        }

        private async void TaskVW_LoadAsync(object sender, EventArgs e)
        {
            await PopulateTasks();
            CurrentNumLabel.Text = CurrentPageNum.ToString();
        }

        public async Task PopulateTasks()
        {
            var tasklist = await Task.Run(() => itemDelegate(CurrentPageNum));
            flowLayoutPanel1.Controls.Clear();
            int index = 0;
            foreach (var task in tasklist)
            {
                taskControls[index] = new TaskControl(_form, _tasksService);
                taskControls[index].ID = task.ID;
                taskControls[index].Title = task.Title;
                taskControls[index].Description = task.Description;
                taskControls[index].Status = task.Status.ToString();
                taskControls[index].Date = task.DueDate;
                taskControls[index].Priority = task.Priority;
                taskControls[index].Category = task.Category.Name.ToString();

                taskControls[index].EditButtonClick += TaskControl_EditButtonClick;
                taskControls[index].DeleteButtonClick += TaskControl_DeleteButtonClick;

                flowLayoutPanel1.Controls.Add(taskControls[index]);
                index++;
            }
        }

        private void TaskControl_EditButtonClick(object sender, EventArgs e)
        {
            TaskControl clickedControl = (TaskControl)sender;
            _form.AddDataToFields(clickedControl.ID);
            _form.FormType = "Edit Task";
            _form.ShowDialog();
            PopulateTasks();
        }
        private void TaskControl_DeleteButtonClick(object sender, EventArgs e)
        {
            PopulateTasks();
        }

        private void parrotSuperButton1_Click(object sender, EventArgs e)
        {
            TaskFieldsForm taskFields = new TaskFieldsForm(_tasksService, new AppDBContext(), _categoryService);
            taskFields.ShowDialog();
            SetCurrentPageNum(1);
            PopulateTasks();
        }

        private IEnumerable<TaskItem> GetDataFromDatabase(int pageNumber)
        {
            var tasklist = _tasksService.GetAll()
                .Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return tasklist;
        }

        private void previousTag_Click(object sender, EventArgs e)
        {
            if (CurrentPageNum > 1)
            {
                CurrentPageNum--;
                PopulateTasks();
                UpdatePaginationLabel();
            }
        }

        private void UpdatePaginationLabel()
        {
            CurrentNumLabel.Text = CurrentPageNum.ToString();
            if (CurrentPageNum == 1)
            {
                beforeNumLabel.Text = "";
            }
            else
            {
                beforeNumLabel.Text = (CurrentPageNum - 1).ToString();
            }
            afterNumLabel.Text = (CurrentPageNum + 1).ToString();
        }

        private void NextTag_Click(object sender, EventArgs e)
        {
            var isExist = _tasksService.GetAll()
                .Skip((CurrentPageNum) * pageSize).Take(pageSize)
                .Any();
            if (isExist)
            {
                CurrentPageNum++;
                PopulateTasks();
                UpdatePaginationLabel();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //itemDelegate = FilterDataByDueDate;
            //SetCurrentPageNum(1);
            //PopulateTasks();
        }
        private void SetCurrentPageNum(int value)
        {
            CurrentPageNum = value;
            CurrentNumLabel.Text = CurrentPageNum.ToString();
            if (CurrentPageNum == 1)
            {
                beforeNumLabel.Text = "";

            }
            else
            {
                beforeNumLabel.Text = (CurrentPageNum - 1).ToString();

            }
            afterNumLabel.Text = (CurrentPageNum + 1).ToString();


        }

        private IEnumerable<TaskItem> FilterDataByDueDate(int pageNumber)
        {
            var selectedList = GetSelectedItems();
            if (selectedList.Count > 0)
            {
                return _tasksService.GetAll().Where(task => selectedList.Contains(task.Status)).OrderBy(x => x.DueDate)
                    .Skip((pageNumber - 1) * pageSize).Take(pageSize);
            }
            else
            {
                return _tasksService.GetAll().OrderBy(x => x.DueDate)
                    .Skip((pageNumber - 1) * pageSize).Take(pageSize);
            }
        }
        private IEnumerable<TaskItem> FilterDataByPriority(int pageNumber)
        {
            var selectedList = GetSelectedItems();
            if (selectedList.Count > 0)
            {
                return _tasksService.GetAll().Where(task => selectedList.Contains(task.Status))
                .OrderByDescending(x => x.Priority)
                .Skip((pageNumber - 1) * pageSize).Take(pageSize);
            }
            else
            {
                return _tasksService.GetAll()
                .OrderByDescending(x => x.Priority)
                .Skip((pageNumber - 1) * pageSize).Take(pageSize);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //itemDelegate = FilterDataByPriority;
            //SetCurrentPageNum(1);
            //PopulateTasks();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.Items[e.Index].ToString() == "All")
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        if (checkedListBox1.Items[i].ToString() != "All")
                        {
                            checkedListBox1.SetItemChecked(i, true);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        if (checkedListBox1.Items[i].ToString() != "All")
                        {
                            checkedListBox1.SetItemChecked(i, false);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.Items[i].ToString() == "All")
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            }
            itemDelegate = FilterByChecked;
            SetCurrentPageNum(1);
            PopulateTasks();

        }


        private IEnumerable<TaskItem> FilterByChecked(int pageNumber)
        {
            var selectedStatuses = new List<TaskStatusValue>();

            foreach (int i in checkedListBox1.CheckedIndices)
            {
                selectedStatuses.Add((TaskStatusValue)Enum.Parse(typeof(TaskStatusValue), checkedListBox1.Items[i].ToString()));
            }


            if (selectedStatuses.Count == 0)
            {
                return GetDataFromDatabase(1);
            }
            else
            {
                return _tasksService.GetAll().Where(task => selectedStatuses.Contains(task.Status))
                .Skip((pageNumber - 1) * pageSize).Take(pageSize);
            }
        }

        private void aloneButton2_Click(object sender, EventArgs e)
        {
            itemDelegate = GetSearched;
            SetCurrentPageNum(1);
            PopulateTasks();


        }

        private IEnumerable<TaskItem> GetSearched(int pageNumber)
        {
            var value = aloneTextBox1.Text;
            return _tasksService.GetAll().Where(x => x.Title.ToLower().Contains(value.ToLower()) || x.Description.ToLower().Contains(value.ToLower())).Distinct();
        }
        private List<TaskStatusValue> GetSelectedItems()
        {
            List<TaskStatusValue> selectedItems = new List<TaskStatusValue>();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                selectedItems.Add((TaskStatusValue)Enum.Parse(typeof(TaskStatusValue), item.ToString()));
            }

            return selectedItems;
        }



        private void aloneTextBox1_Click_1(object sender, EventArgs e)
        {
            aloneTextBox1.Text = "";

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            itemDelegate = FilterDataByDueDate;
            SetCurrentPageNum(1);
            PopulateTasks();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            itemDelegate = FilterDataByPriority;
            SetCurrentPageNum(1);
            PopulateTasks();
        }
    }
}
