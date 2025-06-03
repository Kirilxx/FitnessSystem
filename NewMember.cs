using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessSystem_project
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String fname = txtFirstName.Text;
            String lname = txtLastName.Text;

            String gender = "";

            bool isChecked = radioButtonMale.Checked;

            if (isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }

            String dob = dateTimePickerDOB.Text;
            Int64 phone = Int64.Parse(txtPhone.Text);
            String email = txtEmail.Text;
            String joindate = dateTimePickerJoinDate.Text;
            String gymtime = ComboBoxGymTime.Text;
            String adress = txtAdress.Text;
            String memberShip = comboBoxMembership.Text;

            string connectionString = "Data Source=localhost\\SQLEXPRESS09;Initial Catalog=FitnessSystem;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO NewMember (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MembershipTime) " +
                              "VALUES (@fname, @lname, @gender, @dob, @mobile, @email, @joindate, @gymtime, @maddress, @membershipTime)";

            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@mobile", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@joindate", joindate);
            cmd.Parameters.AddWithValue("@gymtime", gymtime);
            cmd.Parameters.AddWithValue("@maddress", adress);
            cmd.Parameters.AddWithValue("@membershipTime", memberShip);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Saved");


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();   

            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;

            txtPhone.Clear();
            txtEmail.Clear();

            ComboBoxGymTime.ResetText();
            comboBoxMembership.ResetText();
            txtAdress.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
        }
    }
}
