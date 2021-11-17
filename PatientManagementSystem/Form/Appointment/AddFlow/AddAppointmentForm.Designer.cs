
namespace PatientManagementSystem
{
    partial class AddAppointmentForm
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
            this.LblPatient = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblAppointmentDate = new System.Windows.Forms.Label();
            this.LblAppointmentTime = new System.Windows.Forms.Label();
            this.LblCause = new System.Windows.Forms.Label();
            this.TxtBxPatient = new System.Windows.Forms.TextBox();
            this.TxtBxDoctor = new System.Windows.Forms.TextBox();
            this.TxtBxAppointmentDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtBxAppointmentTime = new System.Windows.Forms.MaskedTextBox();
            this.TxtBxCause = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 4;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpMain.Controls.Add(this.LblPatient, 1, 1);
            this.TlpMain.Controls.Add(this.label2, 1, 2);
            this.TlpMain.Controls.Add(this.LblAppointmentDate, 1, 3);
            this.TlpMain.Controls.Add(this.LblAppointmentTime, 1, 4);
            this.TlpMain.Controls.Add(this.LblCause, 1, 5);
            this.TlpMain.Controls.Add(this.TxtBxPatient, 2, 1);
            this.TlpMain.Controls.Add(this.TxtBxDoctor, 2, 2);
            this.TlpMain.Controls.Add(this.TxtBxAppointmentDate, 2, 3);
            this.TlpMain.Controls.Add(this.TxtBxAppointmentTime, 2, 4);
            this.TlpMain.Controls.Add(this.TxtBxCause, 2, 5);
            this.TlpMain.Controls.Add(this.BtnBack, 1, 6);
            this.TlpMain.Controls.Add(this.BtnCreate, 2, 6);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 7;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TlpMain.Size = new System.Drawing.Size(674, 450);
            this.TlpMain.TabIndex = 0;
            // 
            // LblPatient
            // 
            this.LblPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPatient.AutoSize = true;
            this.LblPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPatient.Location = new System.Drawing.Point(272, 64);
            this.LblPatient.Name = "LblPatient";
            this.LblPatient.Size = new System.Drawing.Size(61, 21);
            this.LblPatient.TabIndex = 0;
            this.LblPatient.Text = "Patient";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(272, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor";
            // 
            // LblAppointmentDate
            // 
            this.LblAppointmentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAppointmentDate.AutoSize = true;
            this.LblAppointmentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAppointmentDate.Location = new System.Drawing.Point(188, 192);
            this.LblAppointmentDate.Name = "LblAppointmentDate";
            this.LblAppointmentDate.Size = new System.Drawing.Size(145, 21);
            this.LblAppointmentDate.TabIndex = 2;
            this.LblAppointmentDate.Text = "Appointment date";
            // 
            // LblAppointmentTime
            // 
            this.LblAppointmentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAppointmentTime.AutoSize = true;
            this.LblAppointmentTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAppointmentTime.Location = new System.Drawing.Point(188, 256);
            this.LblAppointmentTime.Name = "LblAppointmentTime";
            this.LblAppointmentTime.Size = new System.Drawing.Size(145, 21);
            this.LblAppointmentTime.TabIndex = 3;
            this.LblAppointmentTime.Text = "Appointment time";
            // 
            // LblCause
            // 
            this.LblCause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCause.AutoSize = true;
            this.LblCause.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCause.Location = new System.Drawing.Point(280, 320);
            this.LblCause.Name = "LblCause";
            this.LblCause.Size = new System.Drawing.Size(53, 21);
            this.LblCause.TabIndex = 4;
            this.LblCause.Text = "Cause";
            // 
            // TxtBxPatient
            // 
            this.TxtBxPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxPatient.Enabled = false;
            this.TxtBxPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxPatient.Location = new System.Drawing.Point(339, 67);
            this.TxtBxPatient.Name = "TxtBxPatient";
            this.TxtBxPatient.Size = new System.Drawing.Size(229, 29);
            this.TxtBxPatient.TabIndex = 5;
            // 
            // TxtBxDoctor
            // 
            this.TxtBxDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxDoctor.Enabled = false;
            this.TxtBxDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxDoctor.Location = new System.Drawing.Point(339, 131);
            this.TxtBxDoctor.Name = "TxtBxDoctor";
            this.TxtBxDoctor.Size = new System.Drawing.Size(229, 29);
            this.TxtBxDoctor.TabIndex = 6;
            // 
            // TxtBxAppointmentDate
            // 
            this.TxtBxAppointmentDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxAppointmentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxAppointmentDate.Location = new System.Drawing.Point(339, 195);
            this.TxtBxAppointmentDate.Mask = "00/00/0000";
            this.TxtBxAppointmentDate.Name = "TxtBxAppointmentDate";
            this.TxtBxAppointmentDate.Size = new System.Drawing.Size(229, 29);
            this.TxtBxAppointmentDate.TabIndex = 7;
            this.TxtBxAppointmentDate.ValidatingType = typeof(System.DateTime);
            // 
            // TxtBxAppointmentTime
            // 
            this.TxtBxAppointmentTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxAppointmentTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxAppointmentTime.Location = new System.Drawing.Point(339, 259);
            this.TxtBxAppointmentTime.Mask = "90:00";
            this.TxtBxAppointmentTime.Name = "TxtBxAppointmentTime";
            this.TxtBxAppointmentTime.Size = new System.Drawing.Size(229, 29);
            this.TxtBxAppointmentTime.TabIndex = 8;
            this.TxtBxAppointmentTime.ValidatingType = typeof(System.DateTime);
            // 
            // TxtBxCause
            // 
            this.TxtBxCause.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxCause.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxCause.Location = new System.Drawing.Point(339, 323);
            this.TxtBxCause.Name = "TxtBxCause";
            this.TxtBxCause.Size = new System.Drawing.Size(229, 29);
            this.TxtBxCause.TabIndex = 9;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.Location = new System.Drawing.Point(104, 387);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 30);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.LightGreen;
            this.BtnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCreate.Location = new System.Drawing.Point(339, 387);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(229, 30);
            this.BtnCreate.TabIndex = 11;
            this.BtnCreate.Text = "Create appointment";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.TlpMain);
            this.Name = "AddAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddAppointmentForm_FormClosed);
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            this.TlpMain.ResumeLayout(false);
            this.TlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Label LblPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAppointmentDate;
        private System.Windows.Forms.Label LblAppointmentTime;
        private System.Windows.Forms.Label LblCause;
        private System.Windows.Forms.TextBox TxtBxPatient;
        private System.Windows.Forms.TextBox TxtBxDoctor;
        private System.Windows.Forms.MaskedTextBox TxtBxAppointmentDate;
        private System.Windows.Forms.MaskedTextBox TxtBxAppointmentTime;
        private System.Windows.Forms.TextBox TxtBxCause;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnCreate;
    }
}