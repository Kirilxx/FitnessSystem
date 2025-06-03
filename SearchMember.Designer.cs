namespace FitnessSystem_project
{
    partial class SearchMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMember));
            txtSearchMemb = new TextBox();
            label10 = new Label();
            btnSearchMemb = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSearchMemb
            // 
            txtSearchMemb.Location = new Point(379, 127);
            txtSearchMemb.Name = "txtSearchMemb";
            txtSearchMemb.Size = new Size(206, 23);
            txtSearchMemb.TabIndex = 48;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(234, 127);
            label10.Name = "label10";
            label10.Size = new Size(127, 16);
            label10.TabIndex = 47;
            label10.Text = "Enter Last Name";
            // 
            // btnSearchMemb
            // 
            btnSearchMemb.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnSearchMemb.Location = new Point(347, 173);
            btnSearchMemb.Name = "btnSearchMemb";
            btnSearchMemb.Size = new Size(101, 33);
            btnSearchMemb.TabIndex = 54;
            btnSearchMemb.Text = "Search";
            btnSearchMemb.UseVisualStyleBackColor = true;
            btnSearchMemb.Click += btnSearchMemb_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(720, 302);
            dataGridView1.TabIndex = 55;
            // 
            // SearchMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 572);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearchMemb);
            Controls.Add(txtSearchMemb);
            Controls.Add(label10);
            DoubleBuffered = true;
            Name = "SearchMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchMember";
            Load += SearchMember_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchMemb;
        private Label label10;
        private Button btnSearchMemb;
        private DataGridView dataGridView1;
    }
}