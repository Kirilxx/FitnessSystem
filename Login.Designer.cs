namespace FitnessSystem_project
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
            panel1 = new Panel();
            btnLogin = new Button();
            label1 = new Label();
            label10 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(800, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 502);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnLogin.Location = new Point(150, 409);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 33);
            btnLogin.TabIndex = 54;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(109, 325);
            label1.Name = "label1";
            label1.Size = new Size(72, 16);
            label1.TabIndex = 52;
            label1.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(109, 253);
            label10.Name = "label10";
            label10.Size = new Size(85, 16);
            label10.TabIndex = 51;
            label10.Text = "User Name";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(109, 344);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(237, 23);
            txtPassword.TabIndex = 50;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(109, 272);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(237, 23);
            txtUserName.TabIndex = 49;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 171);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(841, 610);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label1;
        private Label label10;
        private Button btnLogin;
    }
}