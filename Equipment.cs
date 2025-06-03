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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace FitnessSystem_project
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void btnSaveEquip_Click(object sender, EventArgs e)
        {
            String EquipName = txtEquipName.Text;
            String MUsed = txtMusclesUs.Text;
            String DDate = dateTimePickerDeliveryDate.Text;
            Int64 cost = Int64.Parse(txtCost.Text);

            string connectionString = "Data Source=localhost\\SQLEXPRESS09;Initial Catalog=FitnessSystem;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO Equipment (EquipName, MUsed, DDate, Cost) " +
                              "VALUES (@EquipName, @MUsed, @DDate, @Cost)";

            cmd.Parameters.AddWithValue("@EquipName", EquipName);
            cmd.Parameters.AddWithValue("@MUsed", MUsed);
            cmd.Parameters.AddWithValue("@DDate", DDate);
            cmd.Parameters.AddWithValue("@Cost", cost);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Saved", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnResetEquip_Click(object sender, EventArgs e)
        {
            txtEquipName.Clear();
            txtMusclesUs.Clear();
            txtCost.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;
        }

        private void btnViewEquip_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }
    }
}
