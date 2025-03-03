namespace TaskManagementSystem.Custom_Control
{
    partial class TaskControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskControl));
            panel1 = new Panel();
            label1 = new Label();
            IDTxt = new TextBox();
            Deletebutton = new Button();
            Editbutton = new Button();
            panel3 = new Panel();
            CategoryLabel = new Label();
            DateLabel = new Label();
            StatusLabel = new Label();
            Titlelabel = new Label();
            panel2 = new Panel();
            DescLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(IDTxt);
            panel1.Controls.Add(Deletebutton);
            panel1.Controls.Add(Editbutton);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(CategoryLabel);
            panel1.Controls.Add(DateLabel);
            panel1.Controls.Add(StatusLabel);
            panel1.Controls.Add(Titlelabel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(DescLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 138);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(103, 37);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(30, 30);
            label1.TabIndex = 11;
            label1.Text = "H";
            // 
            // IDTxt
            // 
            IDTxt.Location = new Point(483, 20);
            IDTxt.Name = "IDTxt";
            IDTxt.Size = new Size(125, 27);
            IDTxt.TabIndex = 10;
            IDTxt.Visible = false;
            // 
            // Deletebutton
            // 
            Deletebutton.BackColor = Color.Crimson;
            Deletebutton.ForeColor = SystemColors.ButtonHighlight;
            Deletebutton.Location = new Point(591, 51);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(94, 52);
            Deletebutton.TabIndex = 9;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = false;
            Deletebutton.Click += Deletebutton_ClickAsync;
            // 
            // Editbutton
            // 
            Editbutton.BackColor = Color.SteelBlue;
            Editbutton.ForeColor = SystemColors.ButtonHighlight;
            Editbutton.Location = new Point(491, 51);
            Editbutton.Name = "Editbutton";
            Editbutton.Size = new Size(94, 52);
            Editbutton.TabIndex = 8;
            Editbutton.Text = "Edit";
            Editbutton.UseVisualStyleBackColor = false;
            Editbutton.Click += Editbutton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(1, 186);
            panel3.Name = "panel3";
            panel3.Size = new Size(649, 3);
            panel3.TabIndex = 6;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoEllipsis = true;
            CategoryLabel.AutoSize = true;
            CategoryLabel.BackColor = Color.Goldenrod;
            CategoryLabel.BorderStyle = BorderStyle.FixedSingle;
            CategoryLabel.FlatStyle = FlatStyle.Popup;
            CategoryLabel.ForeColor = SystemColors.ButtonHighlight;
            CategoryLabel.Location = new Point(16, 80);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Padding = new Padding(5);
            CategoryLabel.Size = new Size(81, 32);
            CategoryLabel.TabIndex = 5;
            CategoryLabel.Text = "Category";
            // 
            // DateLabel
            // 
            DateLabel.Font = new Font("AGA Aladdin Regular", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            DateLabel.ForeColor = Color.Maroon;
            DateLabel.Location = new Point(14, 12);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(137, 25);
            DateLabel.TabIndex = 4;
            DateLabel.Text = "Due Date";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoEllipsis = true;
            StatusLabel.AutoSize = true;
            StatusLabel.BackColor = Color.Brown;
            StatusLabel.ForeColor = SystemColors.ButtonHighlight;
            StatusLabel.Location = new Point(16, 36);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new Padding(5);
            StatusLabel.Size = new Size(72, 30);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Pending";
            // 
            // Titlelabel
            // 
            Titlelabel.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titlelabel.Location = new Point(158, 6);
            Titlelabel.Name = "Titlelabel";
            Titlelabel.Size = new Size(285, 38);
            Titlelabel.TabIndex = 1;
            Titlelabel.Text = "Title";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.ForeColor = SystemColors.GrayText;
            panel2.Location = new Point(-6, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(716, 9);
            panel2.TabIndex = 0;
            // 
            // DescLabel
            // 
            DescLabel.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescLabel.Location = new Point(161, 50);
            DescLabel.Name = "DescLabel";
            DescLabel.Size = new Size(319, 88);
            DescLabel.TabIndex = 2;
            DescLabel.Text = resources.GetString("DescLabel.Text");
            // 
            // TaskControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "TaskControl";
            Size = new Size(699, 138);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label DescLabel;
        private Label Titlelabel;
        private Label StatusLabel;
        private Label DateLabel;
        private Label CategoryLabel;
        private Panel panel3;
        private Panel panel2;
        private Button Deletebutton;
        private Button Editbutton;
        private TextBox IDTxt;
        private Label label1;
    }
}
