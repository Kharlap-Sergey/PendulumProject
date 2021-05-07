﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.pendulumPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rePendulumPictureBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pendulumPictureBox
            // 
            this.pendulumPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pendulumPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pendulumPictureBox.Location = new System.Drawing.Point(211, 27);
            this.pendulumPictureBox.Name = "pendulumPictureBox";
            this.pendulumPictureBox.Size = new System.Drawing.Size(250, 350);
            this.pendulumPictureBox.TabIndex = 1;
            this.pendulumPictureBox.TabStop = false;
            // 
            // rePendulumPictureBox
            // 
            this.rePendulumPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rePendulumPictureBox.Location = new System.Drawing.Point(501, 27);
            this.rePendulumPictureBox.Name = "rePendulumPictureBox";
            this.rePendulumPictureBox.Size = new System.Drawing.Size(250, 350);
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
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(32, 450);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "start";
            this.toolStripButton2.Click += new System.EventHandler(this.HandleStart_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(22, 24);
            this.toolStripButton3.Text = "stop";
            this.toolStripButton3.Click += new System.EventHandler(this.HandleStop_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "help";
            this.toolStripButton1.Click += new System.EventHandler(this.HelpBtnClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rePendulumPictureBox);
            this.Controls.Add(this.pendulumPictureBox);
            this.Name = "Form1";
            this.Text = "Курсова работа студента группы 10701219 Харлапа С. А,";
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
    }
}

