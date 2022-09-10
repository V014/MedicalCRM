﻿namespace MedCRM
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel_nav = new System.Windows.Forms.Panel();
            this.btn_payments = new System.Windows.Forms.Button();
            this.btn_messages = new System.Windows.Forms.Button();
            this.btn_forum = new System.Windows.Forms.Button();
            this.btn_reminders = new System.Windows.Forms.Button();
            this.btn_appointments = new System.Windows.Forms.Button();
            this.btn_patients = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_doctors = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_nav
            // 
            this.panel_nav.Controls.Add(this.button1);
            this.panel_nav.Controls.Add(this.btn_doctors);
            this.panel_nav.Controls.Add(this.btn_payments);
            this.panel_nav.Controls.Add(this.btn_messages);
            this.panel_nav.Controls.Add(this.btn_forum);
            this.panel_nav.Controls.Add(this.btn_reminders);
            this.panel_nav.Controls.Add(this.btn_appointments);
            this.panel_nav.Controls.Add(this.btn_patients);
            this.panel_nav.Controls.Add(this.btn_home);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(20, 60);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(160, 579);
            this.panel_nav.TabIndex = 0;
            // 
            // btn_payments
            // 
            this.btn_payments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_payments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_payments.FlatAppearance.BorderSize = 0;
            this.btn_payments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payments.ForeColor = System.Drawing.Color.White;
            this.btn_payments.Image = ((System.Drawing.Image)(resources.GetObject("btn_payments.Image")));
            this.btn_payments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payments.Location = new System.Drawing.Point(0, 300);
            this.btn_payments.Name = "btn_payments";
            this.btn_payments.Size = new System.Drawing.Size(160, 50);
            this.btn_payments.TabIndex = 6;
            this.btn_payments.Text = "Payments";
            this.btn_payments.UseVisualStyleBackColor = false;
            // 
            // btn_messages
            // 
            this.btn_messages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_messages.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_messages.FlatAppearance.BorderSize = 0;
            this.btn_messages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_messages.ForeColor = System.Drawing.Color.White;
            this.btn_messages.Image = ((System.Drawing.Image)(resources.GetObject("btn_messages.Image")));
            this.btn_messages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_messages.Location = new System.Drawing.Point(0, 250);
            this.btn_messages.Name = "btn_messages";
            this.btn_messages.Size = new System.Drawing.Size(160, 50);
            this.btn_messages.TabIndex = 5;
            this.btn_messages.Text = "Messages";
            this.btn_messages.UseVisualStyleBackColor = false;
            this.btn_messages.Click += new System.EventHandler(this.btn_messages_Click);
            // 
            // btn_forum
            // 
            this.btn_forum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_forum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_forum.FlatAppearance.BorderSize = 0;
            this.btn_forum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forum.ForeColor = System.Drawing.Color.White;
            this.btn_forum.Image = ((System.Drawing.Image)(resources.GetObject("btn_forum.Image")));
            this.btn_forum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_forum.Location = new System.Drawing.Point(0, 200);
            this.btn_forum.Name = "btn_forum";
            this.btn_forum.Size = new System.Drawing.Size(160, 50);
            this.btn_forum.TabIndex = 4;
            this.btn_forum.Text = "Forum";
            this.btn_forum.UseVisualStyleBackColor = false;
            this.btn_forum.Click += new System.EventHandler(this.btn_forum_Click);
            // 
            // btn_reminders
            // 
            this.btn_reminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_reminders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reminders.FlatAppearance.BorderSize = 0;
            this.btn_reminders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reminders.ForeColor = System.Drawing.Color.White;
            this.btn_reminders.Image = ((System.Drawing.Image)(resources.GetObject("btn_reminders.Image")));
            this.btn_reminders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reminders.Location = new System.Drawing.Point(0, 150);
            this.btn_reminders.Name = "btn_reminders";
            this.btn_reminders.Size = new System.Drawing.Size(160, 50);
            this.btn_reminders.TabIndex = 3;
            this.btn_reminders.Text = "Remindes";
            this.btn_reminders.UseVisualStyleBackColor = false;
            this.btn_reminders.Click += new System.EventHandler(this.btn_reminders_Click);
            // 
            // btn_appointments
            // 
            this.btn_appointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_appointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_appointments.FlatAppearance.BorderSize = 0;
            this.btn_appointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_appointments.ForeColor = System.Drawing.Color.White;
            this.btn_appointments.Image = ((System.Drawing.Image)(resources.GetObject("btn_appointments.Image")));
            this.btn_appointments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_appointments.Location = new System.Drawing.Point(0, 100);
            this.btn_appointments.Name = "btn_appointments";
            this.btn_appointments.Size = new System.Drawing.Size(160, 50);
            this.btn_appointments.TabIndex = 2;
            this.btn_appointments.Text = "Appointments";
            this.btn_appointments.UseVisualStyleBackColor = false;
            this.btn_appointments.Click += new System.EventHandler(this.btn_appointments_Click);
            // 
            // btn_patients
            // 
            this.btn_patients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_patients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_patients.FlatAppearance.BorderSize = 0;
            this.btn_patients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patients.ForeColor = System.Drawing.Color.White;
            this.btn_patients.Image = ((System.Drawing.Image)(resources.GetObject("btn_patients.Image")));
            this.btn_patients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_patients.Location = new System.Drawing.Point(0, 50);
            this.btn_patients.Name = "btn_patients";
            this.btn_patients.Size = new System.Drawing.Size(160, 50);
            this.btn_patients.TabIndex = 1;
            this.btn_patients.Text = "Patients";
            this.btn_patients.UseVisualStyleBackColor = false;
            this.btn_patients.Click += new System.EventHandler(this.btn_patients_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(160, 50);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.BackColor = System.Drawing.Color.Transparent;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(180, 60);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(825, 579);
            this.panel_main.TabIndex = 1;
            // 
            // btn_doctors
            // 
            this.btn_doctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_doctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_doctors.FlatAppearance.BorderSize = 0;
            this.btn_doctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doctors.ForeColor = System.Drawing.Color.White;
            this.btn_doctors.Image = ((System.Drawing.Image)(resources.GetObject("btn_doctors.Image")));
            this.btn_doctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doctors.Location = new System.Drawing.Point(0, 350);
            this.btn_doctors.Name = "btn_doctors";
            this.btn_doctors.Size = new System.Drawing.Size(160, 50);
            this.btn_doctors.TabIndex = 7;
            this.btn_doctors.Text = "Doctors";
            this.btn_doctors.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 659);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_nav);
            this.Name = "Home";
            this.Text = "MedCRM";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel_nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Button btn_payments;
        private System.Windows.Forms.Button btn_messages;
        private System.Windows.Forms.Button btn_forum;
        private System.Windows.Forms.Button btn_reminders;
        private System.Windows.Forms.Button btn_appointments;
        private System.Windows.Forms.Button btn_patients;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_doctors;
        private System.Windows.Forms.Button button1;
    }
}
