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
    public partial class NewStudent : Form
    {
        List<Student> studentList;
        public event EventHandler newStudentAdded;


        public NewStudent(List<Student> studentList)
        {
            InitializeComponent();
            this.studentList = studentList;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String studentID = textBox1.Text;
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            string department = comboBox1.Text;
            String enrollmentType;

          
            if (radioButton1.Checked)
            {
                enrollmentType = "fullTime";
            }
            else enrollmentType = "partTime";
            if (studentID.Trim().Equals("") || firstName.Trim().Equals("") || lastName.Trim().Equals("") || comboBox1.SelectedItem.Equals(null))
            {
                MessageBox.Show("Please enter all values");
            }
            Student s = new Student(studentID, firstName, lastName, department, enrollmentType);
            //studentList.Add(s);
            newStudentAdded(this, s);
           // newList();
            
            this.Close();

            
        }
        public List<Student> newList()
        {
            return studentList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            comboBox1.SelectedIndex = 0;
        }
    }
}
