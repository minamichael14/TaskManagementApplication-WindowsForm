using System.Data;
using TaskManagementSystem.Services;
using System.Windows.Forms.DataVisualization.Charting;
using TaskManagementSystem.Models.Enums;


namespace TaskManagementSystem
{
    public partial class Report : Form
    {
        TasksService _taskService;
        public Report(TasksService taskService)
        {
            InitializeComponent();
            _taskService = taskService;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            LoadChart();

        }

        private void LoadChart()
        {
            var taskStatusCounts = _taskService.GetAll()
                .GroupBy(t => t.Status)
                .Select(g => new { Status = g.Key, Count = g.Count() })
                .OrderBy(x=>x.Status);

            
            Series series1 = new Series("Task status")
            {
                ChartType = SeriesChartType.Pie,

                BorderWidth = 1,
                BorderColor = Color.White,
            };
            int totalCount = taskStatusCounts.Sum(t => t.Count);
            TotalTasks.Text = totalCount.ToString();
            List<string> statusList =new List<string> { "Pending", "InProgress", "Completed" };

            foreach (var statusCount in taskStatusCounts)
            {

                double percentage = ((double)statusCount.Count / totalCount) * 100;

                // Add each status and its corresponding count as a data point
                int pointIndex = series1.Points.AddXY(statusCount.Status.ToString(), statusCount.Count);
                series1.Points[pointIndex].Label = $"{percentage:0.##}%";

                series1.Points[pointIndex].LegendText = $"{statusCount.Status.ToString()}";
                if (statusCount.Status == TaskStatusValue.Pending)
                {
                    PendingTasks.Text= statusCount.Count.ToString();
                }
                else if (statusCount.Status == TaskStatusValue.InProgress)
                {
                    InProgressTasks.Text = statusCount.Count.ToString();
                }
                else if (statusCount.Status == TaskStatusValue.Completed)
                {
                    CompletedTasks.Text = statusCount.Count.ToString();
                }

            }

            chart1.Series.Clear();
            chart1.Series.Add(series1);

            chart1.Titles.Clear();
            chart1.Titles.Add("Task Status Distribution");

            // Refresh the chart
            chart1.Invalidate();
        }

    }
}
