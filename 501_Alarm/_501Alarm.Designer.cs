namespace _501_Alarm
{
    partial class _501Alarm
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
            this.uxalarmAlert = new System.Windows.Forms.TextBox();
            this.uxSnoozeTimePicker = new System.Windows.Forms.NumericUpDown();
            this.uxSnoozeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozeTimePicker)).BeginInit();
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
            this.uxsnoozeButton.Location = new System.Drawing.Point(26, 362);
            this.uxsnoozeButton.Name = "uxsnoozeButton";
            this.uxsnoozeButton.Size = new System.Drawing.Size(94, 60);
            this.uxsnoozeButton.TabIndex = 1;
            this.uxsnoozeButton.Text = "Snooze";
            this.uxsnoozeButton.UseVisualStyleBackColor = true;
            this.uxsnoozeButton.Click += new System.EventHandler(this.uxsnoozeButton_Click);
            // 
            // uxstopButton
            // 
            this.uxstopButton.Enabled = false;
            this.uxstopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxstopButton.Location = new System.Drawing.Point(261, 362);
            this.uxstopButton.Name = "uxstopButton";
            this.uxstopButton.Size = new System.Drawing.Size(94, 60);
            this.uxstopButton.TabIndex = 2;
            this.uxstopButton.Text = "Stop";
            this.uxstopButton.UseVisualStyleBackColor = true;
            this.uxstopButton.Click += new System.EventHandler(this.uxstopButton_Click);
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
            this.uxalarmList.Size = new System.Drawing.Size(321, 196);
            this.uxalarmList.TabIndex = 5;
            this.uxalarmList.SelectedIndexChanged += new System.EventHandler(this.uxalarmList_SelectedIndexChanged);
            // 
            // uxalarmAlert
            // 
            this.uxalarmAlert.BackColor = System.Drawing.SystemColors.Control;
            this.uxalarmAlert.Location = new System.Drawing.Point(218, 297);
            this.uxalarmAlert.Multiline = true;
            this.uxalarmAlert.Name = "uxalarmAlert";
            this.uxalarmAlert.Size = new System.Drawing.Size(137, 59);
            this.uxalarmAlert.TabIndex = 6;
            // 
            // uxSnoozeTimePicker
            // 
            this.uxSnoozeTimePicker.Location = new System.Drawing.Point(26, 334);
            this.uxSnoozeTimePicker.Name = "uxSnoozeTimePicker";
            this.uxSnoozeTimePicker.Size = new System.Drawing.Size(120, 22);
            this.uxSnoozeTimePicker.TabIndex = 7;
            // 
            // uxSnoozeTextBox
            // 
            this.uxSnoozeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.uxSnoozeTextBox.Location = new System.Drawing.Point(26, 297);
            this.uxSnoozeTextBox.Multiline = true;
            this.uxSnoozeTextBox.Name = "uxSnoozeTextBox";
            this.uxSnoozeTextBox.Size = new System.Drawing.Size(120, 31);
            this.uxSnoozeTextBox.TabIndex = 8;
            this.uxSnoozeTextBox.Text = "Set Snooze Time:";
            // 
            // _501Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 448);
            this.Controls.Add(this.uxSnoozeTextBox);
            this.Controls.Add(this.uxSnoozeTimePicker);
            this.Controls.Add(this.uxalarmAlert);
            this.Controls.Add(this.uxalarmList);
            this.Controls.Add(this.uxaddButton);
            this.Controls.Add(this.uxstopButton);
            this.Controls.Add(this.uxsnoozeButton);
            this.Controls.Add(this.uxeditButton);
            this.Name = "_501Alarm";
            this.Text = "Alarm501";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozeTimePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxeditButton;
        private System.Windows.Forms.Button uxsnoozeButton;
        private System.Windows.Forms.Button uxstopButton;
        private System.Windows.Forms.Button uxaddButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox uxalarmList;
        private System.Windows.Forms.TextBox uxalarmAlert;
        private System.Windows.Forms.NumericUpDown uxSnoozeTimePicker;
        private System.Windows.Forms.TextBox uxSnoozeTextBox;
    }
}

