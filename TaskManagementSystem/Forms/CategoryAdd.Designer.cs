namespace TaskManagementSystem.Forms
{
    partial class CategoryAdd
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
            parrotSuperButton2 = new ReaLTaiizor.Controls.ParrotSuperButton();
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label5 = new Label();
            parrotSuperButton1 = new ReaLTaiizor.Controls.ParrotSuperButton();
            label1 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // parrotSuperButton2
            // 
            parrotSuperButton2.BackgroundColor = Color.DarkRed;
            parrotSuperButton2.ButtonImage = null;
            parrotSuperButton2.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            parrotSuperButton2.ButtonStyle = ReaLTaiizor.Controls.ParrotSuperButton.Style.RoundedEdges;
            parrotSuperButton2.ButtonText = "Cancel";
            parrotSuperButton2.CornerRadius = 5;
            parrotSuperButton2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotSuperButton2.Horizontal_Alignment = StringAlignment.Center;
            parrotSuperButton2.HoverBackgroundColor = Color.Firebrick;
            parrotSuperButton2.HoverTextColor = Color.White;
            parrotSuperButton2.ImagePosition = ReaLTaiizor.Controls.ParrotSuperButton.ImgPosition.Left;
            parrotSuperButton2.Location = new Point(330, 189);
            parrotSuperButton2.Name = "parrotSuperButton2";
            parrotSuperButton2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotSuperButton2.SelectedBackColor = Color.Firebrick;
            parrotSuperButton2.SelectedTextColor = Color.White;
            parrotSuperButton2.Size = new Size(94, 50);
            parrotSuperButton2.SuperSelected = false;
            parrotSuperButton2.TabIndex = 49;
            parrotSuperButton2.TextColor = Color.White;
            parrotSuperButton2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotSuperButton2.Vertical_Alignment = StringAlignment.Center;
            parrotSuperButton2.Click += parrotSuperButton2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 42);
            panel1.TabIndex = 44;
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
            nightControlBox1.Location = new Point(330, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat-Arabic Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(17, 5);
            label5.Name = "label5";
            label5.Size = new Size(205, 32);
            label5.TabIndex = 1;
            label5.Text = "Task Management";
            // 
            // parrotSuperButton1
            // 
            parrotSuperButton1.BackgroundColor = Color.FromArgb(80, 172, 76);
            parrotSuperButton1.ButtonImage = null;
            parrotSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            parrotSuperButton1.ButtonStyle = ReaLTaiizor.Controls.ParrotSuperButton.Style.RoundedEdges;
            parrotSuperButton1.ButtonText = "Add Category";
            parrotSuperButton1.CornerRadius = 5;
            parrotSuperButton1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotSuperButton1.Horizontal_Alignment = StringAlignment.Center;
            parrotSuperButton1.HoverBackgroundColor = Color.FromArgb(80, 200, 76);
            parrotSuperButton1.HoverTextColor = Color.White;
            parrotSuperButton1.ImagePosition = ReaLTaiizor.Controls.ParrotSuperButton.ImgPosition.Left;
            parrotSuperButton1.Location = new Point(170, 189);
            parrotSuperButton1.Name = "parrotSuperButton1";
            parrotSuperButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotSuperButton1.SelectedBackColor = Color.LimeGreen;
            parrotSuperButton1.SelectedTextColor = Color.White;
            parrotSuperButton1.Size = new Size(143, 50);
            parrotSuperButton1.SuperSelected = false;
            parrotSuperButton1.TabIndex = 48;
            parrotSuperButton1.TextColor = Color.White;
            parrotSuperButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotSuperButton1.Vertical_Alignment = StringAlignment.Center;
            parrotSuperButton1.Click += parrotSuperButton1_ClickAsync;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat-Arabic Black", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 45, 45);
            label1.Location = new Point(72, 59);
            label1.Name = "label1";
            label1.Size = new Size(268, 55);
            label1.TabIndex = 47;
            label1.Text = "Add Category";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(298, 27);
            textBox2.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F);
            label8.ForeColor = Color.FromArgb(45, 45, 45);
            label8.Location = new Point(20, 149);
            label8.Name = "label8";
            label8.Size = new Size(83, 21);
            label8.TabIndex = 46;
            label8.Text = "Category";
            // 
            // CategoryAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(469, 300);
            Controls.Add(parrotSuperButton2);
            Controls.Add(panel1);
            Controls.Add(parrotSuperButton1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryAdd";
            Text = "CategoryAdd";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotSuperButton parrotSuperButton2;
        private Panel panel1;
        private Label label5;
        private ReaLTaiizor.Controls.ParrotSuperButton parrotSuperButton1;
        private Label label1;
        private TextBox textBox2;
        private Label label8;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}