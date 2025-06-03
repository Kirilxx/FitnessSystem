namespace FitnessSystem_project
{
    partial class DeleteMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMember));
            btnDeleteMemb = new Button();
            txtDeleteMemb = new TextBox();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteMemb
            // 
            btnDeleteMemb.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnDeleteMemb.Location = new Point(356, 172);
            btnDeleteMemb.Name = "btnDeleteMemb";
            btnDeleteMemb.Size = new Size(101, 33);
            btnDeleteMemb.TabIndex = 57;
            btnDeleteMemb.Text = "Delete";
            btnDeleteMemb.UseVisualStyleBackColor = true;
            btnDeleteMemb.Click += btnDeleteMemb_Click;
            // 
            // txtDeleteMemb
            // 
            txtDeleteMemb.Location = new Point(388, 126);
            txtDeleteMemb.Name = "txtDeleteMemb";
            txtDeleteMemb.Size = new Size(206, 23);
            txtDeleteMemb.TabIndex = 56;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(243, 126);
            label10.Name = "label10";
            label10.Size = new Size(127, 16);
            label10.TabIndex = 55;
            label10.Text = "Enter Last Name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(720, 302);
            dataGridView1.TabIndex = 58;
            // 
            // DeleteMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 572);
            Controls.Add(dataGridView1);
            Controls.Add(btnDeleteMemb);
            Controls.Add(txtDeleteMemb);
            Controls.Add(label10);
            DoubleBuffered = true;
            Name = "DeleteMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteMember";
            Load += DeleteMember_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteMemb;
        private TextBox txtDeleteMemb;
        private Label label10;
        private DataGridView dataGridView1;
    }
}