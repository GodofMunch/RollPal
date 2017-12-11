namespace WindowsFormsApp1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.userNameBText = new System.Windows.Forms.TextBox();
            this.passWordBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameBText
            // 
            this.userNameBText.AcceptsReturn = true;
            this.userNameBText.AcceptsTab = true;
            this.userNameBText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameBText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameBText.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userNameBText.Location = new System.Drawing.Point(201, 327);
            this.userNameBText.Name = "userNameBText";
            this.userNameBText.Size = new System.Drawing.Size(330, 23);
            this.userNameBText.TabIndex = 1;
            this.userNameBText.Text = "Username";
            this.userNameBText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNameBText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userNameBText_Click);
            // 
            // passWordBox
            // 
            this.passWordBox.AcceptsTab = true;
            this.passWordBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWordBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passWordBox.Location = new System.Drawing.Point(201, 371);
            this.passWordBox.Name = "passWordBox";
            this.passWordBox.PasswordChar = '*';
            this.passWordBox.Size = new System.Drawing.Size(330, 22);
            this.passWordBox.TabIndex = 2;
            this.passWordBox.Text = "Password";
            this.passWordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passWordBox.UseSystemPasswordChar = true;
            this.passWordBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passWordText_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.loginButton.Location = new System.Drawing.Point(330, 425);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 460);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passWordBox);
            this.Controls.Add(this.userNameBText);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RollPal Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userNameBText;
        private System.Windows.Forms.TextBox passWordBox;
        private System.Windows.Forms.Button loginButton;
    }
}

