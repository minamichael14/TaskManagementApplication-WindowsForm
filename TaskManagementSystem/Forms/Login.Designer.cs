namespace TaskManagementSystem.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            panel2 = new Panel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            panel1 = new Panel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Arial", 12F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(440, 231);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(45, 45, 45);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(440, 261);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 27);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Arial", 12F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(440, 303);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(45, 45, 45);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(440, 333);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.ForestGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(440, 387);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DarkGreen;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.ForestGreen;
            linkLabel1.LinkVisited = true;
            linkLabel1.Location = new Point(582, 461);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(140, 23);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "REGISTER HERE";
            linkLabel1.VisitedLinkColor = Color.LimeGreen;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(460, 463);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 9;
            label1.Text = "Don't have account?";
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.ForeColor = Color.CornflowerBlue;
            panel2.Location = new Point(449, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 4);
            panel2.TabIndex = 10;
            // 
            // bigLabel2
            // 
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Montserrat-Arabic Black", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.White;
            bigLabel2.Location = new Point(425, 90);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(184, 77);
            bigLabel2.TabIndex = 12;
            bigLabel2.Text = "Login";
            bigLabel2.TextAlign = ContentAlignment.TopCenter;
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
            panel1.Size = new Size(377, 592);
            panel1.TabIndex = 13;
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
            // Login
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(808, 592);
            Controls.Add(panel1);
            Controls.Add(bigLabel2);
            Controls.Add(panel2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login Form";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.Button button1;
        private Label label3;
        private Label label2;
        //private MaskedTextBox PasswordTextBox;
        //private TextBox EmailTxtBox;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linkLabel1;
        private Label label1;
        private Panel panel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
    }
}