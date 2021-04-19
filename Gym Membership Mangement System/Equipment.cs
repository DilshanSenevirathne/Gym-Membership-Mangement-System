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

namespace Gym_Membership_Mangement_System
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEquipName.Clear();
            txtDescription.Clear();
            txtMuscleUsed.Clear();
            txtCost.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EquipName = txtEquipName.Text;
            string Description = txtDescription.Text;
            string MUsed = txtMuscleUsed.Text;
            string DDate = dateTimePickerDeliveryDate.Text;
            Int64 cost = Int64.Parse(txtCost.Text);


            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = CHAMIKARA\\SQLEXPRESS; databse =gym; integrated security = True";
            con.ConnectionString = "Data Source=CHAMIKARA\\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Equipment (EquipName,EDescription,MUsed,DDate,Cost) values ('" + EquipName + "','" + Description + "','" + MUsed + "','" + DDate + "'," + cost + ")";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved");
        }
    }
}
