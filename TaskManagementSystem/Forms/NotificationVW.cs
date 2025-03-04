using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementSystem.Custom_Control;
using TaskManagementSystem.Helper;

namespace TaskManagementSystem.Forms
{
    public partial class NotificationVW : Form
    {
        public NotificationVW()
        {
            InitializeComponent();
        }

        private void NotificationVW_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            var list = NotificationsSession.List;
            foreach (var item in list)
            {
                Notification n1 = new Notification();
                n1.ID = item.Key;
                n1.Message = $"Reminder: The following task is overdue: '{item.Value}' . Please address it ASAP.";
                flowLayoutPanel1.Controls.Add(n1);
            }
        }
    }
}
