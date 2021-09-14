
namespace Durak
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.lblNname = new System.Windows.Forms.Label();
            this.lblPicProfile = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblNname
            // 
            this.lblNname.AutoSize = true;
            this.lblNname.BackColor = System.Drawing.Color.Transparent;
            this.lblNname.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNname.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lblNname.Location = new System.Drawing.Point(285, 94);
            this.lblNname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNname.Name = "lblNname";
            this.lblNname.Size = new System.Drawing.Size(215, 49);
            this.lblNname.TabIndex = 1;
            this.lblNname.Text = "Nick Name :";
            // 
            // lblPicProfile
            // 
            this.lblPicProfile.AutoSize = true;
            this.lblPicProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblPicProfile.Font = new System.Drawing.Font("Monotype Corsiva", 33F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPicProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPicProfile.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lblPicProfile.Location = new System.Drawing.Point(275, 157);
            this.lblPicProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPicProfile.Name = "lblPicProfile";
            this.lblPicProfile.Size = new System.Drawing.Size(389, 53);
            this.lblPicProfile.TabIndex = 2;
            this.lblPicProfile.Text = "Choose Picture Profile :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Choco", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtName.Location = new System.Drawing.Point(495, 103);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 37);
            this.txtName.TabIndex = 3;
            this.txtName.Tag = "";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Black;
            this.btnSignIn.Font = new System.Drawing.Font("Perpetua", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSignIn.Image = ((System.Drawing.Image)(resources.GetObject("btnSignIn.Image")));
            this.btnSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignIn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btnSignIn.Location = new System.Drawing.Point(386, 334);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(178, 52);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Login    ";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnFemale.Image = ((System.Drawing.Image)(resources.GetObject("radioBtnFemale.Image")));
            this.radioBtnFemale.Location = new System.Drawing.Point(352, 223);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(94, 80);
            this.radioBtnFemale.TabIndex = 7;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.UseCompatibleTextRendering = true;
            this.radioBtnFemale.UseVisualStyleBackColor = false;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnMale.Image = ((System.Drawing.Image)(resources.GetObject("radioBtnMale.Image")));
            this.radioBtnMale.Location = new System.Drawing.Point(507, 223);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(94, 80);
            this.radioBtnMale.TabIndex = 8;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.UseCompatibleTextRendering = true;
            this.radioBtnMale.UseVisualStyleBackColor = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 457);
            this.Controls.Add(this.radioBtnMale);
            this.Controls.Add(this.radioBtnFemale);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPicProfile);
            this.Controls.Add(this.lblNname);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGNIN";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNname;
        private System.Windows.Forms.Label lblPicProfile;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBtnMale;
    }
}

