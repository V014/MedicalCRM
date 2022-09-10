namespace MedCRM
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.panel_picture = new System.Windows.Forms.Panel();
            this.txt_gender = new MetroFramework.Controls.MetroComboBox();
            this.txt_bloodtype = new MetroFramework.Controls.MetroComboBox();
            this.txt_notes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.picture_profile = new System.Windows.Forms.PictureBox();
            this.txt_birthday = new MetroFramework.Controls.MetroDateTime();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel_picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_profile)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_picture
            // 
            this.panel_picture.Controls.Add(this.metroLabel1);
            this.panel_picture.Controls.Add(this.txt_bloodtype);
            this.panel_picture.Controls.Add(this.txt_notes);
            this.panel_picture.Controls.Add(this.label6);
            this.panel_picture.Controls.Add(this.txt_address);
            this.panel_picture.Controls.Add(this.txt_birthday);
            this.panel_picture.Controls.Add(this.label4);
            this.panel_picture.Controls.Add(this.label3);
            this.panel_picture.Controls.Add(this.label2);
            this.panel_picture.Controls.Add(this.txt_contact);
            this.panel_picture.Controls.Add(this.label5);
            this.panel_picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_picture.Location = new System.Drawing.Point(201, 0);
            this.panel_picture.Name = "panel_picture";
            this.panel_picture.Size = new System.Drawing.Size(692, 483);
            this.panel_picture.TabIndex = 4;
            // 
            // txt_gender
            // 
            this.txt_gender.FormattingEnabled = true;
            this.txt_gender.ItemHeight = 23;
            this.txt_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txt_gender.Location = new System.Drawing.Point(21, 406);
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
            this.txt_bloodtype.Location = new System.Drawing.Point(32, 261);
            this.txt_bloodtype.Name = "txt_bloodtype";
            this.txt_bloodtype.Size = new System.Drawing.Size(163, 29);
            this.txt_bloodtype.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_bloodtype.TabIndex = 6;
            this.txt_bloodtype.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_bloodtype.UseSelectable = true;
            // 
            // txt_notes
            // 
            this.txt_notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_notes.Font = new System.Drawing.Font("Roboto", 10F);
            this.txt_notes.ForeColor = System.Drawing.Color.Gray;
            this.txt_notes.Location = new System.Drawing.Point(240, 97);
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(220, 96);
            this.txt_notes.TabIndex = 5;
            this.txt_notes.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(236, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Notes";
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address.Font = new System.Drawing.Font("Roboto", 10F);
            this.txt_address.ForeColor = System.Drawing.Color.Gray;
            this.txt_address.Location = new System.Drawing.Point(32, 352);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(165, 83);
            this.txt_address.TabIndex = 4;
            this.txt_address.Text = "";
            // 
            // picture_profile
            // 
            this.picture_profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.picture_profile.Image = ((System.Drawing.Image)(resources.GetObject("picture_profile.Image")));
            this.picture_profile.Location = new System.Drawing.Point(0, 0);
            this.picture_profile.Name = "picture_profile";
            this.picture_profile.Size = new System.Drawing.Size(201, 219);
            this.picture_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_profile.TabIndex = 0;
            this.picture_profile.TabStop = false;
            // 
            // txt_birthday
            // 
            this.txt_birthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_birthday.Location = new System.Drawing.Point(32, 164);
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
            this.label4.Location = new System.Drawing.Point(28, 329);
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
            this.label1.Location = new System.Drawing.Point(15, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Roboto", 10F);
            this.txt_name.ForeColor = System.Drawing.Color.Gray;
            this.txt_name.Location = new System.Drawing.Point(18, 336);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(166, 17);
            this.txt_name.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 72);
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
            this.label2.Location = new System.Drawing.Point(28, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date of Birth";
            // 
            // txt_contact
            // 
            this.txt_contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contact.Font = new System.Drawing.Font("Roboto", 10F);
            this.txt_contact.ForeColor = System.Drawing.Color.Gray;
            this.txt_contact.Location = new System.Drawing.Point(31, 97);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(166, 17);
            this.txt_contact.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 376);
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
            this.label5.Location = new System.Drawing.Point(29, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Blood Type";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txt_gender);
            this.metroPanel1.Controls.Add(this.metroComboBox1);
            this.metroPanel1.Controls.Add(this.picture_profile);
            this.metroPanel1.Controls.Add(this.label8);
            this.metroPanel1.Controls.Add(this.txt_name);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.label7);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(201, 483);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Initials";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Doctor",
            "Dr",
            "Professor",
            "Nurse",
            "Mr",
            "Miss",
            "Mrs"});
            this.metroComboBox1.Location = new System.Drawing.Point(18, 261);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(163, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroComboBox1.TabIndex = 6;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(21, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(475, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Describe you field of research and discuss your achievements";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.panel_picture);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(893, 483);
            this.panel_picture.ResumeLayout(false);
            this.panel_picture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_profile)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_picture;
        private MetroFramework.Controls.MetroComboBox txt_gender;
        private MetroFramework.Controls.MetroComboBox txt_bloodtype;
        private System.Windows.Forms.RichTextBox txt_notes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txt_address;
        private System.Windows.Forms.PictureBox picture_profile;
        private MetroFramework.Controls.MetroDateTime txt_birthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Label label8;
    }
}
