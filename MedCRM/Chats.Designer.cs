namespace MedCRM
{
    partial class Chats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chats));
            this.data_in = new System.Windows.Forms.DataGridView();
            this.data_chats = new System.Windows.Forms.DataGridView();
            this.txt_from = new MetroFramework.Controls.MetroTextBox();
            this.txt_to = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_message = new MetroFramework.Controls.MetroTextBox();
            this.panel_details = new System.Windows.Forms.Panel();
            this.txt_date = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_to = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.data_out = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_from = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_chats)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_details.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_out)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_in
            // 
            this.data_in.AllowUserToAddRows = false;
            this.data_in.AllowUserToDeleteRows = false;
            this.data_in.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_in.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_in.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_in.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_in.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_in.Location = new System.Drawing.Point(0, 36);
            this.data_in.Name = "data_in";
            this.data_in.ReadOnly = true;
            this.data_in.ShowEditingIcon = false;
            this.data_in.Size = new System.Drawing.Size(340, 425);
            this.data_in.TabIndex = 0;
            // 
            // data_chats
            // 
            this.data_chats.AllowUserToAddRows = false;
            this.data_chats.AllowUserToDeleteRows = false;
            this.data_chats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_chats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_chats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_chats.Location = new System.Drawing.Point(19, 236);
            this.data_chats.Name = "data_chats";
            this.data_chats.ReadOnly = true;
            this.data_chats.Size = new System.Drawing.Size(165, 225);
            this.data_chats.TabIndex = 14;
            this.data_chats.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_chats_CellClick);
            // 
            // txt_from
            // 
            // 
            // 
            // 
            this.txt_from.CustomButton.Image = null;
            this.txt_from.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_from.CustomButton.Name = "";
            this.txt_from.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_from.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_from.CustomButton.TabIndex = 1;
            this.txt_from.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_from.CustomButton.UseSelectable = true;
            this.txt_from.CustomButton.Visible = false;
            this.txt_from.Lines = new string[0];
            this.txt_from.Location = new System.Drawing.Point(19, 101);
            this.txt_from.MaxLength = 32767;
            this.txt_from.Name = "txt_from";
            this.txt_from.PasswordChar = '\0';
            this.txt_from.PromptText = "Who sent it...";
            this.txt_from.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_from.SelectedText = "";
            this.txt_from.SelectionLength = 0;
            this.txt_from.SelectionStart = 0;
            this.txt_from.ShortcutsEnabled = true;
            this.txt_from.Size = new System.Drawing.Size(165, 23);
            this.txt_from.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_from.TabIndex = 0;
            this.txt_from.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_from.UseSelectable = true;
            this.txt_from.WaterMark = "Who sent it...";
            this.txt_from.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_from.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_to
            // 
            // 
            // 
            // 
            this.txt_to.CustomButton.Image = null;
            this.txt_to.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_to.CustomButton.Name = "";
            this.txt_to.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_to.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_to.CustomButton.TabIndex = 1;
            this.txt_to.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_to.CustomButton.UseSelectable = true;
            this.txt_to.CustomButton.Visible = false;
            this.txt_to.Lines = new string[0];
            this.txt_to.Location = new System.Drawing.Point(19, 33);
            this.txt_to.MaxLength = 32767;
            this.txt_to.Name = "txt_to";
            this.txt_to.PasswordChar = '\0';
            this.txt_to.PromptText = "Who it\'s going to...";
            this.txt_to.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_to.SelectedText = "";
            this.txt_to.SelectionLength = 0;
            this.txt_to.SelectionStart = 0;
            this.txt_to.ShortcutsEnabled = true;
            this.txt_to.Size = new System.Drawing.Size(165, 23);
            this.txt_to.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_to.TabIndex = 0;
            this.txt_to.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_to.UseSelectable = true;
            this.txt_to.WaterMark = "Who it\'s going to...";
            this.txt_to.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_to.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "To";
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_send.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Font = new System.Drawing.Font("Roboto", 8F);
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Image = ((System.Drawing.Image)(resources.GetObject("btn_send.Image")));
            this.btn_send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_send.Location = new System.Drawing.Point(445, 0);
            this.btn_send.Name = "btn_send";
            this.btn_send.Padding = new System.Windows.Forms.Padding(3);
            this.btn_send.Size = new System.Drawing.Size(120, 42);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
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
            this.btn_clear.Location = new System.Drawing.Point(565, 0);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Padding = new System.Windows.Forms.Padding(3);
            this.btn_clear.Size = new System.Drawing.Size(120, 42);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear text";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_message);
            this.panel2.Controls.Add(this.btn_send);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(203, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 42);
            this.panel2.TabIndex = 11;
            // 
            // txt_message
            // 
            // 
            // 
            // 
            this.txt_message.CustomButton.Image = null;
            this.txt_message.CustomButton.Location = new System.Drawing.Point(405, 2);
            this.txt_message.CustomButton.Name = "";
            this.txt_message.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txt_message.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_message.CustomButton.TabIndex = 1;
            this.txt_message.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_message.CustomButton.UseSelectable = true;
            this.txt_message.CustomButton.Visible = false;
            this.txt_message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_message.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_message.Lines = new string[0];
            this.txt_message.Location = new System.Drawing.Point(0, 0);
            this.txt_message.MaxLength = 32767;
            this.txt_message.Name = "txt_message";
            this.txt_message.PasswordChar = '\0';
            this.txt_message.PromptText = "Write message here...";
            this.txt_message.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_message.SelectedText = "";
            this.txt_message.SelectionLength = 0;
            this.txt_message.SelectionStart = 0;
            this.txt_message.ShortcutsEnabled = true;
            this.txt_message.Size = new System.Drawing.Size(445, 42);
            this.txt_message.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_message.TabIndex = 0;
            this.txt_message.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_message.UseSelectable = true;
            this.txt_message.WaterMark = "Write message here...";
            this.txt_message.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_message.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.data_chats);
            this.panel_details.Controls.Add(this.txt_date);
            this.panel_details.Controls.Add(this.txt_from);
            this.panel_details.Controls.Add(this.txt_to);
            this.panel_details.Controls.Add(this.label2);
            this.panel_details.Controls.Add(this.label6);
            this.panel_details.Controls.Add(this.label3);
            this.panel_details.Controls.Add(this.label1);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_details.Location = new System.Drawing.Point(0, 0);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(203, 503);
            this.panel_details.TabIndex = 13;
            // 
            // txt_date
            // 
            // 
            // 
            // 
            this.txt_date.CustomButton.Image = null;
            this.txt_date.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_date.CustomButton.Name = "";
            this.txt_date.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_date.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_date.CustomButton.TabIndex = 1;
            this.txt_date.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_date.CustomButton.UseSelectable = true;
            this.txt_date.CustomButton.Visible = false;
            this.txt_date.Lines = new string[0];
            this.txt_date.Location = new System.Drawing.Point(19, 173);
            this.txt_date.MaxLength = 32767;
            this.txt_date.Name = "txt_date";
            this.txt_date.PasswordChar = '\0';
            this.txt_date.PromptText = "Sent on...";
            this.txt_date.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_date.SelectedText = "";
            this.txt_date.SelectionLength = 0;
            this.txt_date.SelectionStart = 0;
            this.txt_date.ShortcutsEnabled = true;
            this.txt_date.Size = new System.Drawing.Size(165, 23);
            this.txt_date.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_date.TabIndex = 0;
            this.txt_date.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_date.UseSelectable = true;
            this.txt_date.WaterMark = "Sent on...";
            this.txt_date.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_date.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date and Time";
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.lbl_to);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(340, 36);
            this.panel_top.TabIndex = 14;
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_to.ForeColor = System.Drawing.Color.White;
            this.lbl_to.Location = new System.Drawing.Point(16, 10);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(40, 17);
            this.lbl_to.TabIndex = 11;
            this.lbl_to.Text = "From";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(203, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.data_in);
            this.splitContainer.Panel1.Controls.Add(this.panel_top);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.data_out);
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Size = new System.Drawing.Size(685, 461);
            this.splitContainer.SplitterDistance = 340;
            this.splitContainer.TabIndex = 15;
            // 
            // data_out
            // 
            this.data_out.AllowUserToAddRows = false;
            this.data_out.AllowUserToDeleteRows = false;
            this.data_out.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_out.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_out.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_out.Location = new System.Drawing.Point(0, 36);
            this.data_out.Name = "data_out";
            this.data_out.ReadOnly = true;
            this.data_out.ShowEditingIcon = false;
            this.data_out.Size = new System.Drawing.Size(341, 425);
            this.data_out.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_from);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 36);
            this.panel1.TabIndex = 15;
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_from.ForeColor = System.Drawing.Color.White;
            this.lbl_from.Location = new System.Drawing.Point(16, 10);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(40, 17);
            this.lbl_from.TabIndex = 11;
            this.lbl_from.Text = "From";
            // 
            // Chats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_details);
            this.Name = "Chats";
            this.Size = new System.Drawing.Size(888, 503);
            ((System.ComponentModel.ISupportInitialize)(this.data_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_chats)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_details.ResumeLayout(false);
            this.panel_details.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_out)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView data_in;
        public System.Windows.Forms.DataGridView data_chats;
        private MetroFramework.Controls.MetroTextBox txt_from;
        private MetroFramework.Controls.MetroTextBox txt_to;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox txt_message;
        private System.Windows.Forms.Panel panel_details;
        private MetroFramework.Controls.MetroTextBox txt_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.SplitContainer splitContainer;
        public System.Windows.Forms.DataGridView data_out;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_from;
    }
}
