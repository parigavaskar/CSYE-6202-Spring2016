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
    public partial class RemoveStudentRegistration : Form
    {
        public event EventHandler newStudentRemoved;
        List<Student> studentList;
        public RemoveStudentRegistration(List<Student> studentList)
        {
            InitializeComponent();
            this.studentList = studentList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            
           DialogResult dr= MessageBox.Show("Are you sure you want to remove this student?");
            if (dr == DialogResult.Yes)
            {
                foreach (Student s in studentList)
                {
                    if (ID.Equals(s.studentID))
                    {
                        newStudentRemoved(this, s);
                    }
                   
                }
               // removeList();
                
            }
            if (dr == DialogResult.No)
            {
                this.Close();
            }
        }

        public List<Student> removeList()
        {
            return studentList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
