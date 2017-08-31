namespace bestMeAM
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUname = new MetroFramework.Controls.MetroTextBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.mbtnLogin = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUname
            // 
            // 
            // 
            // 
            this.txtUname.CustomButton.Image = null;
            this.txtUname.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.txtUname.CustomButton.Name = "";
            this.txtUname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtUname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUname.CustomButton.TabIndex = 1;
            this.txtUname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUname.CustomButton.UseSelectable = true;
            this.txtUname.CustomButton.Visible = false;
            this.txtUname.DisplayIcon = true;
            this.txtUname.Icon = ((System.Drawing.Image)(resources.GetObject("txtUname.Icon")));
            this.txtUname.Lines = new string[0];
            this.txtUname.Location = new System.Drawing.Point(177, 70);
            this.txtUname.MaxLength = 32767;
            this.txtUname.Name = "txtUname";
            this.txtUname.PasswordChar = '\0';
            this.txtUname.PromptText = "Enter Your User Name";
            this.txtUname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUname.SelectedText = "";
            this.txtUname.SelectionLength = 0;
            this.txtUname.SelectionStart = 0;
            this.txtUname.ShortcutsEnabled = true;
            this.txtUname.Size = new System.Drawing.Size(291, 25);
            this.txtUname.TabIndex = 0;
            this.txtUname.UseSelectable = true;
            this.txtUname.WaterMark = "Enter Your User Name";
            this.txtUname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUname.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.DisplayIcon = true;
            this.txtPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtPass.Icon")));
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(177, 101);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PromptText = "Enter Your Password";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(291, 25);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMark = "Enter Your Password";
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // mbtnLogin
            // 
            this.mbtnLogin.BackColor = System.Drawing.Color.White;
            this.mbtnLogin.Location = new System.Drawing.Point(388, 147);
            this.mbtnLogin.Name = "mbtnLogin";
            this.mbtnLogin.Size = new System.Drawing.Size(80, 23);
            this.mbtnLogin.TabIndex = 2;
            this.mbtnLogin.Text = "&Login";
            this.mbtnLogin.UseSelectable = true;
            this.mbtnLogin.Click += new System.EventHandler(this.mbtnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 196);
            this.Controls.Add(this.mbtnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtUname;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroButton mbtnLogin;
    }
}

