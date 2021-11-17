
namespace PatientManagementSystem
{
    partial class LabResultsForm
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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgvLabResults = new System.Windows.Forms.DataGridView();
            this.BtnReportResult = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.TlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.TxtBxPatientIdentification = new System.Windows.Forms.MaskedTextBox();
            this.LblPatientIdentification = new System.Windows.Forms.Label();
            this.TlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLabResults)).BeginInit();
            this.TlpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 4;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpMain.Controls.Add(this.BtnSearch, 2, 0);
            this.TlpMain.Controls.Add(this.DgvLabResults, 1, 1);
            this.TlpMain.Controls.Add(this.BtnReportResult, 1, 3);
            this.TlpMain.Controls.Add(this.BtnBack, 1, 4);
            this.TlpMain.Controls.Add(this.TlpSearch, 1, 0);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 5;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.Size = new System.Drawing.Size(676, 450);
            this.TlpMain.TabIndex = 0;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnSearch.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.Location = new System.Drawing.Point(340, 29);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(104, 31);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DgvLabResults
            // 
            this.DgvLabResults.AllowUserToAddRows = false;
            this.DgvLabResults.AllowUserToDeleteRows = false;
            this.DgvLabResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvLabResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TlpMain.SetColumnSpan(this.DgvLabResults, 2);
            this.DgvLabResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvLabResults.Location = new System.Drawing.Point(70, 93);
            this.DgvLabResults.MultiSelect = false;
            this.DgvLabResults.Name = "DgvLabResults";
            this.DgvLabResults.ReadOnly = true;
            this.TlpMain.SetRowSpan(this.DgvLabResults, 2);
            this.DgvLabResults.RowTemplate.Height = 25;
            this.DgvLabResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLabResults.Size = new System.Drawing.Size(534, 174);
            this.DgvLabResults.TabIndex = 3;
            // 
            // BtnReportResult
            // 
            this.BtnReportResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnReportResult.BackColor = System.Drawing.Color.SandyBrown;
            this.TlpMain.SetColumnSpan(this.BtnReportResult, 2);
            this.BtnReportResult.FlatAppearance.BorderSize = 0;
            this.BtnReportResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReportResult.Location = new System.Drawing.Point(276, 273);
            this.BtnReportResult.Name = "BtnReportResult";
            this.BtnReportResult.Size = new System.Drawing.Size(122, 35);
            this.BtnReportResult.TabIndex = 4;
            this.BtnReportResult.Text = "Report result";
            this.BtnReportResult.UseVisualStyleBackColor = false;
            this.BtnReportResult.Click += new System.EventHandler(this.BtnReportResult_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TlpMain.SetColumnSpan(this.BtnBack, 2);
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.Location = new System.Drawing.Point(299, 363);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 32);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TlpSearch
            // 
            this.TlpSearch.ColumnCount = 2;
            this.TlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.21212F));
            this.TlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.78788F));
            this.TlpSearch.Controls.Add(this.TxtBxPatientIdentification, 1, 0);
            this.TlpSearch.Controls.Add(this.LblPatientIdentification, 0, 0);
            this.TlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSearch.Location = new System.Drawing.Point(70, 3);
            this.TlpSearch.Name = "TlpSearch";
            this.TlpSearch.RowCount = 1;
            this.TlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.TlpSearch.Size = new System.Drawing.Size(264, 84);
            this.TlpSearch.TabIndex = 6;
            // 
            // TxtBxPatientIdentification
            // 
            this.TxtBxPatientIdentification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBxPatientIdentification.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBxPatientIdentification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxPatientIdentification.Location = new System.Drawing.Point(125, 27);
            this.TxtBxPatientIdentification.Mask = "000-0000000-0";
            this.TxtBxPatientIdentification.Name = "TxtBxPatientIdentification";
            this.TxtBxPatientIdentification.Size = new System.Drawing.Size(136, 29);
            this.TxtBxPatientIdentification.TabIndex = 2;
            // 
            // LblPatientIdentification
            // 
            this.LblPatientIdentification.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPatientIdentification.AutoSize = true;
            this.LblPatientIdentification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPatientIdentification.Location = new System.Drawing.Point(6, 31);
            this.LblPatientIdentification.Name = "LblPatientIdentification";
            this.LblPatientIdentification.Size = new System.Drawing.Size(113, 21);
            this.LblPatientIdentification.TabIndex = 3;
            this.LblPatientIdentification.Text = "Patient Identf.";
            // 
            // LabResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.TlpMain);
            this.Name = "LabResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Results";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LabResultsForm_FormClosed);
            this.Load += new System.EventHandler(this.LabResultsForm_Load);
            this.VisibleChanged += new System.EventHandler(this.LabResultsForm_VisibleChanged);
            this.TlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLabResults)).EndInit();
            this.TlpSearch.ResumeLayout(false);
            this.TlpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.MaskedTextBox TxtBxPatientIdentification;
        private System.Windows.Forms.DataGridView DgvLabResults;
        private System.Windows.Forms.Button BtnReportResult;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TableLayoutPanel TlpSearch;
        private System.Windows.Forms.Label LblPatientIdentification;
    }
}