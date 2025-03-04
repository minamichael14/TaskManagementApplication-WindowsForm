namespace TaskManagementSystem.Forms
{
    partial class TaskVW
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            aloneTextBox1 = new ReaLTaiizor.Controls.AloneTextBox();
            aloneButton2 = new ReaLTaiizor.Controls.AloneButton();
            parrotSuperButton1 = new ReaLTaiizor.Controls.ParrotSuperButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            previousTag = new Label();
            NextTag = new Label();
            beforeNumLabel = new Label();
            CurrentNumLabel = new Label();
            afterNumLabel = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            panel2 = new Panel();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            label1 = new Label();
            notification1 = new Custom_Control.Notification();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Montserrat-Arabic Black", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(28, 28);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(152, 68);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Tasks";
            // 
            // aloneTextBox1
            // 
            aloneTextBox1.BackColor = Color.Transparent;
            aloneTextBox1.BackgroundImageLayout = ImageLayout.None;
            aloneTextBox1.EnabledCalc = true;
            aloneTextBox1.Font = new Font("Segoe UI", 9F);
            aloneTextBox1.ForeColor = Color.FromArgb(124, 133, 142);
            aloneTextBox1.Location = new Point(25, 108);
            aloneTextBox1.MaxLength = 32767;
            aloneTextBox1.MultiLine = false;
            aloneTextBox1.Name = "aloneTextBox1";
            aloneTextBox1.ReadOnly = false;
            aloneTextBox1.Size = new Size(297, 36);
            aloneTextBox1.TabIndex = 1;
            aloneTextBox1.Text = "Search";
            aloneTextBox1.TextAlign = HorizontalAlignment.Left;
            aloneTextBox1.UseSystemPasswordChar = false;
            // 
            // aloneButton2
            // 
            aloneButton2.BackColor = Color.Transparent;
            aloneButton2.EnabledCalc = true;
            aloneButton2.Font = new Font("Segoe UI", 9F);
            aloneButton2.ForeColor = Color.FromArgb(124, 133, 142);
            aloneButton2.Location = new Point(340, 107);
            aloneButton2.Name = "aloneButton2";
            aloneButton2.Size = new Size(56, 36);
            aloneButton2.TabIndex = 6;
            aloneButton2.Text = "Search";
            aloneButton2.Click += aloneButton2_Click;
            // 
            // parrotSuperButton1
            // 
            parrotSuperButton1.BackgroundColor = Color.FromArgb(80, 172, 76);
            parrotSuperButton1.ButtonImage = null;
            parrotSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            parrotSuperButton1.ButtonStyle = ReaLTaiizor.Controls.ParrotSuperButton.Style.RoundedEdges;
            parrotSuperButton1.ButtonText = "Add Task";
            parrotSuperButton1.CornerRadius = 5;
            parrotSuperButton1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotSuperButton1.Horizontal_Alignment = StringAlignment.Center;
            parrotSuperButton1.HoverBackgroundColor = Color.FromArgb(80, 200, 76);
            parrotSuperButton1.HoverTextColor = Color.White;
            parrotSuperButton1.ImagePosition = ReaLTaiizor.Controls.ParrotSuperButton.ImgPosition.Left;
            parrotSuperButton1.Location = new Point(791, 93);
            parrotSuperButton1.Name = "parrotSuperButton1";
            parrotSuperButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotSuperButton1.SelectedBackColor = Color.LimeGreen;
            parrotSuperButton1.SelectedTextColor = Color.White;
            parrotSuperButton1.Size = new Size(147, 50);
            parrotSuperButton1.SuperSelected = false;
            parrotSuperButton1.TabIndex = 17;
            parrotSuperButton1.TextColor = Color.White;
            parrotSuperButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotSuperButton1.Vertical_Alignment = StringAlignment.Center;
            parrotSuperButton1.Click += parrotSuperButton1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Controls.Add(bigLabel2);
            flowLayoutPanel1.Location = new Point(226, 162);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(715, 584);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Dock = DockStyle.Fill;
            bigLabel2.Font = new Font("Segoe UI", 25F);
            bigLabel2.ForeColor = Color.Brown;
            bigLabel2.Location = new Point(8, 5);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(229, 57);
            bigLabel2.TabIndex = 0;
            bigLabel2.Text = "Loading......";
            bigLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // previousTag
            // 
            previousTag.AutoSize = true;
            previousTag.Font = new Font("Montserrat-Arabic Black", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            previousTag.ForeColor = SystemColors.ActiveCaptionText;
            previousTag.Location = new Point(402, 776);
            previousTag.Name = "previousTag";
            previousTag.Size = new Size(44, 60);
            previousTag.TabIndex = 20;
            previousTag.Text = "<";
            previousTag.Click += previousTag_Click;
            // 
            // NextTag
            // 
            NextTag.AutoSize = true;
            NextTag.Font = new Font("Montserrat-Arabic Black", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextTag.ForeColor = SystemColors.ActiveCaptionText;
            NextTag.Location = new Point(596, 778);
            NextTag.Name = "NextTag";
            NextTag.Size = new Size(44, 60);
            NextTag.TabIndex = 21;
            NextTag.Text = ">";
            NextTag.Click += NextTag_Click;
            // 
            // beforeNumLabel
            // 
            beforeNumLabel.AutoSize = true;
            beforeNumLabel.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            beforeNumLabel.ForeColor = SystemColors.ActiveCaptionText;
            beforeNumLabel.Location = new Point(452, 789);
            beforeNumLabel.Name = "beforeNumLabel";
            beforeNumLabel.Size = new Size(0, 31);
            beforeNumLabel.TabIndex = 22;
            // 
            // CurrentNumLabel
            // 
            CurrentNumLabel.AutoSize = true;
            CurrentNumLabel.Font = new Font("Montserrat-Arabic Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CurrentNumLabel.ForeColor = Color.LimeGreen;
            CurrentNumLabel.Location = new Point(501, 772);
            CurrentNumLabel.Name = "CurrentNumLabel";
            CurrentNumLabel.Size = new Size(33, 48);
            CurrentNumLabel.TabIndex = 23;
            CurrentNumLabel.Text = "1";
            // 
            // afterNumLabel
            // 
            afterNumLabel.AutoSize = true;
            afterNumLabel.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            afterNumLabel.ForeColor = SystemColors.ActiveCaptionText;
            afterNumLabel.Location = new Point(560, 789);
            afterNumLabel.Name = "afterNumLabel";
            afterNumLabel.Size = new Size(30, 31);
            afterNumLabel.TabIndex = 24;
            afterNumLabel.Text = "2";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(24, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 584);
            panel1.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.Controls.Add(radioButton1);
            panel3.Controls.Add(radioButton2);
            panel3.Location = new Point(15, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(138, 97);
            panel3.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.ActiveCaptionText;
            radioButton1.Location = new Point(6, 11);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(89, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "DueDate";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ActiveCaptionText;
            radioButton2.Location = new Point(6, 43);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 24);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Priority";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat-Arabic", 9.799999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(15, 203);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 4;
            label3.Text = "Sort By:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(15, 190);
            panel2.Name = "panel2";
            panel2.Size = new Size(152, 3);
            panel2.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.ScrollBar;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Pending", "InProgress", "Completed" });
            checkedListBox1.Location = new Point(64, 59);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(103, 114);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat-Arabic SemiBold", 8.799999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(3, 54);
            label2.Name = "label2";
            label2.Size = new Size(62, 24);
            label2.TabIndex = 1;
            label2.Text = "Status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat-Arabic", 9.799999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 0;
            label1.Text = "Filter By:";
            // 
            // notification1
            // 
            notification1.BackColor = Color.Transparent;
            notification1.Location = new Point(758, 756);
            notification1.Margin = new Padding(0);
            notification1.Name = "notification1";
            notification1.Size = new Size(270, 90);
            notification1.TabIndex = 28;
            notification1.Visible = false;
            // 
            // TaskVW
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 931);
            Controls.Add(notification1);
            Controls.Add(panel1);
            Controls.Add(afterNumLabel);
            Controls.Add(CurrentNumLabel);
            Controls.Add(beforeNumLabel);
            Controls.Add(NextTag);
            Controls.Add(previousTag);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(parrotSuperButton1);
            Controls.Add(aloneButton2);
            Controls.Add(aloneTextBox1);
            Controls.Add(bigLabel1);
            ForeColor = Color.ForestGreen;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaskVW";
            Text = "Taask";
            Load += TaskVW_LoadAsync;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox1;
        private ReaLTaiizor.Controls.AloneButton aloneButton2;
        private ReaLTaiizor.Controls.ParrotSuperButton parrotSuperButton1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label previousTag;
        private Label NextTag;
        private Label beforeNumLabel;
        private Label CurrentNumLabel;
        private Label afterNumLabel;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private Panel panel3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private Custom_Control.Notification notification1;
    }
}