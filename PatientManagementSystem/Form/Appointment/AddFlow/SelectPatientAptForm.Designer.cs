
namespace PatientManagementSystem
{
    partial class SelectPatientAptForm
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.DgvPatients = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.LblPatientIdentification = new System.Windows.Forms.Label();
            this.TxtBxPatientIdentification = new System.Windows.Forms.MaskedTextBox();
            this.TlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPatients)).BeginInit();
            this.TlpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 4;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpMain.Controls.Add(this.BtnBack, 1, 4);
            this.TlpMain.Controls.Add(this.BtnNext, 2, 4);
            this.TlpMain.Controls.Add(this.DgvPatients, 1, 2);
            this.TlpMain.Controls.Add(this.BtnSearch, 2, 1);
            this.TlpMain.Controls.Add(this.LblTitle, 1, 0);
            this.TlpMain.Controls.Add(this.TlpSearch, 1, 1);
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
            // BtnBack
            // 
            this.BtnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.Location = new System.Drawing.Point(104, 390);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 30);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnNext.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNext.Location = new System.Drawing.Point(495, 390);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 30);
            this.BtnNext.TabIndex = 3;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // DgvPatients
            // 
            this.DgvPatients.AllowUserToAddRows = false;
            this.DgvPatients.AllowUserToDeleteRows = false;
            this.DgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TlpMain.SetColumnSpan(this.DgvPatients, 2);
            this.DgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPatients.Location = new System.Drawing.Point(104, 183);
            this.DgvPatients.MultiSelect = false;
            this.DgvPatients.Name = "DgvPatients";
            this.DgvPatients.ReadOnly = true;
            this.TlpMain.SetRowSpan(this.DgvPatients, 2);
            this.DgvPatients.RowTemplate.Height = 25;
            this.DgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPatients.Size = new System.Drawing.Size(466, 174);
            this.DgvPatients.TabIndex = 0;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnSearch.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.Location = new System.Drawing.Point(340, 120);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 30);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitle.AutoSize = true;
            this.TlpMain.SetColumnSpan(this.LblTitle, 2);
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(265, 32);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(144, 25);
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "Select a patient";
            // 
            // TlpSearch
            // 
            this.TlpSearch.ColumnCount = 2;
            this.TlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.82609F));
            this.TlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.17391F));
            this.TlpSearch.Controls.Add(this.LblPatientIdentification, 0, 0);
            this.TlpSearch.Controls.Add(this.TxtBxPatientIdentification, 1, 0);
            this.TlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSearch.Location = new System.Drawing.Point(104, 93);
            this.TlpSearch.Name = "TlpSearch";
            this.TlpSearch.RowCount = 1;
            this.TlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.TlpSearch.Size = new System.Drawing.Size(230, 84);
            this.TlpSearch.TabIndex = 5;
            // 
            // LblPatientIdentification
            // 
            this.LblPatientIdentification.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPatientIdentification.AutoSize = true;
            this.LblPatientIdentification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPatientIdentification.Location = new System.Drawing.Point(3, 31);
            this.LblPatientIdentification.Name = "LblPatientIdentification";
            this.LblPatientIdentification.Size = new System.Drawing.Size(104, 21);
            this.LblPatientIdentification.TabIndex = 0;
            this.LblPatientIdentification.Text = "Patient Idntf.";
            // 
            // TxtBxPatientIdentification
            // 
            this.TxtBxPatientIdentification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBxPatientIdentification.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBxPatientIdentification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxPatientIdentification.Location = new System.Drawing.Point(113, 27);
            this.TxtBxPatientIdentification.Mask = "000-0000000-0";
            this.TxtBxPatientIdentification.Name = "TxtBxPatientIdentification";
            this.TxtBxPatientIdentification.Size = new System.Drawing.Size(114, 29);
            this.TxtBxPatientIdentification.TabIndex = 1;
            // 
            // SelectPatientAptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.TlpMain);
            this.Name = "SelectPatientAptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment - Select Patient";
            this.Load += new System.EventHandler(this.SelectPatientAptForm_Load);
            this.TlpMain.ResumeLayout(false);
            this.TlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPatients)).EndInit();
            this.TlpSearch.ResumeLayout(false);
            this.TlpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.DataGridView DgvPatients;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TableLayoutPanel TlpSearch;
        private System.Windows.Forms.Label LblPatientIdentification;
        private System.Windows.Forms.MaskedTextBox TxtBxPatientIdentification;
    }
}