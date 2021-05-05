using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendulumProject
{
    public class ReversePendulum : Pendulum
    {
        public override double CalculateF(double time)
        {
            if (this.A * this.W < Math.Sqrt(2 * 10 * this.Lenth))
            {
                this.F = base.CalculateF(time);
                this.F += 3.14;
            }
            else
            {
                this.F = 3.14;
            }

            return this.F;
        }
    }
}
