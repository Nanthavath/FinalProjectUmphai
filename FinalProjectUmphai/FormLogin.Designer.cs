namespace FinalProjectUmphai
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.textPaasword = new Guna.UI2.WinForms.Guna2TextBox();
            this.textUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BorderRadius = 15;
            this.loginButton.CheckedState.Parent = this.loginButton;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.CustomImages.Parent = this.loginButton;
            this.loginButton.Font = new System.Drawing.Font("BoonHome", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.HoverState.Parent = this.loginButton;
            this.loginButton.Location = new System.Drawing.Point(464, 221);
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.Parent = this.loginButton;
            this.loginButton.Size = new System.Drawing.Size(421, 45);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "ເຂົ້າສູ່ລະບົບ";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // textPaasword
            // 
            this.textPaasword.Animated = true;
            this.textPaasword.BorderColor = System.Drawing.Color.Black;
            this.textPaasword.BorderRadius = 15;
            this.textPaasword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPaasword.DefaultText = "";
            this.textPaasword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPaasword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPaasword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPaasword.DisabledState.Parent = this.textPaasword;
            this.textPaasword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPaasword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPaasword.FocusedState.Parent = this.textPaasword;
            this.textPaasword.Font = new System.Drawing.Font("BoonHome", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPaasword.ForeColor = System.Drawing.Color.Black;
            this.textPaasword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPaasword.HoverState.Parent = this.textPaasword;
            this.textPaasword.Location = new System.Drawing.Point(464, 156);
            this.textPaasword.Margin = new System.Windows.Forms.Padding(4);
            this.textPaasword.Name = "textPaasword";
            this.textPaasword.PasswordChar = '\0';
            this.textPaasword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textPaasword.PlaceholderText = "ລະຫັດຜ່ານ";
            this.textPaasword.SelectedText = "";
            this.textPaasword.ShadowDecoration.Parent = this.textPaasword;
            this.textPaasword.Size = new System.Drawing.Size(421, 48);
            this.textPaasword.TabIndex = 5;
            this.textPaasword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPaasword.UseSystemPasswordChar = true;
            // 
            // textUsername
            // 
            this.textUsername.Animated = true;
            this.textUsername.BorderColor = System.Drawing.Color.Black;
            this.textUsername.BorderRadius = 15;
            this.textUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUsername.DefaultText = "";
            this.textUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUsername.DisabledState.Parent = this.textUsername;
            this.textUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUsername.FocusedState.Parent = this.textUsername;
            this.textUsername.Font = new System.Drawing.Font("BoonHome", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.ForeColor = System.Drawing.Color.Black;
            this.textUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUsername.HoverState.Parent = this.textUsername;
            this.textUsername.Location = new System.Drawing.Point(464, 90);
            this.textUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textUsername.Name = "textUsername";
            this.textUsername.PasswordChar = '\0';
            this.textUsername.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textUsername.PlaceholderText = "ຊື່ຜູ້ໃຊ້";
            this.textUsername.SelectedText = "";
            this.textUsername.ShadowDecoration.Parent = this.textUsername;
            this.textUsername.Size = new System.Drawing.Size(421, 48);
            this.textUsername.TabIndex = 4;
            this.textUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.textUsername);
            this.panel1.Controls.Add(this.textPaasword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 467);
            this.panel1.TabIndex = 7;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(945, 467);
            this.Controls.Add(this.panel1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2TextBox textPaasword;
        private Guna.UI2.WinForms.Guna2TextBox textUsername;
        private System.Windows.Forms.Panel panel1;
    }
}

