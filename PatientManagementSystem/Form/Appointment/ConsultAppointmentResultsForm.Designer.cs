
namespace PatientManagementSystem
{
    partial class ConsultAppointmentResultsForm
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
            this.DgvLabResults = new System.Windows.Forms.DataGridView();
            this.BtnCompleteAppointment = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLabResults)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 4;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpMain.Controls.Add(this.DgvLabResults, 1, 1);
            this.TlpMain.Controls.Add(this.BtnCompleteAppointment, 1, 3);
            this.TlpMain.Controls.Add(this.BtnCancel, 2, 3);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 5;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.Size = new System.Drawing.Size(678, 450);
            this.TlpMain.TabIndex = 0;
            // 
            // DgvLabResults
            // 
            this.DgvLabResults.AllowUserToAddRows = false;
            this.DgvLabResults.AllowUserToDeleteRows = false;
            this.DgvLabResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvLabResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TlpMain.SetColumnSpan(this.DgvLabResults, 2);
            this.DgvLabResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvLabResults.Location = new System.Drawing.Point(104, 93);
            this.DgvLabResults.MultiSelect = false;
            this.DgvLabResults.Name = "DgvLabResults";
            this.DgvLabResults.ReadOnly = true;
            this.TlpMain.SetRowSpan(this.DgvLabResults, 2);
            this.DgvLabResults.RowTemplate.Height = 25;
            this.DgvLabResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLabResults.Size = new System.Drawing.Size(468, 174);
            this.DgvLabResults.TabIndex = 0;
            // 
            // BtnCompleteAppointment
            // 
            this.BtnCompleteAppointment.BackColor = System.Drawing.Color.LightGreen;
            this.BtnCompleteAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCompleteAppointment.FlatAppearance.BorderSize = 0;
            this.BtnCompleteAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompleteAppointment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCompleteAppointment.Location = new System.Drawing.Point(104, 273);
            this.BtnCompleteAppointment.Name = "BtnCompleteAppointment";
            this.BtnCompleteAppointment.Size = new System.Drawing.Size(231, 31);
            this.BtnCompleteAppointment.TabIndex = 1;
            this.BtnCompleteAppointment.Text = "Complete Appointment";
            this.BtnCompleteAppointment.UseVisualStyleBackColor = false;
            this.BtnCompleteAppointment.Click += new System.EventHandler(this.BtnCompleteAppointment_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.Location = new System.Drawing.Point(341, 273);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(231, 31);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ConsultAppointmentResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.TlpMain);
            this.Name = "ConsultAppointmentResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consult Appointment Results";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultAppointmentResultsForm_FormClosed);
            this.Load += new System.EventHandler(this.ConsultAppointmentResultsForm_Load);
            this.TlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLabResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.DataGridView DgvLabResults;
        private System.Windows.Forms.Button BtnCompleteAppointment;
        private System.Windows.Forms.Button BtnCancel;
    }
}