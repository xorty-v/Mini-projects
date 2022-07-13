using System;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace QR_AttendanceControl
{
    public partial class StudentStatistics : Form
    {
        public StudentStatistics()
        {
            InitializeComponent();
            tb_Search1.Text = "Enter the group number";
            tb_Search1.ForeColor = Color.Gray;
            tb_1.Text = "0";
        }

        private void StudentStatistics_Shown(object sender, EventArgs e)
        {
            DataBase.Show("SELECT name, surname, middle_name, date_time FROM Students " +
                "JOIN StudentsAttendance ON student_id = id ORDER BY student_id", dgvSearch);
        }
        public void ShowDisplay()
        {
            DataBase.ShowAndSearch("SELECT * FROM StudentsAttendance", dgvSearch);
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (dgvSearch.Rows.Count > 0)
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvSearch.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dgvSearch.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvSearch.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvSearch.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dgvSearch.Rows[i].Cells[j].Value.ToString();
                    }
                }

                excelApp.Columns.AutoFit();
                excelApp.Visible = true;
            }
        }

        private void tb_Search1_TextChanged(object sender, EventArgs e)
        {
            DataBase.Show("SELECT name, surname, middle_name, date_time FROM Students JOIN " +
                "StudentsAttendance ON student_id = id WHERE student_id LIKE '%" + tb_Search1.Text + "%'", dgvSearch);
        }

        private void tb_Search1_Leave(object sender, EventArgs e)
        {
            if (tb_Search1.Text == "")
            {
                tb_Search1.Text = "Enter the group number";
                tb_Search1.ForeColor = Color.Gray;

            }
        }

        private void tb_Search1_Enter(object sender, EventArgs e)
        {
            if (tb_Search1.Text == "Enter the group number")
            {
                tb_Search1.Text = "";
                tb_Search1.ForeColor = Color.Black;

            }
        }

        private void btn_diagram_Click(object sender, EventArgs e)
        {
            int count = dgvSearch.Rows.Count;
            tb_1.Text = Convert.ToString(count);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm deletion", "Information", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DataBase.DeleteStudentsFromAttendance();
                ShowDisplay();
            }
        }
    }
}
