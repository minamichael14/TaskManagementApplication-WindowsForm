namespace TaskManagementSystem.Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            lblName = new Label();
            txtName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnRegister = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Arial", 12F);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(456, 193);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(45, 45, 45);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(454, 223);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 27);
            txtName.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Arial", 12F);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(456, 265);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(45, 45, 45);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(454, 295);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Arial", 12F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(456, 337);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(45, 45, 45);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(454, 367);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 27);
            txtPassword.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.ForestGreen;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(454, 427);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(300, 40);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(bigLabel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Fuchsia;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 636);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(104, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.ForeColor = Color.CornflowerBlue;
            panel2.Location = new Point(454, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 4);
            panel2.TabIndex = 12;
            // 
            // bigLabel2
            // 
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Montserrat-Arabic Black", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.White;
            bigLabel2.Location = new Point(423, 94);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(262, 77);
            bigLabel2.TabIndex = 1;
            bigLabel2.Text = "Register";
            bigLabel2.TextAlign = ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DarkGreen;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.ForestGreen;
            linkLabel1.LinkVisited = true;
            linkLabel1.Location = new Point(612, 499);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 23);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "LOGIN HERE";
            linkLabel1.VisitedLinkColor = Color.LimeGreen;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(490, 501);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 14;
            label1.Text = "Alraedy have account?";
            // 
            // bigLabel1
            // 
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Montserrat-Arabic Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(20, 332);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(349, 163);
            bigLabel1.TabIndex = 8;
            bigLabel1.Text = "TASK MANAGMENT APPLICATION";
            bigLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Register
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(886, 636);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(bigLabel2);
            Controls.Add(panel1);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Registration Form";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private TextBox EmailTxtBox;
        //private MaskedTextBox PasswordTextBox;
        private Label label;
        private Label label2;
        private Label label3;
        private TextBox NametextBox;
        private ReaLTaiizor.Controls.Button button1;
        private Label lblName;
        private TextBox txtName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnRegister;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private LinkLabel linkLabel1;
        private Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}