
namespace PatientManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtBxUsername = new System.Windows.Forms.TextBox();
            this.TxtBxPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 4;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMain.Controls.Add(this.LblUsername, 1, 1);
            this.TlpMain.Controls.Add(this.LblPassword, 1, 2);
            this.TlpMain.Controls.Add(this.TxtBxUsername, 2, 1);
            this.TlpMain.Controls.Add(this.TxtBxPassword, 2, 2);
            this.TlpMain.Controls.Add(this.BtnLogin, 1, 3);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 4;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.08018F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.35412F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.81292F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.75278F));
            this.TlpMain.Size = new System.Drawing.Size(670, 450);
            this.TlpMain.TabIndex = 0;
            // 
            // LblUsername
            // 
            this.LblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUsername.Location = new System.Drawing.Point(215, 162);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(83, 21);
            this.LblUsername.TabIndex = 0;
            this.LblUsername.Text = "Username";
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPassword.Location = new System.Drawing.Point(219, 204);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(79, 21);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password";
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBxUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxUsername.Location = new System.Drawing.Point(304, 165);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.Size = new System.Drawing.Size(195, 29);
            this.TxtBxUsername.TabIndex = 2;
            // 
            // TxtBxPassword
            // 
            this.TxtBxPassword.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBxPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxPassword.Location = new System.Drawing.Point(304, 207);
            this.TxtBxPassword.Name = "TxtBxPassword";
            this.TxtBxPassword.PasswordChar = '*';
            this.TxtBxPassword.Size = new System.Drawing.Size(195, 29);
            this.TxtBxPassword.TabIndex = 3;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TlpMain.SetColumnSpan(this.BtnLogin, 2);
            this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLogin.Location = new System.Drawing.Point(170, 278);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(329, 36);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.TlpMain);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TlpMain.ResumeLayout(false);
            this.TlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.TextBox TxtBxPassword;
        private System.Windows.Forms.Button BtnLogin;
    }
}

