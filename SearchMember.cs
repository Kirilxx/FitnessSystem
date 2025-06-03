using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessSystem_project
{
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }

        private void btnSearchMemb_Click(object sender, EventArgs e)
        {
            if (txtSearchMemb.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=localhost\\SQLEXPRESS09;Initial Catalog=FitnessSystem;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM NewMember WHERE Lname LIKE @lname";
                cmd.Parameters.AddWithValue("@lname", "%" + txtSearchMemb.Text + "%");

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Please enter some letters", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchMember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost\\SQLEXPRESS09;Initial Catalog=FitnessSystem;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM NewMember";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}
