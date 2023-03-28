using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        StudentAccessBLL bllStudent = new StudentAccessBLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvStudents.DataSource = bllStudent.GetStudent().Tables[0];
        }
        public void ClearText()
        {
            txtStudentID.Text = "";
            txtName.Text = "";
            txtClassID.Text = "";
        }
        int position = -1;
        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            if(position == -1)
            {
                MessageBox.Show("No row is selected!");
                return;
            }

            DataRow row = bllStudent.GetStudent().Tables[0].Rows[position];

            // Chuyển giá trị lên form
            txtStudentID.Text = row[0].ToString();
            txtName.Text = row[1].ToString();
            txtClassID.Text = row[2].ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Student st = new Student(txtStudentID.Text, txtName.Text, txtClassID.Text);
            if (bllStudent.InsertStudent(st))
            {
                MessageBox.Show("Insert Successfully!");
                dgvStudents.DataSource = bllStudent.GetStudent().Tables[0];
                ClearText();
            }
            else
            {
                MessageBox.Show("Insert Fail!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student st = new Student(txtStudentID.Text, txtName.Text, txtClassID.Text);
            if (bllStudent.UpdateStudent(st))
            {
                MessageBox.Show("Update Successfully!");
                dgvStudents.DataSource = bllStudent.GetStudent().Tables[0];
                ClearText();
            }
            else
            {
                MessageBox.Show("Update Fail!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student st = new Student(txtStudentID.Text, txtName.Text, txtClassID.Text);
            if (bllStudent.DeleteStudent(st))
            {
                MessageBox.Show("Delete Successfully!");
                dgvStudents.DataSource = bllStudent.GetStudent().Tables[0];
                ClearText();
            }
            else
            {
                MessageBox.Show("Delete Fail!");
            }
        }
    }
}
