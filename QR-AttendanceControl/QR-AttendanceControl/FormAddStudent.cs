using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace QR_AttendanceControl
{
    public partial class Form_Student : Form
    {
        private readonly ManageStudents parent;
        public string id, name, surname, middle_name;

        public Form_Student(ManageStudents parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public void Clear()
        {
            tb_Id.Text = tb_Name.Text = tb_Surname.Text = tb_MiddleName.Text = tb_Email.Text = string.Empty;
        }

        public void UpdateInfo()
        {
            label1.Text = "Update Student";
            btn_Save.Text = "Update";
            tb_Id.Text = id;
            tb_Name.Text = name;
            tb_Surname.Text = surname;
            tb_MiddleName.Text = middle_name;
        }

        public void AddStudentInfo()
        {
            label1.Text = "Add Students";
            btn_Save.Text = "Save";
        }

        private void SendEmail()
        {
            MailAddress mailAddress = new MailAddress("xortyword@gmail.com", "gtu.ge");
            MailAddress toAddres = new MailAddress(tb_Email.Text);

            MailMessage message = new MailMessage(mailAddress, toAddres);
            message.Subject = "QR";
            message.Body = $"Hello {tb_Name.Text}, your ID is - {tb_Id.Text}.\n" +
                $"Create a QR code with the specified ID address above and upload it to your phone.\n" +
                $"If you don't know how to create a qr code, then use this service for example: " +
                $"https://www.generateqronline.com";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential(mailAddress.Address, "maho1961qsew");
            smtpClient.EnableSsl = true;

            smtpClient.Send(message);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Id.Text.Trim().Length == 0)
            {
                MessageBox.Show("Invalid ID length");
                return;
            }
            if (tb_Name.Text.Trim().Length < 3)
            {
                MessageBox.Show("Invalid name length");
                return;
            }
            if (tb_Surname.Text.Trim().Length < 4)
            {
                MessageBox.Show("Invalid surname length");
                return;

            }
            if (tb_MiddleName.Text.Trim().Length < 4)
            {
                MessageBox.Show("Invalid Middle name length");
                return;
            }

            if (btn_Save.Text == "Save")
            {
                Student student = new Student(tb_Id.Text.Trim(), tb_Name.Text.Trim(), tb_Surname.Text.Trim(), tb_MiddleName.Text.Trim());
                DataBase.AddStudent(student);
                if (tb_Email.Text != "")
                {
                    SendEmail();
                }
                Clear();
            }
            if (btn_Save.Text == "Update")
            {
                Student student = new Student(tb_Id.Text.Trim(), tb_Name.Text.Trim(), tb_Surname.Text.Trim(), tb_MiddleName.Text.Trim());
                DataBase.UpdateStudent(student, id);
            }

            this.parent.ShowDisplay();
        }
    }
}
