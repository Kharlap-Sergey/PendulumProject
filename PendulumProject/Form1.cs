using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PendulumProject
{
    public partial class Form1 : Form
    {
        private double speedCorrector = 1;
        private EventLoop eventLoop;
        private double suspensionPointRadius = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void HandleStart_Click(object sender, EventArgs e)
        {
            this.eventLoop = new EventLoop((float)0.1);
            var startTime = DateTime.Now;
            var sp = new SuspensionPoint();
            sp.Y = this.pendulumPictureBox.Width / 2;
            sp.X = this.pendulumPictureBox.Width / 2;
            var pendulum = new Pendulum();

            var rePendulum = new ReversePendulum();

            this.eventLoop.HandleActions += (double time) =>
            {
                var dt = (DateTime.Now - startTime).TotalSeconds * this.speedCorrector;


                sp.RecalculateYBias(dt);
                pendulum.CalculateF(dt);
                rePendulum.CalculateF(dt);

                this.Draw(this.pendulumPictureBox, sp, pendulum);
                this.Draw(this.rePendulumPictureBox, sp, rePendulum);
            };

            new Task(() =>
            {
                this.eventLoop.Start().Wait();
            }).Start();
        }

        private void HandleStop_Click(object sender, EventArgs e)
        {
            this.eventLoop?.Stop();
        }

        private void Draw(PictureBox convars,SuspensionPoint sp, Pendulum pendulum)
        {
            //suspension point cercle radius
            this.suspensionPointRadius = convars.ClientSize.Height / 50;
            //float h = this.pendulumPictureBox.ClientSize.Height - r;
            using (Graphics g = convars.CreateGraphics())
            {
                g.Clear(SystemColors.Control);

                RectangleF rectangle = this.CreateREctangle(
                    sp.X,
                    sp.Y,
                    this.suspensionPointRadius
                    );

                var x = (float)(sp.X + pendulum.XBias * 2);
                var y = (float)(sp.Y + pendulum.YBias * 2);

                g.DrawLine(
                    Pens.Black,
                    (float)sp.X,
                    (float)sp.Y,
                    x,
                    y
                    );

                RectangleF rectangle2 = this.CreateREctangle(
                   x,
                   y,
                   this.suspensionPointRadius * 3
                   );

                g.FillEllipse(Brushes.CornflowerBlue, rectangle);
                g.FillEllipse(Brushes.CornflowerBlue, rectangle2);
            }
        }

        private RectangleF CreateREctangle(double x, double y, double r)
        {
            var rect = RectangleF.FromLTRB(
                  (float)(x - r),
                  (float)(y - r),
                  (float)(x + r),
                  (float)(y + r));

            return rect;
        }
    }
}
