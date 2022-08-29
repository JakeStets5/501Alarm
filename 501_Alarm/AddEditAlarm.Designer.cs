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
            this.SuspendLayout();
            // 
            // uxtimePicker
            // 
            this.uxtimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxtimePicker.Location = new System.Drawing.Point(44, 45);
            this.uxtimePicker.Name = "uxtimePicker";
            this.uxtimePicker.Size = new System.Drawing.Size(311, 27);
            this.uxtimePicker.TabIndex = 0;
            // 
            // uxonCheckBox
            // 
            this.uxonCheckBox.AutoSize = true;
            this.uxonCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxonCheckBox.Location = new System.Drawing.Point(369, 49);
            this.uxonCheckBox.Name = "uxonCheckBox";
            this.uxonCheckBox.Size = new System.Drawing.Size(53, 24);
            this.uxonCheckBox.TabIndex = 1;
            this.uxonCheckBox.Text = "On";
            this.uxonCheckBox.UseVisualStyleBackColor = true;
            this.uxonCheckBox.CheckedChanged += new System.EventHandler(this.uxonCheckBox_CheckedChanged);
            // 
            // uxcancelButton
            // 
            this.uxcancelButton.Location = new System.Drawing.Point(44, 117);
            this.uxcancelButton.Name = "uxcancelButton";
            this.uxcancelButton.Size = new System.Drawing.Size(115, 57);
            this.uxcancelButton.TabIndex = 2;
            this.uxcancelButton.Text = "Cancel";
            this.uxcancelButton.UseVisualStyleBackColor = true;
            this.uxcancelButton.Click += new System.EventHandler(this.uxcancelButton_Click);
            // 
            // uxsetButton
            // 
            this.uxsetButton.Location = new System.Drawing.Point(307, 117);
            this.uxsetButton.Name = "uxsetButton";
            this.uxsetButton.Size = new System.Drawing.Size(115, 57);
            this.uxsetButton.TabIndex = 4;
            this.uxsetButton.Text = "Set";
            this.uxsetButton.UseVisualStyleBackColor = true;
            this.uxsetButton.Click += new System.EventHandler(this.uxsetButton_Click);
            // 
            // AddEditAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 198);
            this.Controls.Add(this.uxsetButton);
            this.Controls.Add(this.uxcancelButton);
            this.Controls.Add(this.uxonCheckBox);
            this.Controls.Add(this.uxtimePicker);
            this.Name = "AddEditAlarm";
            this.Text = "AddEditAlarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxtimePicker;
        private System.Windows.Forms.CheckBox uxonCheckBox;
        private System.Windows.Forms.Button uxcancelButton;
        private System.Windows.Forms.Button uxsetButton;
    }
}