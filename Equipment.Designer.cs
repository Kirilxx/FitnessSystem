namespace FitnessSystem_project
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            pictureBox1 = new PictureBox();
            label10 = new Label();
            txtEquipName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMusclesUs = new TextBox();
            txtCost = new TextBox();
            dateTimePickerDeliveryDate = new DateTimePicker();
            btnResetEquip = new Button();
            btnSaveEquip = new Button();
            btnViewEquip = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(327, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 171);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(54, 233);
            label10.Name = "label10";
            label10.Size = new Size(127, 16);
            label10.TabIndex = 45;
            label10.Text = "Equipment Name";
            // 
            // txtEquipName
            // 
            txtEquipName.Location = new Point(199, 233);
            txtEquipName.Name = "txtEquipName";
            txtEquipName.Size = new Size(160, 23);
            txtEquipName.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(54, 289);
            label1.Name = "label1";
            label1.Size = new Size(101, 16);
            label1.TabIndex = 47;
            label1.Text = "Muscles Used";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(54, 412);
            label2.Name = "label2";
            label2.Size = new Size(37, 16);
            label2.TabIndex = 48;
            label2.Text = "Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(54, 353);
            label3.Name = "label3";
            label3.Size = new Size(102, 16);
            label3.TabIndex = 49;
            label3.Text = "Delivery Date";
            // 
            // txtMusclesUs
            // 
            txtMusclesUs.Location = new Point(199, 287);
            txtMusclesUs.Name = "txtMusclesUs";
            txtMusclesUs.Size = new Size(160, 23);
            txtMusclesUs.TabIndex = 50;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(199, 405);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(100, 23);
            txtCost.TabIndex = 51;
            // 
            // dateTimePickerDeliveryDate
            // 
            dateTimePickerDeliveryDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDeliveryDate.Location = new Point(199, 346);
            dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            dateTimePickerDeliveryDate.Size = new Size(92, 23);
            dateTimePickerDeliveryDate.TabIndex = 52;
            // 
            // btnResetEquip
            // 
            btnResetEquip.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnResetEquip.Location = new Point(317, 495);
            btnResetEquip.Name = "btnResetEquip";
            btnResetEquip.Size = new Size(101, 33);
            btnResetEquip.TabIndex = 54;
            btnResetEquip.Text = "Reset";
            btnResetEquip.UseVisualStyleBackColor = true;
            btnResetEquip.Click += btnResetEquip_Click;
            // 
            // btnSaveEquip
            // 
            btnSaveEquip.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnSaveEquip.Location = new Point(151, 495);
            btnSaveEquip.Name = "btnSaveEquip";
            btnSaveEquip.Size = new Size(101, 33);
            btnSaveEquip.TabIndex = 53;
            btnSaveEquip.Text = "Save";
            btnSaveEquip.UseVisualStyleBackColor = true;
            btnSaveEquip.Click += btnSaveEquip_Click;
            // 
            // btnViewEquip
            // 
            btnViewEquip.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnViewEquip.Location = new Point(475, 495);
            btnViewEquip.Name = "btnViewEquip";
            btnViewEquip.Size = new Size(145, 33);
            btnViewEquip.TabIndex = 55;
            btnViewEquip.Text = "View Equipment";
            btnViewEquip.UseVisualStyleBackColor = true;
            btnViewEquip.Click += btnViewEquip_Click;
            // 
            // Equipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 572);
            Controls.Add(btnViewEquip);
            Controls.Add(btnResetEquip);
            Controls.Add(btnSaveEquip);
            Controls.Add(dateTimePickerDeliveryDate);
            Controls.Add(txtCost);
            Controls.Add(txtMusclesUs);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEquipName);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Equipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label10;
        private TextBox txtEquipName;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMusclesUs;
        private TextBox txtCost;
        private DateTimePicker dateTimePickerDeliveryDate;
        private Button btnResetEquip;
        private Button btnSaveEquip;
        private Button btnViewEquip;
    }
}