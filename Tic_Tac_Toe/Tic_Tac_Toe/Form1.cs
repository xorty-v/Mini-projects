using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;

        private void DetermineTheMove(object senderObj)
        {
            string buttonText = ((Button)senderObj).Text;

            if (buttonText == "")
            {
                if (count % 2 == 0)
                {
                    ((Button)senderObj).Text = "你";
                    ((Button)senderObj).ForeColor = Color.Black;

                }
                else
                {
                    ((Button)senderObj).Text = "好";
                    ((Button)senderObj).ForeColor = Color.DarkBlue;
                }

                count++;
            }
            else
            {
                MessageBox.Show("Invalid Click");
            }

            CheckWin(senderObj);
        }

        private void CheckWin(object senderObj)
        {
            if (but_1.Text == but_2.Text && but_2.Text == but_3.Text && but_1.Text != "") { MessageBox.Show($"Win - {((Button)senderObj).Text}"); RestartGame(); }
            if (but_4.Text == but_5.Text && but_5.Text == but_6.Text && but_4.Text != "") { MessageBox.Show($"Win - {((Button)senderObj).Text}"); RestartGame(); }
            if (but_7.Text == but_8.Text && but_8.Text == but_9.Text && but_7.Text != "") { MessageBox.Show($"Win - {((Button)senderObj).Text}"); RestartGame(); }
            if (but_1.Text == but_4.Text && but_4.Text == but_7.Text && but_1.Text != "") { MessageBox.Show($"Win - {((Button)senderObj).Text}"); RestartGame(); }
            if (but_2.Text == but_5.Text && but_5.Text == but_8.Text && but_2.Text != "") { MessageBox.Show($"Win - {((Button)senderObj).Text}"); RestartGame(); }
            if (but_3.Text == but_6.Text && but_6.Text == but_9.Text && but_3.Text != "") { MessageBox.Show($"Win - {((Button)senderObj).Text}"); RestartGame(); }
            if (but_1.Text == but_5.Text && but_5.Text == but_9.Text && but_1.Text != "") { MessageBox.Show($"Win - {((Button)senderObj).Text}"); RestartGame(); }
            if (but_3.Text == but_5.Text && but_5.Text == but_7.Text && but_3.Text != "") { MessageBox.Show($"Win - {((Button)senderObj).Text}"); RestartGame(); }
        }

        private void RestartGame()
        {
            count = 0;
            but_1.Text = "";
            but_2.Text = "";
            but_3.Text = "";
            but_6.Text = "";
            but_5.Text = "";
            but_4.Text = "";
            but_9.Text = "";
            but_8.Text = "";
            but_7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetermineTheMove(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
