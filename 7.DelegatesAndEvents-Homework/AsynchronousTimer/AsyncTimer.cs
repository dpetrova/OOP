using System;
using System.Threading;

namespace AsynchronousTimer
{
    class AsyncTimer
    {
        private Action<string> method;
        private int interval;
        private int ticks;

        public AsyncTimer(Action<string> method, int interval, int ticks)
        {
            this.ticks = ticks;
            this.interval = interval;
            this.method = method;
        }

        private void OnTick()
        {
            while (this.ticks > 0)
            {
                Thread.Sleep(this.interval);
                method(this.ticks + "\n");
                this.ticks--;
            }
        }

        public void Start()
        {
            Thread thread = new Thread(this.OnTick);
            thread.Start();
        }
    }
}