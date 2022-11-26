namespace MedCRM
{
    partial class Login
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
            MetroFramework.Controls.MetroButton btn_login;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_pincode = new MetroFramework.Controls.MetroTextBox();
            this.lbl_pincode = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btn_login = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            btn_login.Location = new System.Drawing.Point(0, 108);
            btn_login.Name = "btn_login";
            btn_login.Size = new System.Drawing.Size(256, 32);
            btn_login.Style = MetroFramework.MetroColorStyle.Blue;
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.Theme = MetroFramework.MetroThemeStyle.Dark;
            btn_login.UseSelectable = true;
            btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(btn_login);
            this.panel1.Controls.Add(this.txt_pincode);
            this.panel1.Controls.Add(this.lbl_pincode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 140);
            this.panel1.TabIndex = 1;
            // 
            // txt_pincode
            // 
            // 
            // 
            // 
            this.txt_pincode.CustomButton.Image = null;
            this.txt_pincode.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txt_pincode.CustomButton.Name = "";
            this.txt_pincode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pincode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pincode.CustomButton.TabIndex = 1;
            this.txt_pincode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pincode.CustomButton.UseSelectable = true;
            this.txt_pincode.CustomButton.Visible = false;
            this.txt_pincode.Lines = new string[0];
            this.txt_pincode.Location = new System.Drawing.Point(20, 52);
            this.txt_pincode.MaxLength = 32767;
            this.txt_pincode.Name = "txt_pincode";
            this.txt_pincode.PasswordChar = '●';
            this.txt_pincode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pincode.SelectedText = "";
            this.txt_pincode.SelectionLength = 0;
            this.txt_pincode.SelectionStart = 0;
            this.txt_pincode.ShortcutsEnabled = true;
            this.txt_pincode.Size = new System.Drawing.Size(214, 23);
            this.txt_pincode.TabIndex = 1;
            this.txt_pincode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_pincode.UseSelectable = true;
            this.txt_pincode.UseSystemPasswordChar = true;
            this.txt_pincode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pincode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_pincode
            // 
            this.lbl_pincode.AutoSize = true;
            this.lbl_pincode.Location = new System.Drawing.Point(20, 23);
            this.lbl_pincode.Name = "lbl_pincode";
            this.lbl_pincode.Size = new System.Drawing.Size(56, 19);
            this.lbl_pincode.TabIndex = 2;
            this.lbl_pincode.Text = "Pincode";
            this.lbl_pincode.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txt_pincode;
        private MetroFramework.Controls.MetroLabel lbl_pincode;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}