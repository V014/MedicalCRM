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
            this.data_patients = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.panel_patients = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.data_patients)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_patients.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_patients
            // 
            this.data_patients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_patients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_patients.Location = new System.Drawing.Point(0, 0);
            this.data_patients.Name = "data_patients";
            this.data_patients.Size = new System.Drawing.Size(746, 448);
            this.data_patients.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 43);
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
            this.btn_add.Location = new System.Drawing.Point(536, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 43);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add Patient";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Roboto", 8F);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(641, 0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(105, 43);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit Record";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // panel_patients
            // 
            this.panel_patients.Controls.Add(this.data_patients);
            this.panel_patients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_patients.Location = new System.Drawing.Point(0, 0);
            this.panel_patients.Name = "panel_patients";
            this.panel_patients.Size = new System.Drawing.Size(746, 448);
            this.panel_patients.TabIndex = 2;
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.panel_patients);
            this.Controls.Add(this.panel1);
            this.Name = "Patients";
            this.Size = new System.Drawing.Size(746, 491);
            ((System.ComponentModel.ISupportInitialize)(this.data_patients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_patients.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView data_patients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel_patients;
        private System.Windows.Forms.Button btn_edit;
    }
}
