namespace TaskManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label8 = new Label();
            MenuBtn = new PictureBox();
            SidebarContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            label9 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            panel6 = new Panel();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            button4 = new Button();
            panel7 = new Panel();
            pictureBox5 = new PictureBox();
            button5 = new Button();
            panel5 = new Panel();
            panel8 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            mainpanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).BeginInit();
            SidebarContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1165, 56);
            panel1.TabIndex = 20;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(224, 224, 224);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(224, 224, 224);
            nightControlBox1.EnableCloseColor = Color.FromArgb(224, 224, 224);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(224, 224, 224);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(224, 224, 224);
            nightControlBox1.Location = new Point(1026, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat-Arabic Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(17, 11);
            label8.Name = "label8";
            label8.Size = new Size(288, 32);
            label8.TabIndex = 1;
            label8.Text = "Task Management System";
            // 
            // MenuBtn
            // 
            MenuBtn.BackColor = Color.Transparent;
            MenuBtn.Cursor = Cursors.Hand;
            MenuBtn.Image = (Image)resources.GetObject("MenuBtn.Image");
            MenuBtn.Location = new Point(18, 20);
            MenuBtn.Margin = new Padding(3, 3, 3, 0);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(44, 28);
            MenuBtn.SizeMode = PictureBoxSizeMode.Zoom;
            MenuBtn.TabIndex = 0;
            MenuBtn.TabStop = false;
            MenuBtn.Click += MenuBtn_Click;
            // 
            // SidebarContainer
            // 
            SidebarContainer.AutoSize = true;
            SidebarContainer.BackColor = Color.FromArgb(45, 45, 45);
            SidebarContainer.Controls.Add(panel3);
            SidebarContainer.Controls.Add(panel2);
            SidebarContainer.Controls.Add(panel4);
            SidebarContainer.Controls.Add(panel6);
            SidebarContainer.Controls.Add(panel7);
            SidebarContainer.Controls.Add(panel5);
            SidebarContainer.Controls.Add(panel8);
            SidebarContainer.Location = new Point(0, 56);
            SidebarContainer.Margin = new Padding(0);
            SidebarContainer.MaximumSize = new Size(210, -1);
            SidebarContainer.MinimumSize = new Size(84, 940);
            SidebarContainer.Name = "SidebarContainer";
            SidebarContainer.Size = new Size(210, 940);
            SidebarContainer.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 45, 45);
            panel3.CausesValidation = false;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(MenuBtn);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 71);
            panel3.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Montserrat-Arabic Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(82, 18);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(72, 32);
            label9.TabIndex = 3;
            label9.Text = "Menu";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 71);
            panel2.Margin = new Padding(3, 0, 3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 55);
            panel2.TabIndex = 23;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(45, 45, 45);
            button2.CausesValidation = false;
            button2.Font = new Font("Montserrat-Arabic SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-66, -18);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(347, 92);
            button2.TabIndex = 22;
            button2.Text = "Task";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_ClickAsync;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 132);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 55);
            panel4.TabIndex = 24;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(45, 45, 45);
            button3.CausesValidation = false;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-58, -18);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(347, 92);
            button3.TabIndex = 22;
            button3.Text = "Report";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(button4);
            panel6.Location = new Point(3, 193);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 55);
            panel6.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(46, 1);
            label2.Name = "label2";
            label2.Size = new Size(19, 23);
            label2.TabIndex = 0;
            label2.Text = "0";
            label2.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(19, 16);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(45, 45, 45);
            button4.CausesValidation = false;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-41, -18);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(347, 92);
            button4.TabIndex = 22;
            button4.Text = "Notification";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox5);
            panel7.Controls.Add(button5);
            panel7.Location = new Point(3, 254);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 55);
            panel7.TabIndex = 26;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(19, 19);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 26);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(45, 45, 45);
            button5.CausesValidation = false;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-55, -15);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(347, 92);
            button5.TabIndex = 22;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 312);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(207, 407);
            panel5.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Control;
            panel8.Controls.Add(label1);
            panel8.Controls.Add(pictureBox1);
            panel8.Location = new Point(0, 719);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(216, 87);
            panel8.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat-Arabic Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(45, 45, 45);
            label1.Location = new Point(72, 20);
            label1.Name = "label1";
            label1.Size = new Size(75, 32);
            label1.TabIndex = 27;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SidebarTimer
            // 
            SidebarTimer.Interval = 10;
            SidebarTimer.Tick += SidebarTimer_Tick;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.AppWorkspace;
            mainpanel.Location = new Point(210, 34);
            mainpanel.Margin = new Padding(0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(965, 947);
            mainpanel.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 993);
            Controls.Add(SidebarContainer);
            Controls.Add(panel1);
            Controls.Add(mainpanel);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).EndInit();
            SidebarContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox MenuBtn;
        private Label label8;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel SidebarContainer;
        private Button button2;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Button button3;
        private Panel panel6;
        private PictureBox pictureBox4;
        private Button button4;
        private Panel panel7;
        private PictureBox pictureBox5;
        private Button button5;
        private System.Windows.Forms.Timer SidebarTimer;
        private Label label9;
        private Panel mainpanel;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel8;
        private Label label2;
    }
}
