
namespace PatientManagementSystem
{
    partial class ConsultAppointmentForm
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
            this.DgvLabTests = new System.Windows.Forms.DataGridView();
            this.BtnRunTests = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLabTests)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 4;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpMain.Controls.Add(this.DgvLabTests, 1, 1);
            this.TlpMain.Controls.Add(this.BtnRunTests, 1, 3);
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
            this.TlpMain.Size = new System.Drawing.Size(672, 450);
            this.TlpMain.TabIndex = 0;
            // 
            // DgvLabTests
            // 
            this.DgvLabTests.AllowUserToAddRows = false;
            this.DgvLabTests.AllowUserToDeleteRows = false;
            this.DgvLabTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvLabTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TlpMain.SetColumnSpan(this.DgvLabTests, 2);
            this.DgvLabTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvLabTests.Location = new System.Drawing.Point(103, 93);
            this.DgvLabTests.Name = "DgvLabTests";
            this.DgvLabTests.ReadOnly = true;
            this.TlpMain.SetRowSpan(this.DgvLabTests, 2);
            this.DgvLabTests.RowTemplate.Height = 25;
            this.DgvLabTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLabTests.Size = new System.Drawing.Size(464, 174);
            this.DgvLabTests.TabIndex = 0;
            // 
            // BtnRunTests
            // 
            this.BtnRunTests.BackColor = System.Drawing.Color.LightGreen;
            this.BtnRunTests.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRunTests.FlatAppearance.BorderSize = 0;
            this.BtnRunTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRunTests.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRunTests.Location = new System.Drawing.Point(103, 273);
            this.BtnRunTests.Name = "BtnRunTests";
            this.BtnRunTests.Size = new System.Drawing.Size(229, 30);
            this.BtnRunTests.TabIndex = 1;
            this.BtnRunTests.Text = "Run Tests";
            this.BtnRunTests.UseVisualStyleBackColor = false;
            this.BtnRunTests.Click += new System.EventHandler(this.BtnRunTests_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.Location = new System.Drawing.Point(338, 273);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(229, 30);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ConsultAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.TlpMain);
            this.Name = "ConsultAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consult Appointment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultAppointmentForm_FormClosed);
            this.Load += new System.EventHandler(this.ConsultAppointmentForm_Load);
            this.TlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLabTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.DataGridView DgvLabTests;
        private System.Windows.Forms.Button BtnRunTests;
        private System.Windows.Forms.Button BtnCancel;
    }
}