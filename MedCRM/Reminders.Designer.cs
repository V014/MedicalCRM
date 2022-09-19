namespace MedCRM
{
    partial class Reminders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminders));
            this.data_reminders = new System.Windows.Forms.DataGridView();
            this.panel_reminder = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel_details = new System.Windows.Forms.Panel();
            this.txt_description = new MetroFramework.Controls.MetroTextBox();
            this.txt_time = new MetroFramework.Controls.MetroTextBox();
            this.txt_title = new MetroFramework.Controls.MetroTextBox();
            this.txt_repeat = new MetroFramework.Controls.MetroComboBox();
            this.picture_profile = new System.Windows.Forms.PictureBox();
            this.txt_date = new MetroFramework.Controls.MetroDateTime();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_reminders)).BeginInit();
            this.panel_reminder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // data_reminders
            // 
            this.data_reminders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_reminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_reminders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_reminders.Location = new System.Drawing.Point(0, 218);
            this.data_reminders.Name = "data_reminders";
            this.data_reminders.Size = new System.Drawing.Size(814, 234);
            this.data_reminders.TabIndex = 0;
            this.data_reminders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_reminders_CellClick);
            // 
            // panel_reminder
            // 
            this.panel_reminder.Controls.Add(this.data_reminders);
            this.panel_reminder.Controls.Add(this.panel_details);
            this.panel_reminder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_reminder.Location = new System.Drawing.Point(0, 0);
            this.panel_reminder.Name = "panel_reminder";
            this.panel_reminder.Size = new System.Drawing.Size(814, 452);
            this.panel_reminder.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_set);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 43);
            this.panel1.TabIndex = 5;
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
            this.btn_set.Location = new System.Drawing.Point(454, 0);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(120, 43);
            this.btn_set.TabIndex = 5;
            this.btn_set.Text = "Set Reminder";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Roboto", 8F);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(574, 0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(120, 43);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Edit Reminder";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Roboto", 8F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(694, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(120, 43);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete Reminder";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.txt_description);
            this.panel_details.Controls.Add(this.txt_time);
            this.panel_details.Controls.Add(this.txt_title);
            this.panel_details.Controls.Add(this.txt_repeat);
            this.panel_details.Controls.Add(this.picture_profile);
            this.panel_details.Controls.Add(this.txt_date);
            this.panel_details.Controls.Add(this.label4);
            this.panel_details.Controls.Add(this.label1);
            this.panel_details.Controls.Add(this.label8);
            this.panel_details.Controls.Add(this.label3);
            this.panel_details.Controls.Add(this.label2);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_details.Location = new System.Drawing.Point(0, 0);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(814, 218);
            this.panel_details.TabIndex = 6;
            // 
            // txt_description
            // 
            // 
            // 
            // 
            this.txt_description.CustomButton.Image = null;
            this.txt_description.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txt_description.CustomButton.Name = "";
            this.txt_description.CustomButton.Size = new System.Drawing.Size(91, 91);
            this.txt_description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_description.CustomButton.TabIndex = 1;
            this.txt_description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_description.CustomButton.UseSelectable = true;
            this.txt_description.CustomButton.Visible = false;
            this.txt_description.Lines = new string[0];
            this.txt_description.Location = new System.Drawing.Point(389, 97);
            this.txt_description.MaxLength = 32767;
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.PasswordChar = '\0';
            this.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_description.SelectedText = "";
            this.txt_description.SelectionLength = 0;
            this.txt_description.SelectionStart = 0;
            this.txt_description.ShortcutsEnabled = true;
            this.txt_description.Size = new System.Drawing.Size(165, 93);
            this.txt_description.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_description.TabIndex = 4;
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
            this.txt_time.Location = new System.Drawing.Point(389, 33);
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
            this.txt_time.TabIndex = 3;
            this.txt_time.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_time.UseSelectable = true;
            this.txt_time.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_time.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_title
            // 
            // 
            // 
            // 
            this.txt_title.CustomButton.Image = null;
            this.txt_title.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_title.CustomButton.Name = "";
            this.txt_title.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_title.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_title.CustomButton.TabIndex = 1;
            this.txt_title.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_title.CustomButton.UseSelectable = true;
            this.txt_title.CustomButton.Visible = false;
            this.txt_title.Lines = new string[0];
            this.txt_title.Location = new System.Drawing.Point(207, 33);
            this.txt_title.MaxLength = 32767;
            this.txt_title.Name = "txt_title";
            this.txt_title.PasswordChar = '\0';
            this.txt_title.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_title.SelectedText = "";
            this.txt_title.SelectionLength = 0;
            this.txt_title.SelectionStart = 0;
            this.txt_title.ShortcutsEnabled = true;
            this.txt_title.Size = new System.Drawing.Size(165, 23);
            this.txt_title.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_title.TabIndex = 0;
            this.txt_title.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_title.UseSelectable = true;
            this.txt_title.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_title.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_repeat
            // 
            this.txt_repeat.FormattingEnabled = true;
            this.txt_repeat.ItemHeight = 23;
            this.txt_repeat.Items.AddRange(new object[] {
            "Never",
            "30 Minutes",
            "Once an hour",
            "Once a day",
            "Once a Week",
            "Once a Month",
            "Once  a Year"});
            this.txt_repeat.Location = new System.Drawing.Point(209, 97);
            this.txt_repeat.Name = "txt_repeat";
            this.txt_repeat.Size = new System.Drawing.Size(163, 29);
            this.txt_repeat.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_repeat.TabIndex = 1;
            this.txt_repeat.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_repeat.UseSelectable = true;
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
            this.txt_date.Location = new System.Drawing.Point(210, 161);
            this.txt_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(166, 29);
            this.txt_date.TabIndex = 2;
            this.txt_date.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(386, 74);
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
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(206, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Repeat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(386, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Time of Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(206, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date of Appointment";
            // 
            // Reminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.panel_reminder);
            this.Controls.Add(this.panel1);
            this.Name = "Reminders";
            this.Size = new System.Drawing.Size(814, 495);
            ((System.ComponentModel.ISupportInitialize)(this.data_reminders)).EndInit();
            this.panel_reminder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_details.ResumeLayout(false);
            this.panel_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView data_reminders;
        private System.Windows.Forms.Panel panel_reminder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel_details;
        private MetroFramework.Controls.MetroTextBox txt_description;
        private MetroFramework.Controls.MetroTextBox txt_time;
        private MetroFramework.Controls.MetroTextBox txt_title;
        private MetroFramework.Controls.MetroComboBox txt_repeat;
        private System.Windows.Forms.PictureBox picture_profile;
        private MetroFramework.Controls.MetroDateTime txt_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
