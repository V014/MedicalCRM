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
            this.data_messages = new System.Windows.Forms.DataGridView();
            this.panel_messages = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_messages)).BeginInit();
            this.panel_messages.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_messages
            // 
            this.data_messages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_messages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_messages.Location = new System.Drawing.Point(0, 0);
            this.data_messages.Name = "data_messages";
            this.data_messages.Size = new System.Drawing.Size(500, 357);
            this.data_messages.TabIndex = 0;
            // 
            // panel_messages
            // 
            this.panel_messages.Controls.Add(this.data_messages);
            this.panel_messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_messages.Location = new System.Drawing.Point(0, 0);
            this.panel_messages.Name = "panel_messages";
            this.panel_messages.Size = new System.Drawing.Size(500, 357);
            this.panel_messages.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_send);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 43);
            this.panel1.TabIndex = 7;
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
            this.btn_send.Location = new System.Drawing.Point(140, 0);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(120, 43);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "Send message";
            this.btn_send.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Roboto", 8F);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(260, 0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(120, 43);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit Message";
            this.btn_edit.UseVisualStyleBackColor = false;
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
            this.btn_cancel.Location = new System.Drawing.Point(380, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(120, 43);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Delete Message";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.panel_messages);
            this.Controls.Add(this.panel1);
            this.Name = "Messages";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.data_messages)).EndInit();
            this.panel_messages.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView data_messages;
        private System.Windows.Forms.Panel panel_messages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_cancel;
    }
}
