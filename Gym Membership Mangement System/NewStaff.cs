using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gym_Membership_Mangement_System
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = txtFname.Text;
            string lname = txtLname.Text;

            string gender = "";
            bool isChecked = radioButton1.Checked;

            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            string dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            string joinDate = dateTimePickerJOINDate.Text;
            string state = txtState.Text;
            string city = txtCity.Text;
            string email = txtEmail.Text;

            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = CHAMIKARA\\SQLEXPRESS; databse =gym; integrated security = True";
            con.ConnectionString = "Data Source=CHAMIKARA\\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewStaff (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Statee,City) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "'," + mobile + ", '"+email+"', '"  + joinDate + "','" + state + "','" + city + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            txtState.Clear();
            txtCity.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJOINDate.Value = DateTime.Now;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewStaff vs = new ViewStaff();
            vs.Show();
        }
    }
}
