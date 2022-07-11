using System;
using System.Threading;

namespace Multithreading_Example
{
    public class Worker
    {
        private bool cancelled = false;

        public void Cancel()
        {
            cancelled = true;
        }

        public void Work()
        {
            for (int i = 0; i <= 99; i++)
            {
                if (cancelled)
                    break;

                Thread.Sleep(50);

                ProccesChange(i);
            }

            WorkCompleted(cancelled);
        }

        public event Action<int> ProccesChange;
        public event Action<bool> WorkCompleted;
    }
}
