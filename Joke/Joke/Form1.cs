using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joke
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            pb_Arrows.Visible = false;
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            count++;

            Random rand = new Random();
            btn_No.Left = rand.Next(0, this.ClientSize.Width - btn_No.Width);
            btn_No.Top = rand.Next(80, this.ClientSize.Height - btn_No.Height);

            if (count == 15)
            {
                btn_No.Visible = false;
                pb_Arrows.Visible = true;
                this.FormBorderStyle = FormBorderStyle.None;

            }
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ыыыыыыыыы");
            Application.Exit();
        }
    }
}
