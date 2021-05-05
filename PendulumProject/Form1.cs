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
        private EventLoop eventLoop;
        private double Scale = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void HandleStart_Click(object sender, EventArgs e)
        {
            this.eventLoop = new EventLoop((float)0.1);
            var startTime = DateTime.Now;
            var sp = new SuspensionPoint();
            this.eventLoop.HandleActions += (double time) =>
            {
                var dt = (DateTime.Now - startTime).TotalSeconds;
                sp.RecalculateYBias(dt);
                this.Draw(sp);
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

        private void Draw(SuspensionPoint sp)
        {
            var delta = sp.YBias * this.Scale;
            //suspension point cercle radius
            float r = this.pendulumPictureBox.ClientSize.Height / 20;
            float h = this.pendulumPictureBox.ClientSize.Height - r;

            sp.Y = r * 3;
            sp.X = pendulumPictureBox.Width / 2;

            PointF pt;
            using (Graphics g = pendulumPictureBox.CreateGraphics())
            {
                g.Clear(SystemColors.Control);
                var y = sp.Y + delta;
                RectangleF rect = RectangleF.FromLTRB(
                    (float)sp.X - r,
                    (float)y - r,
                    (float)sp.X + r,
                    (float)y + r);
                g.FillEllipse(Brushes.CornflowerBlue, rect);
            }
        }
    }
}
