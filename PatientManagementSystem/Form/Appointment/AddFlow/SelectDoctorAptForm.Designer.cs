
namespace PatientManagementSystem
{
    partial class SelectDoctorAptForm
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
            this.TlpDoctorIdentf = new System.Windows.Forms.TableLayoutPanel();
            this.LblDoctorIdentification = new System.Windows.Forms.Label();
            this.TxtBxDoctorIdentification = new System.Windows.Forms.MaskedTextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.DgvDoctors = new System.Windows.Forms.DataGridView();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.TlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TlpMain.SuspendLayout();
            this.TlpDoctorIdentf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoctors)).BeginInit();
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
            this.TlpMain.Controls.Add(this.TlpDoctorIdentf, 1, 1);
            this.TlpMain.Controls.Add(this.LblTitle, 1, 0);
            this.TlpMain.Controls.Add(this.DgvDoctors, 1, 2);
            this.TlpMain.Controls.Add(this.BtnBack, 1, 4);
            this.TlpMain.Controls.Add(this.BtnNext, 2, 4);
            this.TlpMain.Controls.Add(this.TlpSearch, 2, 1);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 5;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.Size = new System.Drawing.Size(675, 450);
            this.TlpMain.TabIndex = 0;
            // 
            // TlpDoctorIdentf
            // 
            this.TlpDoctorIdentf.ColumnCount = 2;
            this.TlpDoctorIdentf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.82609F));
            this.TlpDoctorIdentf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.17391F));
            this.TlpDoctorIdentf.Controls.Add(this.LblDoctorIdentification, 0, 0);
            this.TlpDoctorIdentf.Controls.Add(this.TxtBxDoctorIdentification, 1, 0);
            this.TlpDoctorIdentf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpDoctorIdentf.Location = new System.Drawing.Point(104, 93);
            this.TlpDoctorIdentf.Name = "TlpDoctorIdentf";
            this.TlpDoctorIdentf.RowCount = 1;
            this.TlpDoctorIdentf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpDoctorIdentf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.TlpDoctorIdentf.Size = new System.Drawing.Size(230, 84);
            this.TlpDoctorIdentf.TabIndex = 0;
            // 
            // LblDoctorIdentification
            // 
            this.LblDoctorIdentification.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblDoctorIdentification.AutoSize = true;
            this.LblDoctorIdentification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDoctorIdentification.Location = new System.Drawing.Point(3, 31);
            this.LblDoctorIdentification.Name = "LblDoctorIdentification";
            this.LblDoctorIdentification.Size = new System.Drawing.Size(104, 21);
            this.LblDoctorIdentification.TabIndex = 0;
            this.LblDoctorIdentification.Text = "Doctor Idntf.";
            // 
            // TxtBxDoctorIdentification
            // 
            this.TxtBxDoctorIdentification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBxDoctorIdentification.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBxDoctorIdentification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxDoctorIdentification.Location = new System.Drawing.Point(113, 27);
            this.TxtBxDoctorIdentification.Mask = "000-0000000-0";
            this.TxtBxDoctorIdentification.Name = "TxtBxDoctorIdentification";
            this.TxtBxDoctorIdentification.Size = new System.Drawing.Size(114, 29);
            this.TxtBxDoctorIdentification.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitle.AutoSize = true;
            this.TlpMain.SetColumnSpan(this.LblTitle, 2);
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(267, 32);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(139, 25);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Select a doctor";
            // 
            // DgvDoctors
            // 
            this.DgvDoctors.AllowUserToAddRows = false;
            this.DgvDoctors.AllowUserToDeleteRows = false;
            this.DgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TlpMain.SetColumnSpan(this.DgvDoctors, 2);
            this.DgvDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDoctors.Location = new System.Drawing.Point(104, 183);
            this.DgvDoctors.MultiSelect = false;
            this.DgvDoctors.Name = "DgvDoctors";
            this.DgvDoctors.ReadOnly = true;
            this.TlpMain.SetRowSpan(this.DgvDoctors, 2);
            this.DgvDoctors.RowTemplate.Height = 25;
            this.DgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDoctors.Size = new System.Drawing.Size(466, 174);
            this.DgvDoctors.TabIndex = 3;
            this.DgvDoctors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDoctors_CellClick);
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
            this.BtnBack.Size = new System.Drawing.Size(75, 29);
            this.BtnBack.TabIndex = 4;
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
            this.BtnNext.Size = new System.Drawing.Size(75, 29);
            this.BtnNext.TabIndex = 5;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // TlpSearch
            // 
            this.TlpSearch.ColumnCount = 2;
            this.TlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpSearch.Controls.Add(this.BtnSearch, 0, 0);
            this.TlpSearch.Controls.Add(this.BtnClear, 1, 0);
            this.TlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSearch.Location = new System.Drawing.Point(340, 93);
            this.TlpSearch.Name = "TlpSearch";
            this.TlpSearch.RowCount = 1;
            this.TlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpSearch.Size = new System.Drawing.Size(230, 84);
            this.TlpSearch.TabIndex = 9;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.Location = new System.Drawing.Point(3, 26);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(109, 31);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClear.Location = new System.Drawing.Point(118, 27);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(109, 29);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // SelectDoctorAptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.TlpMain);
            this.Name = "SelectDoctorAptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment - Select Doctor";
            this.Load += new System.EventHandler(this.SelectDoctorAptForm_Load);
            this.TlpMain.ResumeLayout(false);
            this.TlpMain.PerformLayout();
            this.TlpDoctorIdentf.ResumeLayout(false);
            this.TlpDoctorIdentf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoctors)).EndInit();
            this.TlpSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.TableLayoutPanel TlpDoctorIdentf;
        private System.Windows.Forms.Label LblDoctorIdentification;
        private System.Windows.Forms.MaskedTextBox TxtBxDoctorIdentification;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.DataGridView DgvDoctors;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.TableLayoutPanel TlpSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnClear;
    }
}