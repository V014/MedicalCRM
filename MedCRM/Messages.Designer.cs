namespace MedCRM
{
    partial class Messages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messages));
            this.data_texts = new System.Windows.Forms.DataGridView();
            this.data_messages = new System.Windows.Forms.DataGridView();
            this.txt_from = new MetroFramework.Controls.MetroTextBox();
            this.txt_to = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_comment = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_text = new MetroFramework.Controls.MetroTextBox();
            this.panel_details = new System.Windows.Forms.Panel();
            this.txt_date = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_texts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_messages)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_details.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_texts
            // 
            this.data_texts.AllowUserToAddRows = false;
            this.data_texts.AllowUserToDeleteRows = false;
            this.data_texts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_texts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_texts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_texts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_texts.Location = new System.Drawing.Point(203, 36);
            this.data_texts.Name = "data_texts";
            this.data_texts.ReadOnly = true;
            this.data_texts.Size = new System.Drawing.Size(685, 425);
            this.data_texts.TabIndex = 0;
            // 
            // data_messages
            // 
            this.data_messages.AllowUserToAddRows = false;
            this.data_messages.AllowUserToDeleteRows = false;
            this.data_messages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_messages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_messages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_messages.Location = new System.Drawing.Point(19, 236);
            this.data_messages.Name = "data_messages";
            this.data_messages.ReadOnly = true;
            this.data_messages.Size = new System.Drawing.Size(165, 225);
            this.data_messages.TabIndex = 14;
            this.data_messages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_messages_CellClick);
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
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Inbox";
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
            this.btn_comment.Location = new System.Drawing.Point(445, 0);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Padding = new System.Windows.Forms.Padding(3);
            this.btn_comment.Size = new System.Drawing.Size(120, 42);
            this.btn_comment.TabIndex = 0;
            this.btn_comment.Text = "Send";
            this.btn_comment.UseVisualStyleBackColor = false;
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
            this.panel2.Controls.Add(this.txt_text);
            this.panel2.Controls.Add(this.btn_comment);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(203, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 42);
            this.panel2.TabIndex = 11;
            // 
            // txt_text
            // 
            // 
            // 
            // 
            this.txt_text.CustomButton.Image = null;
            this.txt_text.CustomButton.Location = new System.Drawing.Point(405, 2);
            this.txt_text.CustomButton.Name = "";
            this.txt_text.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txt_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_text.CustomButton.TabIndex = 1;
            this.txt_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_text.CustomButton.UseSelectable = true;
            this.txt_text.CustomButton.Visible = false;
            this.txt_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_text.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_text.Lines = new string[0];
            this.txt_text.Location = new System.Drawing.Point(0, 0);
            this.txt_text.MaxLength = 32767;
            this.txt_text.Name = "txt_text";
            this.txt_text.PasswordChar = '\0';
            this.txt_text.PromptText = "Write message here...";
            this.txt_text.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_text.SelectedText = "";
            this.txt_text.SelectionLength = 0;
            this.txt_text.SelectionStart = 0;
            this.txt_text.ShortcutsEnabled = true;
            this.txt_text.Size = new System.Drawing.Size(445, 42);
            this.txt_text.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_text.TabIndex = 0;
            this.txt_text.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_text.UseSelectable = true;
            this.txt_text.WaterMark = "Write message here...";
            this.txt_text.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_text.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.data_messages);
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
            this.panel_top.Controls.Add(this.label4);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(203, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(685, 36);
            this.panel_top.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chat";
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.data_texts);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_details);
            this.Name = "Messages";
            this.Size = new System.Drawing.Size(888, 503);
            ((System.ComponentModel.ISupportInitialize)(this.data_texts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_messages)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_details.ResumeLayout(false);
            this.panel_details.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView data_texts;
        public System.Windows.Forms.DataGridView data_messages;
        private MetroFramework.Controls.MetroTextBox txt_from;
        private MetroFramework.Controls.MetroTextBox txt_to;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_comment;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox txt_text;
        private System.Windows.Forms.Panel panel_details;
        private MetroFramework.Controls.MetroTextBox txt_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label4;
    }
}
