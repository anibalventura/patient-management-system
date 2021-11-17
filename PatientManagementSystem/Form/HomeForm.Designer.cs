
namespace PatientManagementSystem
{
    partial class HomeForm
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
            this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.BtnDoctors = new System.Windows.Forms.Button();
            this.BtnLabTest = new System.Windows.Forms.Button();
            this.BtnPatients = new System.Windows.Forms.Button();
            this.BtnAppointments = new System.Windows.Forms.Button();
            this.BtnLabResults = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MsMain = new System.Windows.Forms.ToolStripMenuItem();
            this.MsItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.TlpMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 5;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.Controls.Add(this.BtnUsers, 1, 1);
            this.TlpMain.Controls.Add(this.BtnDoctors, 2, 1);
            this.TlpMain.Controls.Add(this.BtnLabTest, 3, 1);
            this.TlpMain.Controls.Add(this.BtnPatients, 1, 2);
            this.TlpMain.Controls.Add(this.BtnAppointments, 2, 2);
            this.TlpMain.Controls.Add(this.BtnLabResults, 3, 2);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 24);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 4;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpMain.Size = new System.Drawing.Size(672, 426);
            this.TlpMain.TabIndex = 0;
            // 
            // BtnUsers
            // 
            this.BtnUsers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnUsers.FlatAppearance.BorderSize = 0;
            this.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUsers.Location = new System.Drawing.Point(137, 178);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(128, 31);
            this.BtnUsers.TabIndex = 0;
            this.BtnUsers.Text = "Users";
            this.BtnUsers.UseVisualStyleBackColor = false;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnDoctors
            // 
            this.BtnDoctors.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnDoctors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnDoctors.FlatAppearance.BorderSize = 0;
            this.BtnDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoctors.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDoctors.Location = new System.Drawing.Point(271, 178);
            this.BtnDoctors.Name = "BtnDoctors";
            this.BtnDoctors.Size = new System.Drawing.Size(128, 31);
            this.BtnDoctors.TabIndex = 1;
            this.BtnDoctors.Text = "Doctors";
            this.BtnDoctors.UseVisualStyleBackColor = false;
            this.BtnDoctors.Click += new System.EventHandler(this.BtnDoctors_Click);
            // 
            // BtnLabTest
            // 
            this.BtnLabTest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnLabTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLabTest.FlatAppearance.BorderSize = 0;
            this.BtnLabTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLabTest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLabTest.Location = new System.Drawing.Point(405, 178);
            this.BtnLabTest.Name = "BtnLabTest";
            this.BtnLabTest.Size = new System.Drawing.Size(128, 31);
            this.BtnLabTest.TabIndex = 2;
            this.BtnLabTest.Text = "Lab Tests";
            this.BtnLabTest.UseVisualStyleBackColor = false;
            this.BtnLabTest.Click += new System.EventHandler(this.BtnLabTest_Click);
            // 
            // BtnPatients
            // 
            this.BtnPatients.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPatients.FlatAppearance.BorderSize = 0;
            this.BtnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatients.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPatients.Location = new System.Drawing.Point(137, 215);
            this.BtnPatients.Name = "BtnPatients";
            this.BtnPatients.Size = new System.Drawing.Size(128, 31);
            this.BtnPatients.TabIndex = 3;
            this.BtnPatients.Text = "Patients";
            this.BtnPatients.UseVisualStyleBackColor = false;
            this.BtnPatients.Click += new System.EventHandler(this.BtnPatients_Click);
            // 
            // BtnAppointments
            // 
            this.BtnAppointments.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAppointments.FlatAppearance.BorderSize = 0;
            this.BtnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAppointments.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAppointments.Location = new System.Drawing.Point(271, 215);
            this.BtnAppointments.Name = "BtnAppointments";
            this.BtnAppointments.Size = new System.Drawing.Size(128, 31);
            this.BtnAppointments.TabIndex = 4;
            this.BtnAppointments.Text = "Appointments";
            this.BtnAppointments.UseVisualStyleBackColor = false;
            this.BtnAppointments.Click += new System.EventHandler(this.BtnAppointments_Click);
            // 
            // BtnLabResults
            // 
            this.BtnLabResults.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnLabResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLabResults.FlatAppearance.BorderSize = 0;
            this.BtnLabResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLabResults.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLabResults.Location = new System.Drawing.Point(405, 215);
            this.BtnLabResults.Name = "BtnLabResults";
            this.BtnLabResults.Size = new System.Drawing.Size(128, 31);
            this.BtnLabResults.TabIndex = 5;
            this.BtnLabResults.Text = "Lab Results";
            this.BtnLabResults.UseVisualStyleBackColor = false;
            this.BtnLabResults.Click += new System.EventHandler(this.BtnLabResults_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MsMain
            // 
            this.MsMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsItemLogout});
            this.MsMain.Name = "MsMain";
            this.MsMain.Size = new System.Drawing.Size(50, 20);
            this.MsMain.Text = "Menu";
            // 
            // MsItemLogout
            // 
            this.MsItemLogout.Name = "MsItemLogout";
            this.MsItemLogout.Size = new System.Drawing.Size(112, 22);
            this.MsItemLogout.Text = "Logout";
            this.MsItemLogout.Click += new System.EventHandler(this.MsItemLogout_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.TlpMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.TlpMain.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Button BtnUsers;
        private System.Windows.Forms.Button BtnDoctors;
        private System.Windows.Forms.Button BtnLabTest;
        private System.Windows.Forms.Button BtnPatients;
        private System.Windows.Forms.Button BtnAppointments;
        private System.Windows.Forms.Button BtnLabResults;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MsMain;
        private System.Windows.Forms.ToolStripMenuItem MsItemLogout;
    }
}