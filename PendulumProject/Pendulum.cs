using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendulumProject
{
    public class Pendulum
    {
        private const double GRAVITY = 10;

        public double XBias { get => Math.Sin(this.F) * this.Lenth; }
        public double YBias { get => Math.Cos(this.F) * this.Lenth; }
        public double StartAmplitude { get; set; } = 1.7;
        public double A { get; set; } = 2;
        public double W { get; set; }
        public double Lenth { get; set; } = 40;
        public double F { get; protected set; } = 0.1;

        public Pendulum()
        {
            this.W = Math.Sqrt(GRAVITY / this.Lenth);
        }

        public virtual double CalculateF(double time)
        {
            //this.F = (GRAVITY/this.Lenth + this.A*this.W*this.W/this.Lenth*Math.Cos(this.W*time))*this.F;
            this.F = this.A * Math.Cos(this.W * time + this.StartAmplitude);
            return this.F; 
        } 
    }
}
