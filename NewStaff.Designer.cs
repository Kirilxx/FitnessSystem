namespace FitnessSystem_project
{
    partial class NewStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStaff));
            pictureBox1 = new PictureBox();
            txtFnameStaff = new TextBox();
            txtLnameStaff = new TextBox();
            radioButtonMStaff = new RadioButton();
            radioButtonFStaff = new RadioButton();
            dateTimePickerDOBStaff = new DateTimePicker();
            txtPhoneStaff = new TextBox();
            TxtEmailStaff = new TextBox();
            dateTimePickerJoinDateStaff = new DateTimePicker();
            txtCityStaff = new TextBox();
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            btnResetStaff = new Button();
            btnSaveStaff = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(320, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 171);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // txtFnameStaff
            // 
            txtFnameStaff.Location = new Point(147, 224);
            txtFnameStaff.Name = "txtFnameStaff";
            txtFnameStaff.Size = new Size(100, 23);
            txtFnameStaff.TabIndex = 28;
            // 
            // txtLnameStaff
            // 
            txtLnameStaff.Location = new Point(147, 298);
            txtLnameStaff.Name = "txtLnameStaff";
            txtLnameStaff.Size = new Size(100, 23);
            txtLnameStaff.TabIndex = 29;
            // 
            // radioButtonMStaff
            // 
            radioButtonMStaff.AutoSize = true;
            radioButtonMStaff.Location = new Point(147, 375);
            radioButtonMStaff.Name = "radioButtonMStaff";
            radioButtonMStaff.Size = new Size(51, 19);
            radioButtonMStaff.TabIndex = 30;
            radioButtonMStaff.TabStop = true;
            radioButtonMStaff.Text = "Male";
            radioButtonMStaff.UseVisualStyleBackColor = true;
            // 
            // radioButtonFStaff
            // 
            radioButtonFStaff.AutoSize = true;
            radioButtonFStaff.Location = new Point(233, 375);
            radioButtonFStaff.Name = "radioButtonFStaff";
            radioButtonFStaff.Size = new Size(63, 19);
            radioButtonFStaff.TabIndex = 31;
            radioButtonFStaff.TabStop = true;
            radioButtonFStaff.Text = "Female";
            radioButtonFStaff.UseVisualStyleBackColor = true;
            radioButtonFStaff.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // dateTimePickerDOBStaff
            // 
            dateTimePickerDOBStaff.Format = DateTimePickerFormat.Short;
            dateTimePickerDOBStaff.Location = new Point(148, 436);
            dateTimePickerDOBStaff.Name = "dateTimePickerDOBStaff";
            dateTimePickerDOBStaff.Size = new Size(99, 23);
            dateTimePickerDOBStaff.TabIndex = 32;
            // 
            // txtPhoneStaff
            // 
            txtPhoneStaff.Location = new Point(147, 499);
            txtPhoneStaff.Name = "txtPhoneStaff";
            txtPhoneStaff.Size = new Size(100, 23);
            txtPhoneStaff.TabIndex = 33;
            // 
            // TxtEmailStaff
            // 
            TxtEmailStaff.Location = new Point(603, 221);
            TxtEmailStaff.Name = "TxtEmailStaff";
            TxtEmailStaff.Size = new Size(100, 23);
            TxtEmailStaff.TabIndex = 34;
            // 
            // dateTimePickerJoinDateStaff
            // 
            dateTimePickerJoinDateStaff.Format = DateTimePickerFormat.Short;
            dateTimePickerJoinDateStaff.Location = new Point(603, 283);
            dateTimePickerJoinDateStaff.Name = "dateTimePickerJoinDateStaff";
            dateTimePickerJoinDateStaff.Size = new Size(90, 23);
            dateTimePickerJoinDateStaff.TabIndex = 35;
            // 
            // txtCityStaff
            // 
            txtCityStaff.Location = new Point(603, 336);
            txtCityStaff.Name = "txtCityStaff";
            txtCityStaff.Size = new Size(100, 23);
            txtCityStaff.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(22, 300);
            label10.Name = "label10";
            label10.Size = new Size(83, 16);
            label10.TabIndex = 44;
            label10.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(504, 283);
            label6.Name = "label6";
            label6.Size = new Size(73, 16);
            label6.TabIndex = 43;
            label6.Text = "Join Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(504, 223);
            label5.Name = "label5";
            label5.Size = new Size(48, 16);
            label5.TabIndex = 42;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(28, 506);
            label4.Name = "label4";
            label4.Size = new Size(49, 16);
            label4.TabIndex = 41;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(28, 441);
            label3.Name = "label3";
            label3.Size = new Size(99, 16);
            label3.TabIndex = 40;
            label3.Text = "Data of Birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(28, 378);
            label2.Name = "label2";
            label2.Size = new Size(56, 16);
            label2.TabIndex = 39;
            label2.Text = "Gender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(28, 226);
            label1.Name = "label1";
            label1.Size = new Size(87, 16);
            label1.TabIndex = 38;
            label1.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(504, 343);
            label8.Name = "label8";
            label8.Size = new Size(36, 16);
            label8.TabIndex = 46;
            label8.Text = "City";
            label8.Click += label8_Click;
            // 
            // btnResetStaff
            // 
            btnResetStaff.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnResetStaff.Location = new Point(559, 477);
            btnResetStaff.Name = "btnResetStaff";
            btnResetStaff.Size = new Size(101, 24);
            btnResetStaff.TabIndex = 49;
            btnResetStaff.Text = "Reset";
            btnResetStaff.UseVisualStyleBackColor = true;
            btnResetStaff.Click += btnResetStaff_Click;
            // 
            // btnSaveStaff
            // 
            btnSaveStaff.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnSaveStaff.Location = new Point(452, 477);
            btnSaveStaff.Name = "btnSaveStaff";
            btnSaveStaff.Size = new Size(101, 24);
            btnSaveStaff.TabIndex = 48;
            btnSaveStaff.Text = "Save";
            btnSaveStaff.UseVisualStyleBackColor = true;
            btnSaveStaff.Click += btnSave_Click;
            // 
            // NewStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 572);
            Controls.Add(btnResetStaff);
            Controls.Add(btnSaveStaff);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCityStaff);
            Controls.Add(dateTimePickerJoinDateStaff);
            Controls.Add(TxtEmailStaff);
            Controls.Add(txtPhoneStaff);
            Controls.Add(dateTimePickerDOBStaff);
            Controls.Add(radioButtonFStaff);
            Controls.Add(radioButtonMStaff);
            Controls.Add(txtLnameStaff);
            Controls.Add(txtFnameStaff);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "NewStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewStaff";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtFnameStaff;
        private TextBox txtLnameStaff;
        private RadioButton radioButtonMStaff;
        private RadioButton radioButtonFStaff;
        private DateTimePicker dateTimePickerDOBStaff;
        private TextBox txtPhoneStaff;
        private TextBox TxtEmailStaff;
        private DateTimePicker dateTimePickerJoinDateStaff;
        private TextBox txtCityStaff;
        private Label label10;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Button btnResetStaff;
        private Button btnSaveStaff;
    }
}