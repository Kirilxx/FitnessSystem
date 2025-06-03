using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessSystem_project
{
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void btnDeleteMemb_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS09;Initial Catalog=FitnessSystem;Integrated Security=True"))
            {
                con.Open();

                if (MessageBox.Show("This will delete your data. Confirm?", "Delete data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("DELETE FROM NewMember WHERE Lname LIKE @lname", con);
                    cmd.Parameters.AddWithValue("@lname", "%" + txtDeleteMemb.Text + "%");

                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected + " record(s) deleted.");
                }

                SqlCommand refreshCmd = new SqlCommand("SELECT * FROM NewMember", con);
                SqlDataAdapter DA = new SqlDataAdapter(refreshCmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

            }


        }

        private void DeleteMember_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS09;Initial Catalog=FitnessSystem;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NewMember", con);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
         

            
        }
    }
}
