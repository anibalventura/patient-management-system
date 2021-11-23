
namespace PatientManagementSystem
{
    partial class AddDoctorForm
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
            this.LblName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblIdentification = new System.Windows.Forms.Label();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.TxtBxLastName = new System.Windows.Forms.TextBox();
            this.TxtBxEmail = new System.Windows.Forms.TextBox();
            this.TxtBxPhone = new System.Windows.Forms.MaskedTextBox();
            this.BtnSelectPhoto = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtBxIdentification = new System.Windows.Forms.MaskedTextBox();
            this.PbDoctor = new System.Windows.Forms.PictureBox();
            this.LblProfilePhoto = new System.Windows.Forms.Label();
            this.PhotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.TlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 6;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.48071F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.902077F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.21662F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.22255F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpMain.Controls.Add(this.LblName, 3, 1);
            this.TlpMain.Controls.Add(this.LblLastName, 3, 2);
            this.TlpMain.Controls.Add(this.LblEmail, 3, 3);
            this.TlpMain.Controls.Add(this.LblPhone, 3, 4);
            this.TlpMain.Controls.Add(this.LblIdentification, 3, 5);
            this.TlpMain.Controls.Add(this.TxtBxName, 4, 1);
            this.TlpMain.Controls.Add(this.TxtBxLastName, 4, 2);
            this.TlpMain.Controls.Add(this.TxtBxEmail, 4, 3);
            this.TlpMain.Controls.Add(this.TxtBxPhone, 4, 4);
            this.TlpMain.Controls.Add(this.BtnSelectPhoto, 1, 4);
            this.TlpMain.Controls.Add(this.BtnCancel, 4, 6);
            this.TlpMain.Controls.Add(this.BtnSave, 3, 6);
            this.TlpMain.Controls.Add(this.TxtBxIdentification, 4, 5);
            this.TlpMain.Controls.Add(this.PbDoctor, 1, 1);
            this.TlpMain.Controls.Add(this.LblProfilePhoto, 1, 0);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 7;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.77778F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.666667F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.666667F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.111111F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.88889F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.22222F));
            this.TlpMain.Size = new System.Drawing.Size(674, 450);
            this.TlpMain.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblName.Location = new System.Drawing.Point(379, 96);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(53, 21);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // LblLastName
            // 
            this.LblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLastName.Location = new System.Drawing.Point(349, 140);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(83, 21);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "Last name";
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEmail.Location = new System.Drawing.Point(384, 178);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(48, 21);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "Email";
            // 
            // LblPhone
            // 
            this.LblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPhone.Location = new System.Drawing.Point(376, 216);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(56, 21);
            this.LblPhone.TabIndex = 3;
            this.LblPhone.Text = "Phone";
            // 
            // LblIdentification
            // 
            this.LblIdentification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblIdentification.AutoSize = true;
            this.LblIdentification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblIdentification.Location = new System.Drawing.Point(324, 256);
            this.LblIdentification.Name = "LblIdentification";
            this.LblIdentification.Size = new System.Drawing.Size(108, 21);
            this.LblIdentification.TabIndex = 4;
            this.LblIdentification.Text = "Identification";
            // 
            // TxtBxName
            // 
            this.TxtBxName.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxName.Location = new System.Drawing.Point(438, 99);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(164, 29);
            this.TxtBxName.TabIndex = 5;
            // 
            // TxtBxLastName
            // 
            this.TxtBxLastName.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBxLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxLastName.Location = new System.Drawing.Point(438, 143);
            this.TxtBxLastName.Name = "TxtBxLastName";
            this.TxtBxLastName.Size = new System.Drawing.Size(164, 29);
            this.TxtBxLastName.TabIndex = 6;
            // 
            // TxtBxEmail
            // 
            this.TxtBxEmail.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBxEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxEmail.Location = new System.Drawing.Point(438, 181);
            this.TxtBxEmail.Name = "TxtBxEmail";
            this.TxtBxEmail.Size = new System.Drawing.Size(164, 29);
            this.TxtBxEmail.TabIndex = 7;
            // 
            // TxtBxPhone
            // 
            this.TxtBxPhone.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBxPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxPhone.Location = new System.Drawing.Point(438, 219);
            this.TxtBxPhone.Mask = "(999) 000-0000";
            this.TxtBxPhone.Name = "TxtBxPhone";
            this.TxtBxPhone.Size = new System.Drawing.Size(164, 29);
            this.TxtBxPhone.TabIndex = 9;
            // 
            // BtnSelectPhoto
            // 
            this.BtnSelectPhoto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSelectPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSelectPhoto.FlatAppearance.BorderSize = 0;
            this.BtnSelectPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectPhoto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSelectPhoto.Location = new System.Drawing.Point(70, 219);
            this.BtnSelectPhoto.Name = "BtnSelectPhoto";
            this.BtnSelectPhoto.Size = new System.Drawing.Size(159, 32);
            this.BtnSelectPhoto.TabIndex = 13;
            this.BtnSelectPhoto.Text = "Select photo";
            this.BtnSelectPhoto.UseVisualStyleBackColor = false;
            this.BtnSelectPhoto.Click += new System.EventHandler(this.BtnSelectPhoto_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.Location = new System.Drawing.Point(438, 360);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(164, 30);
            this.BtnCancel.TabIndex = 11;
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
            this.BtnSave.Location = new System.Drawing.Point(295, 360);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(137, 30);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtBxIdentification
            // 
            this.TxtBxIdentification.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBxIdentification.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxIdentification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxIdentification.Location = new System.Drawing.Point(438, 259);
            this.TxtBxIdentification.Mask = "000-0000000-0";
            this.TxtBxIdentification.Name = "TxtBxIdentification";
            this.TxtBxIdentification.Size = new System.Drawing.Size(164, 29);
            this.TxtBxIdentification.TabIndex = 14;
            // 
            // PbDoctor
            // 
            this.PbDoctor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PbDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbDoctor.Location = new System.Drawing.Point(70, 99);
            this.PbDoctor.Name = "PbDoctor";
            this.TlpMain.SetRowSpan(this.PbDoctor, 3);
            this.PbDoctor.Size = new System.Drawing.Size(159, 114);
            this.PbDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbDoctor.TabIndex = 12;
            this.PbDoctor.TabStop = false;
            // 
            // LblProfilePhoto
            // 
            this.LblProfilePhoto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblProfilePhoto.AutoSize = true;
            this.LblProfilePhoto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblProfilePhoto.Location = new System.Drawing.Point(96, 75);
            this.LblProfilePhoto.Name = "LblProfilePhoto";
            this.LblProfilePhoto.Size = new System.Drawing.Size(107, 21);
            this.LblProfilePhoto.TabIndex = 15;
            this.LblProfilePhoto.Text = "Profile photo";
            // 
            // PhotoDialog
            // 
            this.PhotoDialog.Filter = "Image Files|*.PNG;*.JPG;*.JPEG|All files|*.*";
            // 
            // AddDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.TlpMain);
            this.Name = "AddDoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Doctor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddDoctorForm_FormClosed);
            this.Load += new System.EventHandler(this.AddDoctorForm_Load);
            this.TlpMain.ResumeLayout(false);
            this.TlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbDoctor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblIdentification;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.TextBox TxtBxLastName;
        private System.Windows.Forms.TextBox TxtBxEmail;
        private System.Windows.Forms.MaskedTextBox TxtBxPhone;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.PictureBox PbDoctor;
        private System.Windows.Forms.Button BtnSelectPhoto;
        private System.Windows.Forms.MaskedTextBox TxtBxIdentification;
        private System.Windows.Forms.Label LblProfilePhoto;
        private System.Windows.Forms.OpenFileDialog PhotoDialog;
    }
}