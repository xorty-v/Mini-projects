using System;

using System.Windows.Forms;

namespace QR_AttendanceControl
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();

            LoadForm(new ManageStudents());
        }

        public void LoadForm(object form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);

            Form formShow = form as Form;
            formShow.TopLevel = false;
            formShow.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(formShow);
            this.mainPanel.Tag = form;
            formShow.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAdd.Height;
            SidePanel.Top = btnAdd.Top;
            LoadForm(new ManageStudents());
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnExport.Height;
            SidePanel.Top = btnExport.Top;
            LoadForm(new StudentStatistics());
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Authorisation authorisation = new Authorisation();
            this.Close();
            authorisation.Show();
        }
    }
}
