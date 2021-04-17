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
    public partial class New_Member : Form
    {
        public New_Member()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = inputFirstName.Text;
            string lastName = inputLastName.Text;

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
            Int64 mobile = Int64.Parse(inputMobile.Text);
            string email = inputEmail.Text;
            string joinDate = dateTimePickerJoinDate.Text;
            string gymTime = comboBoxGymTime.Text;
            string address = inputAddress.Text;
            string membershipTime = comboBoxMembership.Text;


            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = CHAMIKARA\\SQLEXPRESS; databse =gym; integrated security = True";
            con.ConnectionString = "Data Source=CHAMIKARA\\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewMember (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Gymtime,Maddress,MembershipTime) values ('" + firstName + "','" + lastName + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + joinDate + "','" + gymTime + "','" + address + "','" + membershipTime + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputFirstName.Clear();
            inputLastName.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            inputMobile.Clear();
            inputEmail.Clear();
            comboBoxGymTime.ResetText();
            comboBoxMembership.ResetText();

            inputAddress.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;





        }

        private void New_Member_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
