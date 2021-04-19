using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Membership_Mangement_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean b = true;
        private void newMember_Click(object sender, EventArgs e)
        {
            if (b== true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                newMember.Image = Image.FromFile(@"C:\Users\Chamikara Mendis\Downloads\arrow-down-sign-to-navigate.png");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                newMember.Image = Image.FromFile(@"C:\Users\Chamikara Mendis\Downloads\right-arrow.png");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newMember.Image = Image.FromFile(@"C:\Users\Chamikara Mendis\Downloads\right-arrow.png");
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Member obj = new New_Member();
            obj.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStaff ns = new NewStaff();
            ns.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();
            sm.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.Show();
        }
    }
}
