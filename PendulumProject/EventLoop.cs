using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PendulumProject
{
    public class EventLoop
    {

        private bool isRunning = false;
        public Action<double> HandleActions { get; set; }
        public float PeriodSecunds { get; set; }

        public EventLoop(
            float periodSecunds = 1,
            Action<double> handleActions = null
            )
        {
            this.HandleActions += handleActions;
            this.PeriodSecunds = periodSecunds;
        }

        public async Task Start()
        {
            this.isRunning = true;

            var time = 0;
            while (this.isRunning)
            {
                this.HandleActions?.Invoke(time);

                Thread.Sleep((int)Math.Truncate(this.PeriodSecunds * 1000));
            }

        }

        public void Stop()
        {
            this.isRunning = false;
        }
    }
}
