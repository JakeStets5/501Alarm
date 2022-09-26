namespace _501_Alarm
{
    partial class AddEditAlarm
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
            this.uxtimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxonCheckBox = new System.Windows.Forms.CheckBox();
            this.uxcancelButton = new System.Windows.Forms.Button();
            this.uxsetButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.soundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beaconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reflectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxtimePicker
            // 
            this.uxtimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxtimePicker.Location = new System.Drawing.Point(17, 42);
            this.uxtimePicker.Name = "uxtimePicker";
            this.uxtimePicker.Size = new System.Drawing.Size(311, 31);
            this.uxtimePicker.TabIndex = 0;
            // 
            // uxonCheckBox
            // 
            this.uxonCheckBox.AutoSize = true;
            this.uxonCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxonCheckBox.Location = new System.Drawing.Point(342, 46);
            this.uxonCheckBox.Name = "uxonCheckBox";
            this.uxonCheckBox.Size = new System.Drawing.Size(66, 29);
            this.uxonCheckBox.TabIndex = 1;
            this.uxonCheckBox.Text = "On";
            this.uxonCheckBox.UseVisualStyleBackColor = true;
            this.uxonCheckBox.CheckedChanged += new System.EventHandler(this.uxonCheckBox_CheckedChanged);
            // 
            // uxcancelButton
            // 
            this.uxcancelButton.Location = new System.Drawing.Point(17, 114);
            this.uxcancelButton.Name = "uxcancelButton";
            this.uxcancelButton.Size = new System.Drawing.Size(115, 57);
            this.uxcancelButton.TabIndex = 2;
            this.uxcancelButton.Text = "Cancel";
            this.uxcancelButton.UseVisualStyleBackColor = true;
            this.uxcancelButton.Click += new System.EventHandler(this.uxcancelButton_Click);
            // 
            // uxsetButton
            // 
            this.uxsetButton.Location = new System.Drawing.Point(280, 114);
            this.uxsetButton.Name = "uxsetButton";
            this.uxsetButton.Size = new System.Drawing.Size(115, 57);
            this.uxsetButton.TabIndex = 4;
            this.uxsetButton.Text = "Set";
            this.uxsetButton.UseVisualStyleBackColor = true;
            this.uxsetButton.Click += new System.EventHandler(this.uxsetButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // soundsToolStripMenuItem
            // 
            this.soundsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radarToolStripMenuItem,
            this.beaconToolStripMenuItem,
            this.chimesToolStripMenuItem,
            this.circuitToolStripMenuItem,
            this.reflectionToolStripMenuItem});
            this.soundsToolStripMenuItem.Name = "soundsToolStripMenuItem";
            this.soundsToolStripMenuItem.Size = new System.Drawing.Size(140, 29);
            this.soundsToolStripMenuItem.Text = "Alarm Sounds";
            // 
            // radarToolStripMenuItem
            // 
            this.radarToolStripMenuItem.Name = "radarToolStripMenuItem";
            this.radarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.radarToolStripMenuItem.Text = "Radar";
            this.radarToolStripMenuItem.Click += new System.EventHandler(this.radarToolStripMenuItem_Click);
            // 
            // beaconToolStripMenuItem
            // 
            this.beaconToolStripMenuItem.Name = "beaconToolStripMenuItem";
            this.beaconToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.beaconToolStripMenuItem.Text = "Beacon";
            this.beaconToolStripMenuItem.Click += new System.EventHandler(this.beaconToolStripMenuItem_Click);
            // 
            // chimesToolStripMenuItem
            // 
            this.chimesToolStripMenuItem.Name = "chimesToolStripMenuItem";
            this.chimesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.chimesToolStripMenuItem.Text = "Chimes";
            this.chimesToolStripMenuItem.Click += new System.EventHandler(this.chimesToolStripMenuItem_Click);
            // 
            // circuitToolStripMenuItem
            // 
            this.circuitToolStripMenuItem.Name = "circuitToolStripMenuItem";
            this.circuitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.circuitToolStripMenuItem.Text = "Circuit";
            this.circuitToolStripMenuItem.Click += new System.EventHandler(this.circuitToolStripMenuItem_Click);
            // 
            // reflectionToolStripMenuItem
            // 
            this.reflectionToolStripMenuItem.Name = "reflectionToolStripMenuItem";
            this.reflectionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.reflectionToolStripMenuItem.Text = "Reflection";
            this.reflectionToolStripMenuItem.Click += new System.EventHandler(this.reflectionToolStripMenuItem_Click);
            // 
            // AddEditAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 198);
            this.Controls.Add(this.uxsetButton);
            this.Controls.Add(this.uxcancelButton);
            this.Controls.Add(this.uxonCheckBox);
            this.Controls.Add(this.uxtimePicker);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddEditAlarm";
            this.Text = "AddEditAlarm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxtimePicker;
        private System.Windows.Forms.CheckBox uxonCheckBox;
        private System.Windows.Forms.Button uxcancelButton;
        private System.Windows.Forms.Button uxsetButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem soundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beaconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reflectionToolStripMenuItem;
    }
}