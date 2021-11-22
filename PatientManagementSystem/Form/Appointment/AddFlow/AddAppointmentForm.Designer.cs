
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
            this.LblDate = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblCause = new System.Windows.Forms.Label();
            this.TxtBxPatient = new System.Windows.Forms.TextBox();
            this.TxtBxDoctor = new System.Windows.Forms.TextBox();
            this.TxtBxCause = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.DtpTime = new System.Windows.Forms.DateTimePicker();
            this.TlpSaveCancel = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TlpMain.SuspendLayout();
            this.TlpSaveCancel.SuspendLayout();
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
            this.TlpMain.Controls.Add(this.LblDate, 1, 3);
            this.TlpMain.Controls.Add(this.LblTime, 1, 4);
            this.TlpMain.Controls.Add(this.LblCause, 1, 5);
            this.TlpMain.Controls.Add(this.TxtBxPatient, 2, 1);
            this.TlpMain.Controls.Add(this.TxtBxDoctor, 2, 2);
            this.TlpMain.Controls.Add(this.TxtBxCause, 2, 5);
            this.TlpMain.Controls.Add(this.BtnBack, 1, 6);
            this.TlpMain.Controls.Add(this.DtpDate, 2, 3);
            this.TlpMain.Controls.Add(this.DtpTime, 2, 4);
            this.TlpMain.Controls.Add(this.TlpSaveCancel, 2, 6);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 7;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.22222F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.555555F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.111111F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.777778F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.88889F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.44444F));
            this.TlpMain.Size = new System.Drawing.Size(674, 450);
            this.TlpMain.TabIndex = 0;
            // 
            // LblPatient
            // 
            this.LblPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPatient.AutoSize = true;
            this.LblPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPatient.Location = new System.Drawing.Point(272, 117);
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
            this.label2.Location = new System.Drawing.Point(272, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor";
            // 
            // LblDate
            // 
            this.LblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDate.Location = new System.Drawing.Point(289, 205);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(44, 21);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "Date";
            // 
            // LblTime
            // 
            this.LblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTime.Location = new System.Drawing.Point(287, 246);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(46, 21);
            this.LblTime.TabIndex = 3;
            this.LblTime.Text = "Time";
            // 
            // LblCause
            // 
            this.LblCause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCause.AutoSize = true;
            this.LblCause.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCause.Location = new System.Drawing.Point(280, 290);
            this.LblCause.Name = "LblCause";
            this.LblCause.Size = new System.Drawing.Size(53, 21);
            this.LblCause.TabIndex = 4;
            this.LblCause.Text = "Cause";
            // 
            // TxtBxPatient
            // 
            this.TxtBxPatient.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBxPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxPatient.Enabled = false;
            this.TxtBxPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxPatient.Location = new System.Drawing.Point(339, 120);
            this.TxtBxPatient.Name = "TxtBxPatient";
            this.TxtBxPatient.Size = new System.Drawing.Size(229, 29);
            this.TxtBxPatient.TabIndex = 5;
            // 
            // TxtBxDoctor
            // 
            this.TxtBxDoctor.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBxDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxDoctor.Enabled = false;
            this.TxtBxDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxDoctor.Location = new System.Drawing.Point(339, 163);
            this.TxtBxDoctor.Name = "TxtBxDoctor";
            this.TxtBxDoctor.Size = new System.Drawing.Size(229, 29);
            this.TxtBxDoctor.TabIndex = 6;
            // 
            // TxtBxCause
            // 
            this.TxtBxCause.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBxCause.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxCause.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxCause.Location = new System.Drawing.Point(339, 293);
            this.TxtBxCause.Name = "TxtBxCause";
            this.TxtBxCause.Size = new System.Drawing.Size(229, 29);
            this.TxtBxCause.TabIndex = 9;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.Location = new System.Drawing.Point(104, 360);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 30);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DtpDate
            // 
            this.DtpDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.DtpDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpDate.Location = new System.Drawing.Point(339, 208);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(229, 25);
            this.DtpDate.TabIndex = 12;
            // 
            // DtpTime
            // 
            this.DtpTime.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.DtpTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpTime.Location = new System.Drawing.Point(339, 249);
            this.DtpTime.Name = "DtpTime";
            this.DtpTime.ShowUpDown = true;
            this.DtpTime.Size = new System.Drawing.Size(229, 29);
            this.DtpTime.TabIndex = 13;
            // 
            // TlpSaveCancel
            // 
            this.TlpSaveCancel.ColumnCount = 2;
            this.TlpSaveCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpSaveCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpSaveCancel.Controls.Add(this.BtnCancel, 1, 0);
            this.TlpSaveCancel.Controls.Add(this.BtnSave, 0, 0);
            this.TlpSaveCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSaveCancel.Location = new System.Drawing.Point(339, 360);
            this.TlpSaveCancel.Name = "TlpSaveCancel";
            this.TlpSaveCancel.RowCount = 1;
            this.TlpSaveCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSaveCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpSaveCancel.Size = new System.Drawing.Size(229, 87);
            this.TlpSaveCancel.TabIndex = 14;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.Location = new System.Drawing.Point(117, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(109, 30);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Location = new System.Drawing.Point(3, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(108, 30);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.TlpSaveCancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Label LblPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblCause;
        private System.Windows.Forms.TextBox TxtBxPatient;
        private System.Windows.Forms.TextBox TxtBxDoctor;
        private System.Windows.Forms.TextBox TxtBxCause;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.DateTimePicker DtpTime;
        private System.Windows.Forms.TableLayoutPanel TlpSaveCancel;
        private System.Windows.Forms.Button BtnCancel;
    }
}