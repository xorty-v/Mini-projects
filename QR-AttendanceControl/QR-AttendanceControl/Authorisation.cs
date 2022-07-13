using System;
using System.Drawing;
using System.Windows.Forms;

namespace QR_AttendanceControl
{
    public partial class Authorisation : Form
    {
        public Authorisation()
        {
            InitializeComponent();

            tb_Login.Text = "Enter your username";
            tb_Login.ForeColor = Color.Gray;

            tb_Password.Text = "Enter the password";
            tb_Password.ForeColor = Color.Gray;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tb_Login.Text == "1" && tb_Password.Text == "1")
            {
                Scanner scanner = new Scanner();
                this.Hide();
                scanner.Show();
            }
            else if (tb_Login.Text == "2" && tb_Password.Text == "2")
            {
                AdminPanel adminPanel = new AdminPanel();
                this.Hide();
                adminPanel.Show();
            }
            else
            {
                MessageBox.Show("Incorrect login or password", "Ошибка");

                tb_Login.Text = "Enter your username";
                tb_Login.ForeColor = Color.Gray;

                tb_Password.Text = "Enter the password";
                tb_Password.ForeColor = Color.Gray;
            }
        }

        private void tb_Login_Enter(object sender, EventArgs e)
        {
            if (tb_Login.Text == "Enter your username")
            {
                tb_Login.Text = "";
                tb_Login.ForeColor = Color.Black;

            }
        }

        private void tb_Login_Leave(object sender, EventArgs e)
        {
            if (tb_Login.Text == "")
            {
                tb_Login.Text = "Enter your username";
                tb_Login.ForeColor = Color.Gray;

            }
        }

        private void tb_Password_Enter(object sender, EventArgs e)
        {
            if (tb_Password.Text == "Enter the password")
            {
                tb_Password.Text = "";
                tb_Password.ForeColor = Color.Black;
            }
        }

        private void tb_Password_Leave(object sender, EventArgs e)
        {
            if (tb_Password.Text == "")
            {
                tb_Password.Text = "Enter the password";
                tb_Password.ForeColor = Color.Gray;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void btn_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Login.PerformClick();
        }
    }
}
