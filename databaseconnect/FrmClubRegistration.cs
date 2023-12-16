using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseconnect
{
    public partial class FrmClubRegistration : Form
    {
        private ClugRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;

        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClugRegistrationQuery();
            RefreshListOfClubMembers();
        }

        public void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView1.DataSource = clubRegistrationQuery.BindingSource;
        }

        public int RegistrationID()
        {
            return count++;
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            //int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program
            clubRegistrationQuery.RegisterStudent(RegistrationID(), int.Parse(sid1.Text), fn1.Text, mn1.Text, ln1.Text, int.Parse(a1.Text), g1.SelectedItem.ToString(), p1.SelectedItem.ToString());
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }
    }
}
