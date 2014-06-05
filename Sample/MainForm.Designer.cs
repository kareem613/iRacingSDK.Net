﻿namespace Sample
{
    partial class MainForm
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
            this.EventSampleButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventSampleButton
            // 
            this.EventSampleButton.Location = new System.Drawing.Point(12, 12);
            this.EventSampleButton.Name = "EventSampleButton";
            this.EventSampleButton.Size = new System.Drawing.Size(136, 46);
            this.EventSampleButton.TabIndex = 0;
            this.EventSampleButton.Text = "Event Sample";
            this.EventSampleButton.UseVisualStyleBackColor = true;
            this.EventSampleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fastest Lap Sample";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.fastestLapButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "iRacingInstance access";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.iRacingInstance_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Total Distances";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.TotalDistances_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(169, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "Lap Sectors";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.LapSectors_click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 46);
            this.button5.TabIndex = 5;
            this.button5.Text = "Take Until After";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.TakeUntilAfter_click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(169, 204);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 46);
            this.button6.TabIndex = 6;
            this.button6.Text = "Wait until end of Race";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.RaceEnd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 445);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EventSampleButton);
            this.Name = "MainForm";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EventSampleButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}