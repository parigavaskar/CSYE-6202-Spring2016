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
    public partial class EditStudentRegistration : Form
    {
        public event EventHandler newStudentUpdated;
        List<Student> studentList;
        public EditStudentRegistration(List<Student>  studentList)
        {
            InitializeComponent();
            this.studentList = studentList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim().Equals("") || textBox2.Text.Trim().Equals("") || textBox3.Text.Trim().Equals("") || comboBox1.SelectedItem.Equals(null))
            {
                MessageBox.Show("Please enter all values");
                return;
            }
            DialogResult dr = MessageBox.Show("Are you sure you want to update this student?");
            if (dr == DialogResult.Yes)
            {
                foreach (Student s in studentList)
                {
                    if (textBox1.Text.Equals(s.studentID))
                    {
                        s.studentID = textBox1.Text;
                        s.firstName = textBox2.Text;
                        s.lastName = textBox3.Text;
                        s.department = (String)comboBox1.SelectedItem;
                        if (radioButton1.Checked)
                        {
                            s.enrollmentType = "fullTime";
                        }
                        if (radioButton2.Checked)
                        {
                            s.enrollmentType = "partTime";
                        }
                        newStudentUpdated(this, s);
                    }

                }


            }
            else this.Close();
            updatedList();

        }

        public List<Student> updatedList()
        {
            return studentList;
        }
           
        }
        
    }

