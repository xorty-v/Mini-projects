using System;
using System.Threading;
using System.Windows.Forms;

namespace Multithreading_Example
{
    public partial class Form1 : Form
    {
        private Worker worker;

        public Form1()
        {
            InitializeComponent();
        }

        private void but_Stop_Click(object sender, EventArgs e)
        {
            worker.Cancel();     
        }

        private void but_Start_Click(object sender, EventArgs e)
        {
            worker = new Worker();
            worker.ProccesChange += Worker_ProccesChange;
            worker.WorkCompleted += Worker_WorkCompleted1;

            butStart.Enabled = false;
            butStop.Enabled = true;

            Thread thread = new Thread(worker.Work);
            thread.Start(); // запускаю вторичный поток
        }

        private void Worker_WorkCompleted1(bool сompleted)
        {
            Action action = () =>
            {
                string message = сompleted ? "Процесс отменен" : "Процесс завершен";
                MessageBox.Show(message);
                butStart.Enabled = true;
                butStop.Enabled = false;
            };

            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }

        private void Worker_ProccesChange(int progress)
        {
            Action action = () =>
            {
                prog_bar.Value = progress + 1;
                prog_bar.Value = progress;
            };

            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }
    }
}
