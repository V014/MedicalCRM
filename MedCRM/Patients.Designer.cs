namespace MedCRM
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel_details = new MetroFramework.Controls.MetroPanel();
            this.data_patients = new System.Windows.Forms.DataGridView();
            this.panel_picture = new System.Windows.Forms.Panel();
            this.txt_gender = new MetroFramework.Controls.MetroComboBox();
            this.txt_bloodtype = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picture_profile = new System.Windows.Forms.PictureBox();
            this.txt_birthday = new MetroFramework.Controls.MetroDateTime();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.txt_contact = new MetroFramework.Controls.MetroTextBox();
            this.txt_address = new MetroFramework.Controls.MetroTextBox();
            this.txt_notes = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.panel_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_patients)).BeginInit();
            this.panel_picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 43);
            this.panel1.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Roboto", 8F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(587, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 43);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Register";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Roboto", 8F);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(692, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(105, 43);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.data_patients);
            this.panel_details.Controls.Add(this.panel_picture);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_details.HorizontalScrollbarBarColor = true;
            this.panel_details.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_details.HorizontalScrollbarSize = 10;
            this.panel_details.Location = new System.Drawing.Point(0, 0);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(797, 448);
            this.panel_details.Style = MetroFramework.MetroColorStyle.Blue;
            this.panel_details.TabIndex = 2;
            this.panel_details.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_details.UseStyleColors = true;
            this.panel_details.VerticalScrollbarBarColor = true;
            this.panel_details.VerticalScrollbarHighlightOnWheel = false;
            this.panel_details.VerticalScrollbarSize = 10;
            // 
            // data_patients
            // 
            this.data_patients.AllowUserToAddRows = false;
            this.data_patients.AllowUserToDeleteRows = false;
            this.data_patients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_patients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_patients.Location = new System.Drawing.Point(0, 219);
            this.data_patients.Name = "data_patients";
            this.data_patients.ReadOnly = true;
            this.data_patients.Size = new System.Drawing.Size(797, 229);
            this.data_patients.TabIndex = 4;
            this.data_patients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_patients_CellClick);
            // 
            // panel_picture
            // 
            this.panel_picture.Controls.Add(this.txt_contact);
            this.panel_picture.Controls.Add(this.txt_notes);
            this.panel_picture.Controls.Add(this.txt_address);
            this.panel_picture.Controls.Add(this.txt_name);
            this.panel_picture.Controls.Add(this.txt_gender);
            this.panel_picture.Controls.Add(this.txt_bloodtype);
            this.panel_picture.Controls.Add(this.label6);
            this.panel_picture.Controls.Add(this.picture_profile);
            this.panel_picture.Controls.Add(this.txt_birthday);
            this.panel_picture.Controls.Add(this.label4);
            this.panel_picture.Controls.Add(this.label1);
            this.panel_picture.Controls.Add(this.label3);
            this.panel_picture.Controls.Add(this.label2);
            this.panel_picture.Controls.Add(this.label7);
            this.panel_picture.Controls.Add(this.label5);
            this.panel_picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_picture.Location = new System.Drawing.Point(0, 0);
            this.panel_picture.Name = "panel_picture";
            this.panel_picture.Size = new System.Drawing.Size(797, 219);
            this.panel_picture.TabIndex = 3;
            // 
            // txt_gender
            // 
            this.txt_gender.FormattingEnabled = true;
            this.txt_gender.ItemHeight = 23;
            this.txt_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txt_gender.Location = new System.Drawing.Point(563, 164);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(163, 29);
            this.txt_gender.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_gender.TabIndex = 6;
            this.txt_gender.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_gender.UseSelectable = true;
            // 
            // txt_bloodtype
            // 
            this.txt_bloodtype.FormattingEnabled = true;
            this.txt_bloodtype.ItemHeight = 23;
            this.txt_bloodtype.Items.AddRange(new object[] {
            "A",
            "A+",
            "A-",
            "AB",
            "B",
            "B+",
            "B-",
            "O",
            "O+",
            "O-"});
            this.txt_bloodtype.Location = new System.Drawing.Point(379, 164);
            this.txt_bloodtype.Name = "txt_bloodtype";
            this.txt_bloodtype.Size = new System.Drawing.Size(163, 29);
            this.txt_bloodtype.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_bloodtype.TabIndex = 6;
            this.txt_bloodtype.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_bloodtype.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(559, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Notes";
            // 
            // picture_profile
            // 
            this.picture_profile.Dock = System.Windows.Forms.DockStyle.Left;
            this.picture_profile.Image = ((System.Drawing.Image)(resources.GetObject("picture_profile.Image")));
            this.picture_profile.Location = new System.Drawing.Point(0, 0);
            this.picture_profile.Name = "picture_profile";
            this.picture_profile.Size = new System.Drawing.Size(186, 219);
            this.picture_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_profile.TabIndex = 0;
            this.picture_profile.TabStop = false;
            this.picture_profile.Click += new System.EventHandler(this.picture_profile_Click);
            // 
            // txt_birthday
            // 
            this.txt_birthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_birthday.Location = new System.Drawing.Point(196, 164);
            this.txt_birthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.txt_birthday.Name = "txt_birthday";
            this.txt_birthday.Size = new System.Drawing.Size(166, 29);
            this.txt_birthday.TabIndex = 3;
            this.txt_birthday.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(373, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(192, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(193, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(192, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(560, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(376, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Blood Type";
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(196, 33);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(165, 23);
            this.txt_name.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.TabIndex = 7;
            this.txt_name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_contact
            // 
            // 
            // 
            // 
            this.txt_contact.CustomButton.Image = null;
            this.txt_contact.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_contact.CustomButton.Name = "";
            this.txt_contact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_contact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_contact.CustomButton.TabIndex = 1;
            this.txt_contact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_contact.CustomButton.UseSelectable = true;
            this.txt_contact.CustomButton.Visible = false;
            this.txt_contact.Lines = new string[0];
            this.txt_contact.Location = new System.Drawing.Point(197, 104);
            this.txt_contact.MaxLength = 32767;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.PasswordChar = '\0';
            this.txt_contact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_contact.SelectedText = "";
            this.txt_contact.SelectionLength = 0;
            this.txt_contact.SelectionStart = 0;
            this.txt_contact.ShortcutsEnabled = true;
            this.txt_contact.Size = new System.Drawing.Size(165, 23);
            this.txt_contact.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_contact.TabIndex = 7;
            this.txt_contact.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_contact.UseSelectable = true;
            this.txt_contact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_contact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_address
            // 
            // 
            // 
            // 
            this.txt_address.CustomButton.Image = null;
            this.txt_address.CustomButton.Location = new System.Drawing.Point(73, 2);
            this.txt_address.CustomButton.Name = "";
            this.txt_address.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.txt_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_address.CustomButton.TabIndex = 1;
            this.txt_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_address.CustomButton.UseSelectable = true;
            this.txt_address.CustomButton.Visible = false;
            this.txt_address.Lines = new string[0];
            this.txt_address.Location = new System.Drawing.Point(379, 33);
            this.txt_address.MaxLength = 32767;
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(165, 94);
            this.txt_address.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_address.TabIndex = 7;
            this.txt_address.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_address.UseSelectable = true;
            this.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_notes
            // 
            // 
            // 
            // 
            this.txt_notes.CustomButton.Image = null;
            this.txt_notes.CustomButton.Location = new System.Drawing.Point(73, 2);
            this.txt_notes.CustomButton.Name = "";
            this.txt_notes.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.txt_notes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_notes.CustomButton.TabIndex = 1;
            this.txt_notes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_notes.CustomButton.UseSelectable = true;
            this.txt_notes.CustomButton.Visible = false;
            this.txt_notes.Lines = new string[0];
            this.txt_notes.Location = new System.Drawing.Point(561, 30);
            this.txt_notes.MaxLength = 32767;
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.PasswordChar = '\0';
            this.txt_notes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_notes.SelectedText = "";
            this.txt_notes.SelectionLength = 0;
            this.txt_notes.SelectionStart = 0;
            this.txt_notes.ShortcutsEnabled = true;
            this.txt_notes.Size = new System.Drawing.Size(165, 94);
            this.txt_notes.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_notes.TabIndex = 7;
            this.txt_notes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_notes.UseSelectable = true;
            this.txt_notes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_notes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.panel_details);
            this.Controls.Add(this.panel1);
            this.Name = "Patients";
            this.Size = new System.Drawing.Size(797, 491);
            this.panel1.ResumeLayout(false);
            this.panel_details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_patients)).EndInit();
            this.panel_picture.ResumeLayout(false);
            this.panel_picture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private MetroFramework.Controls.MetroPanel panel_details;
        public System.Windows.Forms.DataGridView data_patients;
        private System.Windows.Forms.Panel panel_picture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picture_profile;
        private MetroFramework.Controls.MetroDateTime txt_birthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox txt_bloodtype;
        private MetroFramework.Controls.MetroComboBox txt_gender;
        private MetroFramework.Controls.MetroTextBox txt_contact;
        private MetroFramework.Controls.MetroTextBox txt_address;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private MetroFramework.Controls.MetroTextBox txt_notes;
    }
}
