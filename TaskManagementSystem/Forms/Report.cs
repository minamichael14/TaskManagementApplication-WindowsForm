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
            LoadChart2();


        }

        private void LoadChart2()
        {// Get the task priorities grouped by priority level
            var taskPriorityCounts = _taskService.GetAll()
                .GroupBy(t => t.Priority)
                .Select(g => new { Priority = g.Key, Count = g.Count() })
                .OrderBy(x => x.Priority);  // Order by priority (Low, Medium, High)

            // Create series for each priority (Low, Medium, High)
            Series lowPrioritySeries = new Series("Low Priority")
            {
                ChartType = SeriesChartType.Column,  // Set chart type to Column (Vertical Bar)
                BorderWidth = 1,
                BorderColor = Color.Black,  // Set border color for the bars
                Color = Color.DarkOliveGreen,         // Set color for Low Priority bar
                IsValueShownAsLabel = true,  // Show the count as a label on the bar
            };

            Series mediumPrioritySeries = new Series("Medium Priority")
            {
                ChartType = SeriesChartType.Column,  // Set chart type to Column (Vertical Bar)
                BorderWidth = 1,
                BorderColor = Color.Black,  // Set border color for the bars
                Color = Color.ForestGreen,        // Set color for Medium Priority bar
                IsValueShownAsLabel = true,  // Show the count as a label on the bar
            };

            Series highPrioritySeries = new Series("High Priority")
            {
                ChartType = SeriesChartType.Column,  // Set chart type to Column (Vertical Bar)
                BorderWidth = 1,
                BorderColor = Color.Black,  // Set border color for the bars
                Color = Color.LimeGreen,           // Set color for High Priority bar
                IsValueShownAsLabel = true,  // Show the count as a label on the bar
            };

            // Loop through the task priority counts and add them to their respective series
            foreach (var priorityCount in taskPriorityCounts)
            {
                if (priorityCount.Priority == TaskPriority.Low)
                {
                    lowPrioritySeries.Points.AddXY(priorityCount.Priority.ToString(), priorityCount.Count);
                }
                else if (priorityCount.Priority == TaskPriority.Medium)
                {
                    mediumPrioritySeries.Points.AddXY(priorityCount.Priority.ToString(), priorityCount.Count);
                }
                else if (priorityCount.Priority == TaskPriority.High)
                {
                    highPrioritySeries.Points.AddXY(priorityCount.Priority.ToString(), priorityCount.Count);
                }
            }

            // Clear and add the series to the chart
            chart2.Series.Clear();  // Assuming chart2 is the name of your bar chart control
            chart2.Series.Add(lowPrioritySeries);
            chart2.Series.Add(mediumPrioritySeries);
            chart2.Series.Add(highPrioritySeries);

            // Set chart title
            chart2.Titles.Clear();
            chart2.Titles.Add("Task Priority Distribution");

            // Set the axis gap between bars
            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart2.ChartAreas[0].AxisX.IsMarginVisible = true; // Allow space between the bars
            chart2.ChartAreas[0].AxisX.LabelStyle.Angle = 45;  // Rotate the labels if necessary

            // Set a slight space between bars by adjusting the `PointWidth`
            lowPrioritySeries["PointWidth"] = "0.3";  // Set the width for Low Priority bars
            mediumPrioritySeries["PointWidth"] = "0.3";  // Set the width for Medium Priority bars
            highPrioritySeries["PointWidth"] = "0.3";  // Set the width for High Priority bars

            // Refresh the chart
            chart2.Invalidate();
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
            series1["PieStartAngle"] = "90";  // Start the chart at a 90-degree angle

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
                    series1.Points[pointIndex].Color = System.Drawing.Color.Green;    // Slice 1 - Red
                    PendingTasks.Text= statusCount.Count.ToString();
                }
                else if (statusCount.Status == TaskStatusValue.InProgress)
                {
                    series1.Points[pointIndex].Color = System.Drawing.Color.LimeGreen;    // Slice 1 - Red
                    InProgressTasks.Text = statusCount.Count.ToString();
                }
                else if (statusCount.Status == TaskStatusValue.Completed)
                {
                    series1.Points[pointIndex].Color = System.Drawing.Color.DarkGreen;    // Slice 1 - Red
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
