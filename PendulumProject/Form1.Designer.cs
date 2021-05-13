
namespace PendulumProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pendulumPictureBox = new System.Windows.Forms.PictureBox();
            this.rePendulumPictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pendulumPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rePendulumPictureBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pendulumPictureBox
            // 
            this.pendulumPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pendulumPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pendulumPictureBox.Location = new System.Drawing.Point(281, 33);
            this.pendulumPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pendulumPictureBox.Name = "pendulumPictureBox";
            this.pendulumPictureBox.Size = new System.Drawing.Size(333, 430);
            this.pendulumPictureBox.TabIndex = 1;
            this.pendulumPictureBox.TabStop = false;
            // 
            // rePendulumPictureBox
            // 
            this.rePendulumPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rePendulumPictureBox.Location = new System.Drawing.Point(668, 33);
            this.rePendulumPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.rePendulumPictureBox.Name = "rePendulumPictureBox";
            this.rePendulumPictureBox.Size = new System.Drawing.Size(333, 430);
            this.rePendulumPictureBox.TabIndex = 3;
            this.rePendulumPictureBox.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 554);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::PendulumProject.Properties.Resources.Start_icon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(37, 24);
            this.toolStripButton2.Text = "start";
            this.toolStripButton2.Click += new System.EventHandler(this.HandleStart_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::PendulumProject.Properties.Resources.CSS_Cursor_12_512;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(37, 24);
            this.toolStripButton3.Text = "stop";
            this.toolStripButton3.Click += new System.EventHandler(this.HandleStop_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::PendulumProject.Properties.Resources.help;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(37, 24);
            this.toolStripButton1.Text = "help";
            this.toolStripButton1.Click += new System.EventHandler(this.HelpBtnClick_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(37, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.MakeScreenShotAndInsertIntoDockImageLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rePendulumPictureBox);
            this.Controls.Add(this.pendulumPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Курсова работа студента группы 10701219 Харлапа С. А,";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pendulumPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rePendulumPictureBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pendulumPictureBox;
        private System.Windows.Forms.PictureBox rePendulumPictureBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

