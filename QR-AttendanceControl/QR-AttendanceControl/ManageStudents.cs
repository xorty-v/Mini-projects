using System;
using System.Drawing;
using System.Windows.Forms;

namespace QR_AttendanceControl
{
    public partial class ManageStudents : Form
    {
        Form_Student form;
        public ManageStudents()
        {
            InitializeComponent();

            tb_Search.Text = "Enter the student ID";
            tb_Search.ForeColor = Color.Gray;
            form = new Form_Student(this);
        }

        public void ShowDisplay()
        {
            DataBase.ShowAndSearch("SELECT * FROM Students", dataGridView);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.AddStudentInfo();
            form.ShowDialog();
        }

        private void ManageStudents_Shown(object sender, EventArgs e)
        {
            ShowDisplay();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            DataBase.ShowAndSearch("SELECT * FROM Students WHERE id LIKE '%" + tb_Search.Text + "%'", dataGridView);
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Edit
                form.Clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.surname = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.middle_name = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //Delete
                if (MessageBox.Show("Confirm deletion", "Information", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DataBase.DeleteStudent(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    ShowDisplay();
                }
                return;
            }
        }

        private void tb_Search_Leave(object sender, EventArgs e)
        {
            if (tb_Search.Text == "")
            {
                tb_Search.Text = "Enter the student ID";
                tb_Search.ForeColor = Color.Gray;

            }
        }

        private void tb_Search_Enter(object sender, EventArgs e)
        {
            if (tb_Search.Text == "Enter the student ID")
            {
                tb_Search.Text = "";
                tb_Search.ForeColor = Color.Black;

            }
        }
    }
}
