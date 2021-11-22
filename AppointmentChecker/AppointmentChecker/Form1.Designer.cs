
using System.Windows.Forms;

namespace AppointmentChecker
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
            this.btnCheckAppointment = new System.Windows.Forms.Button();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.lstMeetings = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckAppointment
            // 
            this.btnCheckAppointment.Location = new System.Drawing.Point(460, 320);
            this.btnCheckAppointment.Name = "btnCheckAppointment";
            this.btnCheckAppointment.Size = new System.Drawing.Size(149, 23);
            this.btnCheckAppointment.TabIndex = 0;
            this.btnCheckAppointment.Text = "Check Appointment";
            this.btnCheckAppointment.UseVisualStyleBackColor = true;
            this.btnCheckAppointment.Click += new System.EventHandler(this.btnCheckAppointment_Click);
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(118, 38);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtStartDate.TabIndex = 1;
            this.dtStartDate.ShowUpDown = true;
            this.dtStartDate.Format = DateTimePickerFormat.Custom;
            this.dtStartDate.CustomFormat = "MMMM dd, yyyy hh:mm tt";
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dtStartDate_ValueChanged);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(379, 38);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtEndDate.TabIndex = 2;
            this.dtEndDate.ShowUpDown = true;
            this.dtEndDate.Format = DateTimePickerFormat.Custom;
            this.dtEndDate.CustomFormat = "MMMM dd, yyyy hh:mm tt";
            this.dtEndDate.ValueChanged += new System.EventHandler(this.dtEndDate_ValueChanged);
            // 
            // lstMeetings
            // 
            this.lstMeetings.FormattingEnabled = true;
            this.lstMeetings.Location = new System.Drawing.Point(118, 79);
            this.lstMeetings.Name = "lstMeetings";
            this.lstMeetings.Size = new System.Drawing.Size(461, 212);
            this.lstMeetings.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "StartDate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "EndDate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMeetings);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.btnCheckAppointment);
            this.Name = "Form1";
            this.Text = "Check Appointment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckAppointment;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.ListBox lstMeetings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

