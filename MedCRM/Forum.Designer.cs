namespace MedCRM
{
    partial class Forum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forum));
            this.data_comments = new System.Windows.Forms.DataGridView();
            this.panel_forum = new System.Windows.Forms.Panel();
            this.txt_comment = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_comment = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel_details = new System.Windows.Forms.Panel();
            this.txt_description = new MetroFramework.Controls.MetroTextBox();
            this.txt_title = new MetroFramework.Controls.MetroTextBox();
            this.picture_profile = new System.Windows.Forms.PictureBox();
            this.txt_date = new MetroFramework.Controls.MetroDateTime();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lead = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_time = new MetroFramework.Controls.MetroTextBox();
            this.data_forum = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_comments)).BeginInit();
            this.panel_forum.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_forum)).BeginInit();
            this.SuspendLayout();
            // 
            // data_comments
            // 
            this.data_comments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_comments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_comments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_comments.Location = new System.Drawing.Point(0, 218);
            this.data_comments.Name = "data_comments";
            this.data_comments.Size = new System.Drawing.Size(845, 227);
            this.data_comments.TabIndex = 0;
            // 
            // panel_forum
            // 
            this.panel_forum.Controls.Add(this.txt_comment);
            this.panel_forum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_forum.Location = new System.Drawing.Point(0, 445);
            this.panel_forum.Name = "panel_forum";
            this.panel_forum.Size = new System.Drawing.Size(845, 33);
            this.panel_forum.TabIndex = 8;
            // 
            // txt_comment
            // 
            // 
            // 
            // 
            this.txt_comment.CustomButton.Image = null;
            this.txt_comment.CustomButton.Location = new System.Drawing.Point(813, 1);
            this.txt_comment.CustomButton.Name = "";
            this.txt_comment.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txt_comment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_comment.CustomButton.TabIndex = 1;
            this.txt_comment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_comment.CustomButton.UseSelectable = true;
            this.txt_comment.CustomButton.Visible = false;
            this.txt_comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_comment.Lines = new string[0];
            this.txt_comment.Location = new System.Drawing.Point(0, 0);
            this.txt_comment.MaxLength = 32767;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.PasswordChar = '\0';
            this.txt_comment.PromptText = "Comment here...";
            this.txt_comment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_comment.SelectedText = "";
            this.txt_comment.SelectionLength = 0;
            this.txt_comment.SelectionStart = 0;
            this.txt_comment.ShortcutsEnabled = true;
            this.txt_comment.Size = new System.Drawing.Size(845, 33);
            this.txt_comment.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_comment.TabIndex = 0;
            this.txt_comment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_comment.UseSelectable = true;
            this.txt_comment.WaterMark = "Comment here...";
            this.txt_comment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_comment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_comment);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 43);
            this.panel1.TabIndex = 7;
            // 
            // btn_comment
            // 
            this.btn_comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_comment.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_comment.FlatAppearance.BorderSize = 0;
            this.btn_comment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comment.Font = new System.Drawing.Font("Roboto", 8F);
            this.btn_comment.ForeColor = System.Drawing.Color.White;
            this.btn_comment.Image = ((System.Drawing.Image)(resources.GetObject("btn_comment.Image")));
            this.btn_comment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_comment.Location = new System.Drawing.Point(605, 0);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Size = new System.Drawing.Size(120, 43);
            this.btn_comment.TabIndex = 0;
            this.btn_comment.Text = "Comment";
            this.btn_comment.UseVisualStyleBackColor = false;
            this.btn_comment.Click += new System.EventHandler(this.btn_comment_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Roboto", 8F);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(700, 156);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(120, 43);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit Forum";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Roboto", 8F);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(725, 0);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 43);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear text";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.btn_edit);
            this.panel_details.Controls.Add(this.btn_add);
            this.panel_details.Controls.Add(this.data_forum);
            this.panel_details.Controls.Add(this.txt_description);
            this.panel_details.Controls.Add(this.txt_time);
            this.panel_details.Controls.Add(this.txt_lead);
            this.panel_details.Controls.Add(this.txt_title);
            this.panel_details.Controls.Add(this.picture_profile);
            this.panel_details.Controls.Add(this.label6);
            this.panel_details.Controls.Add(this.label5);
            this.panel_details.Controls.Add(this.txt_date);
            this.panel_details.Controls.Add(this.label3);
            this.panel_details.Controls.Add(this.label4);
            this.panel_details.Controls.Add(this.label1);
            this.panel_details.Controls.Add(this.label2);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_details.Location = new System.Drawing.Point(0, 0);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(845, 218);
            this.panel_details.TabIndex = 9;
            // 
            // txt_description
            // 
            // 
            // 
            // 
            this.txt_description.CustomButton.Image = null;
            this.txt_description.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txt_description.CustomButton.Name = "";
            this.txt_description.CustomButton.Size = new System.Drawing.Size(93, 93);
            this.txt_description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_description.CustomButton.TabIndex = 1;
            this.txt_description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_description.CustomButton.UseSelectable = true;
            this.txt_description.CustomButton.Visible = false;
            this.txt_description.Lines = new string[0];
            this.txt_description.Location = new System.Drawing.Point(394, 104);
            this.txt_description.MaxLength = 32767;
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.PasswordChar = '\0';
            this.txt_description.PromptText = "Long description...";
            this.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_description.SelectedText = "";
            this.txt_description.SelectionLength = 0;
            this.txt_description.SelectionStart = 0;
            this.txt_description.ShortcutsEnabled = true;
            this.txt_description.Size = new System.Drawing.Size(165, 95);
            this.txt_description.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_description.TabIndex = 4;
            this.txt_description.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_description.UseSelectable = true;
            this.txt_description.WaterMark = "Long description...";
            this.txt_description.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_description.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_title.PromptText = "Short title...";
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
            this.txt_title.WaterMark = "Short title...";
            this.txt_title.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_title.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_date.Location = new System.Drawing.Point(207, 170);
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
            this.label4.Location = new System.Drawing.Point(391, 81);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date of Appointment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(202, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lead";
            // 
            // txt_lead
            // 
            // 
            // 
            // 
            this.txt_lead.CustomButton.Image = null;
            this.txt_lead.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_lead.CustomButton.Name = "";
            this.txt_lead.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_lead.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_lead.CustomButton.TabIndex = 1;
            this.txt_lead.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_lead.CustomButton.UseSelectable = true;
            this.txt_lead.CustomButton.Visible = false;
            this.txt_lead.Lines = new string[0];
            this.txt_lead.Location = new System.Drawing.Point(206, 104);
            this.txt_lead.MaxLength = 32767;
            this.txt_lead.Name = "txt_lead";
            this.txt_lead.PasswordChar = '\0';
            this.txt_lead.PromptText = "Who\'s leading...";
            this.txt_lead.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_lead.SelectedText = "";
            this.txt_lead.SelectionLength = 0;
            this.txt_lead.SelectionStart = 0;
            this.txt_lead.ShortcutsEnabled = true;
            this.txt_lead.Size = new System.Drawing.Size(165, 23);
            this.txt_lead.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_lead.TabIndex = 0;
            this.txt_lead.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_lead.UseSelectable = true;
            this.txt_lead.WaterMark = "Who\'s leading...";
            this.txt_lead.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_lead.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(390, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time";
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
            this.txt_time.Lines = new string[0];
            this.txt_time.Location = new System.Drawing.Point(394, 33);
            this.txt_time.MaxLength = 32767;
            this.txt_time.Name = "txt_time";
            this.txt_time.PasswordChar = '\0';
            this.txt_time.PromptText = "example: 9:00 AM";
            this.txt_time.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_time.SelectedText = "";
            this.txt_time.SelectionLength = 0;
            this.txt_time.SelectionStart = 0;
            this.txt_time.ShortcutsEnabled = true;
            this.txt_time.Size = new System.Drawing.Size(165, 23);
            this.txt_time.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_time.TabIndex = 0;
            this.txt_time.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_time.UseSelectable = true;
            this.txt_time.WaterMark = "example: 9:00 AM";
            this.txt_time.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_time.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // data_forum
            // 
            this.data_forum.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_forum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_forum.Location = new System.Drawing.Point(574, 33);
            this.data_forum.Name = "data_forum";
            this.data_forum.Size = new System.Drawing.Size(246, 110);
            this.data_forum.TabIndex = 14;
            this.data_forum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_forum_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(571, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Forum List";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Roboto", 8F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(574, 156);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 43);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add Forum";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Forum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.data_comments);
            this.Controls.Add(this.panel_details);
            this.Controls.Add(this.panel_forum);
            this.Controls.Add(this.panel1);
            this.Name = "Forum";
            this.Size = new System.Drawing.Size(845, 521);
            ((System.ComponentModel.ISupportInitialize)(this.data_comments)).EndInit();
            this.panel_forum.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_details.ResumeLayout(false);
            this.panel_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_forum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView data_comments;
        private System.Windows.Forms.Panel panel_forum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_comment;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_clear;
        private MetroFramework.Controls.MetroTextBox txt_comment;
        private System.Windows.Forms.Panel panel_details;
        private MetroFramework.Controls.MetroTextBox txt_description;
        private MetroFramework.Controls.MetroTextBox txt_lead;
        private MetroFramework.Controls.MetroTextBox txt_title;
        private System.Windows.Forms.PictureBox picture_profile;
        private MetroFramework.Controls.MetroDateTime txt_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txt_time;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView data_forum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_add;
    }
}
