namespace MedCRM
{
    partial class Appointments
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments));
            this.data_appointments = new System.Windows.Forms.DataGridView();
            this.panel_appointments = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel_details = new System.Windows.Forms.Panel();
            this.txt_description = new MetroFramework.Controls.MetroTextBox();
            this.txt_time = new MetroFramework.Controls.MetroTextBox();
            this.txt_interviewee = new MetroFramework.Controls.MetroTextBox();
            this.txt_interviewer = new MetroFramework.Controls.MetroTextBox();
            this.txt_intervieweePosition = new MetroFramework.Controls.MetroComboBox();
            this.txt_status = new MetroFramework.Controls.MetroComboBox();
            this.txt_facility = new MetroFramework.Controls.MetroComboBox();
            this.picture_profile = new System.Windows.Forms.PictureBox();
            this.txt_date = new MetroFramework.Controls.MetroDateTime();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_appointments)).BeginInit();
            this.panel_appointments.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // data_appointments
            // 
            this.data_appointments.AllowUserToAddRows = false;
            this.data_appointments.AllowUserToDeleteRows = false;
            this.data_appointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_appointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_appointments.Location = new System.Drawing.Point(0, 0);
            this.data_appointments.Name = "data_appointments";
            this.data_appointments.ReadOnly = true;
            this.data_appointments.Size = new System.Drawing.Size(977, 265);
            this.data_appointments.TabIndex = 0;
            this.data_appointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_appointments_CellClick);
            // 
            // panel_appointments
            // 
            this.panel_appointments.Controls.Add(this.data_appointments);
            this.panel_appointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_appointments.Location = new System.Drawing.Point(0, 218);
            this.panel_appointments.Name = "panel_appointments";
            this.panel_appointments.Size = new System.Drawing.Size(977, 265);
            this.panel_appointments.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_set);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 43);
            this.panel1.TabIndex = 3;
            // 
            // btn_set
            // 
            this.btn_set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_set.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_set.FlatAppearance.BorderSize = 0;
            this.btn_set.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("Roboto", 8F);
            this.btn_set.ForeColor = System.Drawing.Color.White;
            this.btn_set.Location = new System.Drawing.Point(617, 0);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(120, 43);
            this.btn_set.TabIndex = 0;
            this.btn_set.Text = "Set Appointment";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Roboto", 8F);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(737, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(120, 43);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update Appointment";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Roboto", 8F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(857, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(120, 43);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel Appointment";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.txt_description);
            this.panel_details.Controls.Add(this.txt_time);
            this.panel_details.Controls.Add(this.txt_interviewee);
            this.panel_details.Controls.Add(this.txt_interviewer);
            this.panel_details.Controls.Add(this.txt_intervieweePosition);
            this.panel_details.Controls.Add(this.txt_status);
            this.panel_details.Controls.Add(this.txt_facility);
            this.panel_details.Controls.Add(this.picture_profile);
            this.panel_details.Controls.Add(this.txt_date);
            this.panel_details.Controls.Add(this.label7);
            this.panel_details.Controls.Add(this.label4);
            this.panel_details.Controls.Add(this.label1);
            this.panel_details.Controls.Add(this.label8);
            this.panel_details.Controls.Add(this.label3);
            this.panel_details.Controls.Add(this.label6);
            this.panel_details.Controls.Add(this.label2);
            this.panel_details.Controls.Add(this.label5);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_details.Location = new System.Drawing.Point(0, 0);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(977, 218);
            this.panel_details.TabIndex = 5;
            // 
            // txt_description
            // 
            // 
            // 
            // 
            this.txt_description.CustomButton.Image = null;
            this.txt_description.CustomButton.Location = new System.Drawing.Point(79, 2);
            this.txt_description.CustomButton.Name = "";
            this.txt_description.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.txt_description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_description.CustomButton.TabIndex = 1;
            this.txt_description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_description.CustomButton.UseSelectable = true;
            this.txt_description.CustomButton.Visible = false;
            this.txt_description.Lines = new string[0];
            this.txt_description.Location = new System.Drawing.Point(574, 100);
            this.txt_description.MaxLength = 32767;
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.PasswordChar = '\0';
            this.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_description.SelectedText = "";
            this.txt_description.SelectionLength = 0;
            this.txt_description.SelectionStart = 0;
            this.txt_description.ShortcutsEnabled = true;
            this.txt_description.Size = new System.Drawing.Size(165, 88);
            this.txt_description.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_description.TabIndex = 21;
            this.txt_description.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_description.UseSelectable = true;
            this.txt_description.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_description.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_time
            // 
            // 
            // 
            // 
            this.txt_time.CustomButton.Image = null;
            this.txt_time.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_time.CustomButton.Name = "";
            this.txt_time.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_time.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_time.CustomButton.TabIndex = 1;
            this.txt_time.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_time.CustomButton.UseSelectable = true;
            this.txt_time.CustomButton.Visible = false;
            this.txt_time.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_time.Lines = new string[0];
            this.txt_time.Location = new System.Drawing.Point(394, 165);
            this.txt_time.MaxLength = 32767;
            this.txt_time.Name = "txt_time";
            this.txt_time.PasswordChar = '\0';
            this.txt_time.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_time.SelectedText = "";
            this.txt_time.SelectionLength = 0;
            this.txt_time.SelectionStart = 0;
            this.txt_time.ShortcutsEnabled = true;
            this.txt_time.Size = new System.Drawing.Size(165, 23);
            this.txt_time.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_time.TabIndex = 22;
            this.txt_time.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_time.UseSelectable = true;
            this.txt_time.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_time.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_interviewee
            // 
            // 
            // 
            // 
            this.txt_interviewee.CustomButton.Image = null;
            this.txt_interviewee.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_interviewee.CustomButton.Name = "";
            this.txt_interviewee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_interviewee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_interviewee.CustomButton.TabIndex = 1;
            this.txt_interviewee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_interviewee.CustomButton.UseSelectable = true;
            this.txt_interviewee.CustomButton.Visible = false;
            this.txt_interviewee.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_interviewee.Lines = new string[0];
            this.txt_interviewee.Location = new System.Drawing.Point(207, 99);
            this.txt_interviewee.MaxLength = 32767;
            this.txt_interviewee.Name = "txt_interviewee";
            this.txt_interviewee.PasswordChar = '\0';
            this.txt_interviewee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_interviewee.SelectedText = "";
            this.txt_interviewee.SelectionLength = 0;
            this.txt_interviewee.SelectionStart = 0;
            this.txt_interviewee.ShortcutsEnabled = true;
            this.txt_interviewee.Size = new System.Drawing.Size(165, 23);
            this.txt_interviewee.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_interviewee.TabIndex = 22;
            this.txt_interviewee.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_interviewee.UseSelectable = true;
            this.txt_interviewee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_interviewee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_interviewer
            // 
            // 
            // 
            // 
            this.txt_interviewer.CustomButton.Image = null;
            this.txt_interviewer.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_interviewer.CustomButton.Name = "";
            this.txt_interviewer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_interviewer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_interviewer.CustomButton.TabIndex = 1;
            this.txt_interviewer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_interviewer.CustomButton.UseSelectable = true;
            this.txt_interviewer.CustomButton.Visible = false;
            this.txt_interviewer.Lines = new string[0];
            this.txt_interviewer.Location = new System.Drawing.Point(207, 33);
            this.txt_interviewer.MaxLength = 32767;
            this.txt_interviewer.Name = "txt_interviewer";
            this.txt_interviewer.PasswordChar = '\0';
            this.txt_interviewer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_interviewer.SelectedText = "";
            this.txt_interviewer.SelectionLength = 0;
            this.txt_interviewer.SelectionStart = 0;
            this.txt_interviewer.ShortcutsEnabled = true;
            this.txt_interviewer.Size = new System.Drawing.Size(165, 23);
            this.txt_interviewer.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_interviewer.TabIndex = 22;
            this.txt_interviewer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_interviewer.UseSelectable = true;
            this.txt_interviewer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_interviewer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_intervieweePosition
            // 
            this.txt_intervieweePosition.FormattingEnabled = true;
            this.txt_intervieweePosition.ItemHeight = 23;
            this.txt_intervieweePosition.Items.AddRange(new object[] {
            "Doctor",
            "Patient",
            "Professor",
            "Staff",
            "Other"});
            this.txt_intervieweePosition.Location = new System.Drawing.Point(209, 165);
            this.txt_intervieweePosition.Name = "txt_intervieweePosition";
            this.txt_intervieweePosition.Size = new System.Drawing.Size(163, 29);
            this.txt_intervieweePosition.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_intervieweePosition.TabIndex = 18;
            this.txt_intervieweePosition.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_intervieweePosition.UseSelectable = true;
            // 
            // txt_status
            // 
            this.txt_status.FormattingEnabled = true;
            this.txt_status.ItemHeight = 23;
            this.txt_status.Items.AddRange(new object[] {
            "Pending",
            "In session",
            "Attended",
            "Canceled"});
            this.txt_status.Location = new System.Drawing.Point(574, 33);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(163, 29);
            this.txt_status.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_status.TabIndex = 18;
            this.txt_status.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_status.UseSelectable = true;
            // 
            // txt_facility
            // 
            this.txt_facility.FormattingEnabled = true;
            this.txt_facility.ItemHeight = 23;
            this.txt_facility.Location = new System.Drawing.Point(392, 33);
            this.txt_facility.Name = "txt_facility";
            this.txt_facility.Size = new System.Drawing.Size(163, 29);
            this.txt_facility.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_facility.TabIndex = 18;
            this.txt_facility.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_facility.UseSelectable = true;
            // 
            // picture_profile
            // 
            this.picture_profile.Dock = System.Windows.Forms.DockStyle.Left;
            this.picture_profile.Image = ((System.Drawing.Image)(resources.GetObject("picture_profile.Image")));
            this.picture_profile.Location = new System.Drawing.Point(0, 0);
            this.picture_profile.Name = "picture_profile";
            this.picture_profile.Size = new System.Drawing.Size(186, 218);
            this.picture_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_profile.TabIndex = 9;
            this.picture_profile.TabStop = false;
            // 
            // txt_date
            // 
            this.txt_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_date.Location = new System.Drawing.Point(393, 98);
            this.txt_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(166, 29);
            this.txt_date.TabIndex = 16;
            this.txt_date.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(203, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Interviewee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(571, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Interviewer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(206, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Interviewee\'s position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(391, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Time of Appointment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(571, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date of Appointment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(391, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Facility";
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.panel_appointments);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_details);
            this.Name = "Appointments";
            this.Size = new System.Drawing.Size(977, 526);
            ((System.ComponentModel.ISupportInitialize)(this.data_appointments)).EndInit();
            this.panel_appointments.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_details.ResumeLayout(false);
            this.panel_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView data_appointments;
        private System.Windows.Forms.Panel panel_appointments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel panel_details;
        private MetroFramework.Controls.MetroTextBox txt_description;
        private MetroFramework.Controls.MetroTextBox txt_interviewer;
        private MetroFramework.Controls.MetroComboBox txt_facility;
        private System.Windows.Forms.PictureBox picture_profile;
        private MetroFramework.Controls.MetroDateTime txt_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txt_interviewee;
        private MetroFramework.Controls.MetroComboBox txt_intervieweePosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txt_time;
        private MetroFramework.Controls.MetroComboBox txt_status;
    }
}
