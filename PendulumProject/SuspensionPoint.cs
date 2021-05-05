using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendulumProject
{
    public class SuspensionPoint : Point
    {
        private readonly Func<double, double, double, double> biasCalculator;

        public override double Y 
        {
            get => base.Y + this.YBias; 
            set => base.Y = value;
        }
        public double YBias { get; private set; } = 0;
        public double A { get; set; }
        public double W { get; set; }
        public SuspensionPoint(
            double A = 2, 
            double W = 3,
            Func<double, double, double, double> biasCalculator = null
            )
        {
            if(biasCalculator == null)
            {
                biasCalculator = this.CalculateBias;
            }

            this.A = A;
            this.W = W;
            this.biasCalculator = biasCalculator;
        }

        public double RecalculateYBias(double time)
        {
            this.YBias = 
                this.biasCalculator?.Invoke(time, this.A, this.W) 
                ?? this.YBias;
            return this.YBias;
        }

        protected virtual double CalculateBias(double t, double a, double w)
        {
            double times = t / 10;
            if (times >= 1)
            {
                if (Math.Truncate(a) % 2 == 0)
                {
                    a -= 0.5;
                }
                else
                {
                    a += 0.5;
                }
            }

            return a * Math.Cos(w * t);
        }
    }
}
