namespace FitnessSystem_project
{
    partial class NewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMember));
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            dateTimePickerDOB = new DateTimePicker();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            dateTimePickerJoinDate = new DateTimePicker();
            txtAdress = new RichTextBox();
            comboBoxMembership = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnSave = new Button();
            btnReset = new Button();
            ComboBoxGymTime = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(131, 144);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(137, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(131, 221);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(137, 23);
            txtLastName.TabIndex = 1;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(207, 295);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(63, 19);
            radioButtonFemale.TabIndex = 2;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(131, 295);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(51, 19);
            radioButtonMale.TabIndex = 3;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(150, 357);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(104, 23);
            dateTimePickerDOB.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(131, 424);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(137, 23);
            txtPhone.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(615, 144);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(137, 23);
            txtEmail.TabIndex = 6;
            // 
            // dateTimePickerJoinDate
            // 
            dateTimePickerJoinDate.Format = DateTimePickerFormat.Short;
            dateTimePickerJoinDate.Location = new Point(613, 204);
            dateTimePickerJoinDate.Name = "dateTimePickerJoinDate";
            dateTimePickerJoinDate.Size = new Size(91, 23);
            dateTimePickerJoinDate.TabIndex = 7;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(613, 354);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(174, 131);
            txtAdress.TabIndex = 9;
            txtAdress.Text = "";
            // 
            // comboBoxMembership
            // 
            comboBoxMembership.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBoxMembership.FormattingEnabled = true;
            comboBoxMembership.Items.AddRange(new object[] { "1 Month", "2 Month", "3 Month", "6 Month", "12 Month" });
            comboBoxMembership.Location = new Point(411, 471);
            comboBoxMembership.Name = "comboBoxMembership";
            comboBoxMembership.Size = new Size(144, 27);
            comboBoxMembership.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(36, 147);
            label1.Name = "label1";
            label1.Size = new Size(87, 16);
            label1.TabIndex = 12;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(36, 299);
            label2.Name = "label2";
            label2.Size = new Size(56, 16);
            label2.TabIndex = 13;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(36, 362);
            label3.Name = "label3";
            label3.Size = new Size(99, 16);
            label3.TabIndex = 14;
            label3.Text = "Data of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(36, 427);
            label4.Name = "label4";
            label4.Size = new Size(49, 16);
            label4.TabIndex = 15;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(512, 144);
            label5.Name = "label5";
            label5.Size = new Size(48, 16);
            label5.TabIndex = 16;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(512, 204);
            label6.Name = "label6";
            label6.Size = new Size(73, 16);
            label6.TabIndex = 17;
            label6.Text = "Join Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(512, 266);
            label7.Name = "label7";
            label7.Size = new Size(79, 16);
            label7.TabIndex = 18;
            label7.Text = "Gym Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(512, 327);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.Crimson;
            label9.Location = new Point(512, 354);
            label9.Name = "label9";
            label9.Size = new Size(53, 16);
            label9.TabIndex = 20;
            label9.Text = "Adress";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(30, 221);
            label10.Name = "label10";
            label10.Size = new Size(83, 16);
            label10.TabIndex = 21;
            label10.Text = "Last Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.Crimson;
            label11.Location = new Point(268, 473);
            label11.Name = "label11";
            label11.Size = new Size(131, 16);
            label11.TabIndex = 22;
            label11.Text = "Membership Time";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnSave.Location = new Point(298, 526);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 24);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnReset.Location = new Point(411, 526);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(101, 24);
            btnReset.TabIndex = 24;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // ComboBoxGymTime
            // 
            ComboBoxGymTime.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ComboBoxGymTime.FormattingEnabled = true;
            ComboBoxGymTime.Items.AddRange(new object[] { "6:00-8:00", "8:00-10:00", "18:00-20:00", "20:00-22:00" });
            ComboBoxGymTime.Location = new Point(613, 263);
            ComboBoxGymTime.Name = "ComboBoxGymTime";
            ComboBoxGymTime.Size = new Size(128, 27);
            ComboBoxGymTime.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(321, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 171);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // NewMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 572);
            Controls.Add(pictureBox1);
            Controls.Add(ComboBoxGymTime);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxMembership);
            Controls.Add(txtAdress);
            Controls.Add(dateTimePickerJoinDate);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(radioButtonMale);
            Controls.Add(radioButtonFemale);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            DoubleBuffered = true;
            Name = "NewMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewMember";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private DateTimePicker dateTimePickerDOB;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private DateTimePicker dateTimePickerJoinDate;
        private RichTextBox txtAdress;
        private ComboBox comboBoxMembership;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnSave;
        private Button btnReset;
        private ComboBox ComboBoxGymTime;
        private PictureBox pictureBox1;
    }
}