namespace TaskManagementSystem.Custom_Control
{
    public partial class Notification : UserControl
    {
        private int value;

        public Notification()
        {
            InitializeComponent();
            value = this.Location.Y - 100;
        }


        public string Message
        {
            set
            {
                label1.Text = value;
            }
        }
        public int ID
        {
            get { return int.Parse(HiddenID.Text); }
            set { HiddenID.Text = value.ToString(); } 
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X, this.Location.Y - 10);
            if (this.Location.Y == value)
                timer1.Stop();

        }

        private void Notification_Load(object sender, EventArgs e)
        {

        }
    }
}
