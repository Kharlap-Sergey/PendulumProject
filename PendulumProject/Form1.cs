using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronXL;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace PendulumProject
{
    public partial class Form1 : Form
    {
        private double speedCorrector = 1;
        private EventLoop eventLoop;
        private double suspensionPointRadius = 2;
        private bool isStarted = false;
        private DataTable preData;
        private double A;
        private double L;
        private double W;
        private double F;

        public Form1()
        {
            InitializeComponent();
            this.ReadExcel("./data", "xlsx");
        }

        private void HandleStart_Click(object sender, EventArgs e)
        {
            if (isStarted)
            {
                this.ShowError("The program is already started!");
                return;
            }

            this.isStarted = true;

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
            if (!this.isStarted)
            {
                this.ShowError("There isn't something to stop");
                return;
            }
            this.eventLoop?.Stop();
            this.isStarted = false;
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

        private void HelpBtnClick_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;

            startInfo.FileName = @"D:\Project\Pendulum\help.pdf";
            process.Start();
        }

        private void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.isStarted) this.HandleStop_Click(sender, e);
        }

        public void ReadExcel(string fileName, string fileExt)
        {
            WorkBook workbook = WorkBook.Load("data.xlsx");
            WorkSheet sheet = workbook.WorkSheets.First();
            this.A = sheet["A2"].DoubleValue;
            this.F = sheet["C2"].DoubleValue;
            this.W = sheet["B2"].DoubleValue;
            this.L = sheet["D2"].DoubleValue;
        }

        private void MakeScreenShotAndInsertIntoDockImageLog_Click(object sender, EventArgs e)
        {
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new System.Drawing.Point(bounds.Left, bounds.Top), System.Drawing.Point.Empty, bounds.Size);
                }
                //bitmap.Save("./test.jpg", ImageFormat.Jpeg);
                

                //Create Document
                Document document = new Document("./Image.docx");
                var s = document.AddSection();
                Paragraph p = s.AddParagraph();

                //Insert Image and Set Its Size
                p.AppendComment($"create at {DateTime.Now}");
                DocPicture Pic = p.AppendPicture(bitmap);
                Pic.Width = 750;
                Pic.Height = 468;

                //Save and Launch
                document.SaveToFile("Image.docx", FileFormat.Docx);
                document.Close();
                //System.Diagnostics.Process.Start("Image.docx");
            }
        }
    }
}
