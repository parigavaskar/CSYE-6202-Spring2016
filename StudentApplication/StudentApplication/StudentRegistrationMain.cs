using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApplication
{
    public partial class StudentRegistrationMain : Form
    {
        public List<Student> studentList;
        public StudentRegistrationMain()
        {
            InitializeComponent();
              studentList = new List<Student>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            NewStudent ns = new NewStudent(studentList);
            ns.newStudentAdded += AddStudentOnNewStudentAdded;
            
            ns.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveStudentRegistration rsm = new RemoveStudentRegistration(studentList);
            rsm.newStudentRemoved += RemoveStudentOnStudentRemoved;
            rsm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditStudentRegistration esr = new EditStudentRegistration(studentList);
            esr.newStudentUpdated += UpdateStudentOnStudentUpdated;
            esr.Show();
        }

        private void InformationTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentRegistrationMain_Load(object sender, EventArgs e)
        {
            InformationTable.DataSource = studentList;
        }
        private void AddStudentOnNewStudentAdded(object sender, EventArgs eventArgs)
        {
            var student = eventArgs as Student;
            if (student != null)
            {
                InformationTable.DataSource = null;
                studentList.Add(student);
                InformationTable.DataSource = studentList;
            }
        }

        private void RemoveStudentOnStudentRemoved(object sender, EventArgs eventArgs)
        {
            var student = eventArgs as Student;
            if (student != null)
            {
                InformationTable.DataSource = null;
                studentList.Remove(student);
                InformationTable.DataSource = studentList;
            }
        }

        private void UpdateStudentOnStudentUpdated(object sender, EventArgs eventArgs)
        {
            var student = eventArgs as Student;
            if (student != null)
            {
               // InformationTable.DataSource = null;
                
                InformationTable.DataSource = studentList;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton2.Enabled = false;
        }
    }
}
