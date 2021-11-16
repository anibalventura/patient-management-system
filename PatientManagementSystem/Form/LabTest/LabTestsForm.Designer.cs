
namespace PatientManagementSystem
{
    partial class LabTestsForm
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
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DgvLabTests = new System.Windows.Forms.DataGridView();
            this.BtnBack = new System.Windows.Forms.Button();
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
            this.TlpMain.Controls.Add(this.BtnAdd, 1, 0);
            this.TlpMain.Controls.Add(this.BtnEdit, 1, 3);
            this.TlpMain.Controls.Add(this.BtnDelete, 2, 3);
            this.TlpMain.Controls.Add(this.DgvLabTests, 1, 1);
            this.TlpMain.Controls.Add(this.BtnBack, 1, 4);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 5;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.33333F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.44444F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.Size = new System.Drawing.Size(675, 450);
            this.TlpMain.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.TlpMain.SetColumnSpan(this.BtnAdd, 2);
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(104, 57);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(466, 30);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add new lab test";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEdit.Location = new System.Drawing.Point(104, 297);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(230, 30);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(340, 297);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(230, 30);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DgvLabTests
            // 
            this.DgvLabTests.AllowUserToAddRows = false;
            this.DgvLabTests.AllowUserToDeleteRows = false;
            this.DgvLabTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TlpMain.SetColumnSpan(this.DgvLabTests, 2);
            this.DgvLabTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvLabTests.Location = new System.Drawing.Point(104, 93);
            this.DgvLabTests.MultiSelect = false;
            this.DgvLabTests.Name = "DgvLabTests";
            this.DgvLabTests.ReadOnly = true;
            this.TlpMain.SetRowSpan(this.DgvLabTests, 2);
            this.DgvLabTests.RowTemplate.Height = 25;
            this.DgvLabTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLabTests.Size = new System.Drawing.Size(466, 198);
            this.DgvLabTests.TabIndex = 3;
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TlpMain.SetColumnSpan(this.BtnBack, 2);
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.Location = new System.Drawing.Point(299, 362);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 30);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LabTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.TlpMain);
            this.Name = "LabTestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Tests";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LabTestsForm_FormClosed);
            this.Load += new System.EventHandler(this.LabTestsForm_Load);
            this.VisibleChanged += new System.EventHandler(this.LabTestsForm_VisibleChanged);
            this.TlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLabTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView DgvLabTests;
        private System.Windows.Forms.Button BtnBack;
    }
}