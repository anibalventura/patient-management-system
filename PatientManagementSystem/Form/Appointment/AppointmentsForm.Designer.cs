
namespace PatientManagementSystem
{
    partial class AppointmentsForm
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnConsult = new System.Windows.Forms.Button();
            this.BtnSeeResults = new System.Windows.Forms.Button();
            this.BtnConsultResults = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.DgvAppointments = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 6;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.00128F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.49974F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.49974F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.49974F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.49974F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.99978F));
            this.TlpMain.Controls.Add(this.BtnAdd, 1, 0);
            this.TlpMain.Controls.Add(this.BtnConsult, 1, 3);
            this.TlpMain.Controls.Add(this.BtnSeeResults, 3, 3);
            this.TlpMain.Controls.Add(this.BtnConsultResults, 2, 3);
            this.TlpMain.Controls.Add(this.BtnBack, 1, 4);
            this.TlpMain.Controls.Add(this.DgvAppointments, 1, 1);
            this.TlpMain.Controls.Add(this.BtnDelete, 4, 3);
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
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.TlpMain.SetColumnSpan(this.BtnAdd, 4);
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(104, 57);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(466, 30);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add new appointment";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnConsult
            // 
            this.BtnConsult.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnConsult.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsult.FlatAppearance.BorderSize = 0;
            this.BtnConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConsult.Location = new System.Drawing.Point(104, 273);
            this.BtnConsult.Name = "BtnConsult";
            this.BtnConsult.Size = new System.Drawing.Size(112, 30);
            this.BtnConsult.TabIndex = 1;
            this.BtnConsult.Text = "Consult";
            this.BtnConsult.UseVisualStyleBackColor = false;
            this.BtnConsult.Click += new System.EventHandler(this.BtnConsult_Click);
            // 
            // BtnSeeResults
            // 
            this.BtnSeeResults.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSeeResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSeeResults.FlatAppearance.BorderSize = 0;
            this.BtnSeeResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeeResults.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSeeResults.Location = new System.Drawing.Point(340, 273);
            this.BtnSeeResults.Name = "BtnSeeResults";
            this.BtnSeeResults.Size = new System.Drawing.Size(112, 30);
            this.BtnSeeResults.TabIndex = 2;
            this.BtnSeeResults.Text = "See results";
            this.BtnSeeResults.UseVisualStyleBackColor = false;
            this.BtnSeeResults.Click += new System.EventHandler(this.BtnSeeResults_Click);
            // 
            // BtnConsultResults
            // 
            this.BtnConsultResults.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnConsultResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultResults.FlatAppearance.BorderSize = 0;
            this.BtnConsultResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultResults.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConsultResults.Location = new System.Drawing.Point(222, 273);
            this.BtnConsultResults.Name = "BtnConsultResults";
            this.BtnConsultResults.Size = new System.Drawing.Size(112, 30);
            this.BtnConsultResults.TabIndex = 3;
            this.BtnConsultResults.Text = "Cslt. results";
            this.BtnConsultResults.UseVisualStyleBackColor = false;
            this.BtnConsultResults.Click += new System.EventHandler(this.BtnConsultResults_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TlpMain.SetColumnSpan(this.BtnBack, 4);
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.Location = new System.Drawing.Point(299, 363);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 30);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DgvAppointments
            // 
            this.DgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TlpMain.SetColumnSpan(this.DgvAppointments, 4);
            this.DgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAppointments.Location = new System.Drawing.Point(104, 93);
            this.DgvAppointments.Name = "DgvAppointments";
            this.TlpMain.SetRowSpan(this.DgvAppointments, 2);
            this.DgvAppointments.RowTemplate.Height = 25;
            this.DgvAppointments.Size = new System.Drawing.Size(466, 174);
            this.DgvAppointments.TabIndex = 5;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(458, 273);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(112, 30);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.TlpMain);
            this.Name = "AppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppointmentsForm_FormClosed);
            this.Load += new System.EventHandler(this.AppointmentsForm_Load);
            this.VisibleChanged += new System.EventHandler(this.AppointmentsForm_VisibleChanged);
            this.TlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnConsult;
        private System.Windows.Forms.Button BtnSeeResults;
        private System.Windows.Forms.Button BtnConsultResults;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridView DgvAppointments;
        private System.Windows.Forms.Button BtnDelete;
    }
}