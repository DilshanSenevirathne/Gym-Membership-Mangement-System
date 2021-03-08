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
            con.ConnectionString = "data source = CHAMIKARA\\SQLEXPRESS; databse =gym; integrated security = True";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
