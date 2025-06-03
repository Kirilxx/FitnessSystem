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
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String fname = txtFnameStaff.Text;
            String lname = txtLnameStaff.Text;

            String gender = "";
            bool isChecked = radioButtonMStaff.Checked;

            if (isChecked)
            {
                gender = radioButtonMStaff.Text;
            }

            else
            {
                gender = radioButtonFStaff.Text;
            }

            String dob = dateTimePickerDOBStaff.Text;
            Int64 phone = Int64.Parse(txtPhoneStaff.Text);
            String email = TxtEmailStaff.Text;
            String joindate = dateTimePickerJoinDateStaff.Text;
            String city = txtCityStaff.Text;

            string connectionString = "Data Source=localhost\\SQLEXPRESS09;Initial Catalog=FitnessSystem;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO NewStaff (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, City) " +
                              "VALUES (@fname, @lname, @gender, @dob, @mobile, @email, @joindate, @city)";

            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@mobile", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@joindate", joindate);
            cmd.Parameters.AddWithValue("@City", city);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Saved");

        }

        private void btnResetStaff_Click(object sender, EventArgs e)
        {
            txtFnameStaff.Clear();
            txtLnameStaff.Clear();
            radioButtonMStaff.Checked = false;
            radioButtonFStaff.Checked = false;
            dateTimePickerDOBStaff.Value = DateTime.Now;
            txtPhoneStaff.Clear();
            TxtEmailStaff.Clear();
            dateTimePickerJoinDateStaff.Value = DateTime.Now;
            txtCityStaff.Clear();

        }
    }
}
