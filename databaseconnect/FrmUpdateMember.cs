using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseconnect
{
    public partial class FrmUpdateMember : Form
    {

        private SqlConnection sqlConnection = new SqlConnection();
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;

        public DataTable dataTable;
        public BindingSource BindingSource;
        private string connectionString;
        ClugRegistrationQuery clugRegistrationQuery = new ClugRegistrationQuery();
        public FrmUpdateMember()
        {
            InitializeComponent();
            clugRegistrationQuery = new ClugRegistrationQuery();
            connectionString = "Data Source=DESKTOP-09ORH5O\\MSSQLSERVER01;Initial Catalog=ClubDB;Integrated Security=True;Pooling=False";
            sqlConnection = new SqlConnection(connectionString);
            BindingSource = new BindingSource();
            dataTable = new DataTable();
        }

        private void sid2_SelectedIndexChanged(object sender, EventArgs e)
        {


            //long studentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program

        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            loadSidoncmb();

        }
        public bool loadSidoncmb()
        {
            sqlAdapter = new SqlDataAdapter("SELECT StudentId FROM ClubMembers", sqlConnection);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            sid2.DataSource = dataTable;
            sid2.DisplayMember = "ClubMembers";
            sid2.ValueMember = "StudentId";
            return true;
        }
        public bool displayStudent()
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers WHERE StudentID = '" + sid2.Text + "'", sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                fn2.Text = reader.GetValue(0).ToString();
                mn2.Text = reader.GetValue(1).ToString();
                ln2.Text = reader.GetValue(2).ToString();
                a2.Text = reader.GetValue(3).ToString();
                gender2.Text = reader.GetValue(4).ToString();
                prog2.Text = reader.GetValue(5).ToString();
            }

            // sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return true;
        }

        private void sid2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            displayStudent();
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            //long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program
            clugRegistrationQuery.updateStudent(int.Parse(sid2.Text), fn2.Text, mn2.Text,ln2.Text,int.Parse(a2.Text),gender2.Text,prog2.Text);
            MessageBox.Show("Succesfully Updated!");
        }
    }
}
