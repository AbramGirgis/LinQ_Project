using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQ_Project
{
    public partial class frmLinQ : Form
    {
        public frmLinQ()
        {
            InitializeComponent();
        }

        List<ClassStudent> tabStudents = new List<ClassStudent>();

        private void frmLinQ_Load(object sender, EventArgs e)
        {
            tabStudents.Add(new ClassStudent("Alex", "Fashion", 5));
            tabStudents.Add(new ClassStudent("Maria", "Computer", 80));
            tabStudents.Add(new ClassStudent("Abram", "Fashion", 95));
            tabStudents.Add(new ClassStudent("Julia", "Accounting", 60));
            tabStudents.Add(new ClassStudent("Juan", "Computer", 78));
            tabStudents.Add(new ClassStudent("Nani", "Fashion", 12));
            
            //Fill the combobox with the programs
            var allPrograms = (from element in tabStudents select element.Program).Distinct();

            comboBoxSelect.DisplayMember = "Program";
            comboBoxSelect.DataSource = allPrograms.ToList();


            var Students = (from element in tabStudents select element).ToList();
            dataGridViewResult.DataSource = Students;

        }

        private void comboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var findStudents = from element in tabStudents 
                               where element.Program == comboBoxSelect.SelectedItem.ToString()
                               select element;
            dataGridViewResult.DataSource = findStudents.ToList();
        }
    }
}
