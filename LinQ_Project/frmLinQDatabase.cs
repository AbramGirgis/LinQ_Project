using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// To connect to anydatabase relational or not XML, SQL,...
using System.Data.OleDb;

namespace LinQ_Project
{
    public partial class frmLinQDatabase : Form
    {
        public frmLinQDatabase()
        {
            InitializeComponent();
        }

        // We use dataset to store many dataTables in one single collection
        // it is the place where all the data taken from the DB is sent to
        DataSet myset = new DataSet();

        private void frmLinQDatabase_Load(object sender, EventArgs e)
        {
            OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Abram\source\repos\LinQ_Project\LinQ_Project\bin\Debug\Data\School.mdb");
            myCon.Open();
            OleDbCommand myCmd = new OleDbCommand("SELECT * FROM Courses", myCon);
            OleDbDataAdapter adpCourses = new OleDbDataAdapter(myCmd);
            adpCourses.Fill(myset, "Courses");

            OleDbCommand mycmd2 = new OleDbCommand("SELECT * FROM Students", myCon);
            OleDbDataAdapter adpStudents = new OleDbDataAdapter(mycmd2);
            adpStudents.Fill(myset, "Students");

            dataGridViewResultCourse.DataSource = myset.Tables["Students"];
            //dataGridViewResultCourse.DataSource = myset.Tables["Courses"];


            //Now will use the LinQ

            //fill the combobox
            var CourseTR = from DataRow cr in myset.Tables["Courses"].Rows
                           select new { Titles = cr.Field<string>("Title"), refC = cr.Field<Int32>("RefCourse") };
            comboBoxCourses.DisplayMember = "Titles";
            comboBoxCourses.ValueMember = "refC";
            comboBoxCourses.DataSource = CourseTR.ToList();



        }
    }
}
