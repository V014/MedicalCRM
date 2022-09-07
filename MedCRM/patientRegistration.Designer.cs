namespace MedCRM
{
    partial class patientRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patientRegistration));
            this.panel_picture = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_picture = new System.Windows.Forms.Button();
            this.picture_profile = new System.Windows.Forms.PictureBox();
            this.panel_addPatient = new System.Windows.Forms.Panel();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.date = new MetroFramework.Controls.MetroDateTime();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel_picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_profile)).BeginInit();
            this.panel_addPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_picture
            // 
            this.panel_picture.Controls.Add(this.button4);
            this.panel_picture.Controls.Add(this.button1);
            this.panel_picture.Controls.Add(this.button3);
            this.panel_picture.Controls.Add(this.button2);
            this.panel_picture.Controls.Add(this.btn_picture);
            this.panel_picture.Controls.Add(this.picture_profile);
            this.panel_picture.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_picture.Location = new System.Drawing.Point(0, 0);
            this.panel_picture.Name = "panel_picture";
            this.panel_picture.Size = new System.Drawing.Size(205, 559);
            this.panel_picture.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove Image";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_picture
            // 
            this.btn_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_picture.FlatAppearance.BorderSize = 0;
            this.btn_picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_picture.ForeColor = System.Drawing.Color.White;
            this.btn_picture.Location = new System.Drawing.Point(0, 202);
            this.btn_picture.Name = "btn_picture";
            this.btn_picture.Size = new System.Drawing.Size(205, 60);
            this.btn_picture.TabIndex = 1;
            this.btn_picture.Text = "Add Image";
            this.btn_picture.UseVisualStyleBackColor = false;
            // 
            // picture_profile
            // 
            this.picture_profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.picture_profile.Image = ((System.Drawing.Image)(resources.GetObject("picture_profile.Image")));
            this.picture_profile.Location = new System.Drawing.Point(0, 0);
            this.picture_profile.Name = "picture_profile";
            this.picture_profile.Size = new System.Drawing.Size(205, 202);
            this.picture_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_profile.TabIndex = 0;
            this.picture_profile.TabStop = false;
            // 
            // panel_addPatient
            // 
            this.panel_addPatient.Controls.Add(this.txt_address);
            this.panel_addPatient.Controls.Add(this.date);
            this.panel_addPatient.Controls.Add(this.txt_contact);
            this.panel_addPatient.Controls.Add(this.label4);
            this.panel_addPatient.Controls.Add(this.txt_name);
            this.panel_addPatient.Controls.Add(this.label3);
            this.panel_addPatient.Controls.Add(this.label2);
            this.panel_addPatient.Controls.Add(this.label1);
            this.panel_addPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_addPatient.Location = new System.Drawing.Point(205, 0);
            this.panel_addPatient.Name = "panel_addPatient";
            this.panel_addPatient.Size = new System.Drawing.Size(740, 559);
            this.panel_addPatient.TabIndex = 2;
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_address.ForeColor = System.Drawing.Color.White;
            this.txt_address.Location = new System.Drawing.Point(38, 279);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(289, 193);
            this.txt_address.TabIndex = 3;
            this.txt_address.Text = "";
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(38, 211);
            this.date.MinimumSize = new System.Drawing.Size(0, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(289, 29);
            this.date.TabIndex = 2;
            this.date.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_contact
            // 
            this.txt_contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txt_contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_contact.ForeColor = System.Drawing.Color.White;
            this.txt_contact.Location = new System.Drawing.Point(38, 129);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(289, 31);
            this.txt_contact.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_name.ForeColor = System.Drawing.Color.White;
            this.txt_name.Location = new System.Drawing.Point(38, 52);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(289, 31);
            this.txt_name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add Records";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edit Records";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 60);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete Records";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // patientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.panel_addPatient);
            this.Controls.Add(this.panel_picture);
            this.Name = "patientRegistration";
            this.Size = new System.Drawing.Size(945, 559);
            this.panel_picture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_profile)).EndInit();
            this.panel_addPatient.ResumeLayout(false);
            this.panel_addPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_picture;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_picture;
        private System.Windows.Forms.PictureBox picture_profile;
        private System.Windows.Forms.Panel panel_addPatient;
        private System.Windows.Forms.RichTextBox txt_address;
        private MetroFramework.Controls.MetroDateTime date;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}
