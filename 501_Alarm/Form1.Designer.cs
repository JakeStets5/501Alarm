﻿namespace _501_Alarm
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
            this.components = new System.ComponentModel.Container();
            this.uxeditButton = new System.Windows.Forms.Button();
            this.uxsnoozeButton = new System.Windows.Forms.Button();
            this.uxstopButton = new System.Windows.Forms.Button();
            this.uxaddButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxalarmList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uxeditButton
            // 
            this.uxeditButton.Enabled = false;
            this.uxeditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxeditButton.Location = new System.Drawing.Point(26, 12);
            this.uxeditButton.Name = "uxeditButton";
            this.uxeditButton.Size = new System.Drawing.Size(94, 60);
            this.uxeditButton.TabIndex = 0;
            this.uxeditButton.Text = "Edit";
            this.uxeditButton.UseVisualStyleBackColor = true;
            this.uxeditButton.Click += new System.EventHandler(this.uxeditButton_Click);
            // 
            // uxsnoozeButton
            // 
            this.uxsnoozeButton.Enabled = false;
            this.uxsnoozeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxsnoozeButton.Location = new System.Drawing.Point(26, 353);
            this.uxsnoozeButton.Name = "uxsnoozeButton";
            this.uxsnoozeButton.Size = new System.Drawing.Size(94, 60);
            this.uxsnoozeButton.TabIndex = 1;
            this.uxsnoozeButton.Text = "Snooze";
            this.uxsnoozeButton.UseVisualStyleBackColor = true;
            // 
            // uxstopButton
            // 
            this.uxstopButton.Enabled = false;
            this.uxstopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxstopButton.Location = new System.Drawing.Point(261, 353);
            this.uxstopButton.Name = "uxstopButton";
            this.uxstopButton.Size = new System.Drawing.Size(94, 60);
            this.uxstopButton.TabIndex = 2;
            this.uxstopButton.Text = "Stop";
            this.uxstopButton.UseVisualStyleBackColor = true;
            // 
            // uxaddButton
            // 
            this.uxaddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxaddButton.Location = new System.Drawing.Point(261, 10);
            this.uxaddButton.Name = "uxaddButton";
            this.uxaddButton.Size = new System.Drawing.Size(94, 60);
            this.uxaddButton.TabIndex = 3;
            this.uxaddButton.Text = "+";
            this.uxaddButton.UseVisualStyleBackColor = true;
            this.uxaddButton.Click += new System.EventHandler(this.uxaddButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uxalarmList
            // 
            this.uxalarmList.FormattingEnabled = true;
            this.uxalarmList.ItemHeight = 16;
            this.uxalarmList.Location = new System.Drawing.Point(34, 84);
            this.uxalarmList.Name = "uxalarmList";
            this.uxalarmList.Size = new System.Drawing.Size(321, 260);
            this.uxalarmList.TabIndex = 5;
            this.uxalarmList.SelectedIndexChanged += new System.EventHandler(this.uxalarmList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.uxalarmList);
            this.Controls.Add(this.uxaddButton);
            this.Controls.Add(this.uxstopButton);
            this.Controls.Add(this.uxsnoozeButton);
            this.Controls.Add(this.uxeditButton);
            this.Name = "Form1";
            this.Text = "Alarm501";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxeditButton;
        private System.Windows.Forms.Button uxsnoozeButton;
        private System.Windows.Forms.Button uxstopButton;
        private System.Windows.Forms.Button uxaddButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox uxalarmList;
    }
}

