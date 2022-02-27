using System.ComponentModel;

namespace Durak
{
    partial class ScoreAndStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCwin = new System.Windows.Forms.Label();
            this.lblCdraw = new System.Windows.Forms.Label();
            this.lblClost = new System.Windows.Forms.Label();
            this.lblPc = new System.Windows.Forms.Label();
            this.lblPwin = new System.Windows.Forms.Label();
            this.lblPdraw = new System.Windows.Forms.Label();
            this.lblPlost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCprWin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCprLost = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPprLost = new System.Windows.Forms.Label();
            this.lblPprWin = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblplayername = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Maroon;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOK.Location = new System.Drawing.Point(218, 440);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 33);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Yehuda CLM", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(78, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 29);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Score And Statistics";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 44);
            this.panel1.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.Maroon;
            this.lbl1.Location = new System.Drawing.Point(9, 6);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 26);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "W";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "D";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "L";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(249, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 26);
            this.label4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Computer";
            // 
            // lblCwin
            // 
            this.lblCwin.AutoSize = true;
            this.lblCwin.BackColor = System.Drawing.Color.Transparent;
            this.lblCwin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCwin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCwin.Location = new System.Drawing.Point(6, 16);
            this.lblCwin.Name = "lblCwin";
            this.lblCwin.Size = new System.Drawing.Size(0, 26);
            this.lblCwin.TabIndex = 3;
            // 
            // lblCdraw
            // 
            this.lblCdraw.AutoSize = true;
            this.lblCdraw.BackColor = System.Drawing.Color.Transparent;
            this.lblCdraw.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCdraw.Location = new System.Drawing.Point(6, 119);
            this.lblCdraw.Name = "lblCdraw";
            this.lblCdraw.Size = new System.Drawing.Size(0, 26);
            this.lblCdraw.TabIndex = 5;
            // 
            // lblClost
            // 
            this.lblClost.AutoSize = true;
            this.lblClost.BackColor = System.Drawing.Color.Transparent;
            this.lblClost.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblClost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblClost.Location = new System.Drawing.Point(6, 66);
            this.lblClost.Name = "lblClost";
            this.lblClost.Size = new System.Drawing.Size(0, 26);
            this.lblClost.TabIndex = 4;
            // 
            // lblPc
            // 
            this.lblPc.AutoSize = true;
            this.lblPc.BackColor = System.Drawing.Color.Transparent;
            this.lblPc.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPc.ForeColor = System.Drawing.Color.Maroon;
            this.lblPc.Location = new System.Drawing.Point(279, 429);
            this.lblPc.Name = "lblPc";
            this.lblPc.Size = new System.Drawing.Size(0, 26);
            this.lblPc.TabIndex = 6;
            // 
            // lblPwin
            // 
            this.lblPwin.AutoSize = true;
            this.lblPwin.BackColor = System.Drawing.Color.Transparent;
            this.lblPwin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPwin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPwin.Location = new System.Drawing.Point(6, 9);
            this.lblPwin.Name = "lblPwin";
            this.lblPwin.Size = new System.Drawing.Size(0, 26);
            this.lblPwin.TabIndex = 3;
            // 
            // lblPdraw
            // 
            this.lblPdraw.AutoSize = true;
            this.lblPdraw.BackColor = System.Drawing.Color.Transparent;
            this.lblPdraw.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPdraw.Location = new System.Drawing.Point(6, 112);
            this.lblPdraw.Name = "lblPdraw";
            this.lblPdraw.Size = new System.Drawing.Size(0, 26);
            this.lblPdraw.TabIndex = 5;
            // 
            // lblPlost
            // 
            this.lblPlost.AutoSize = true;
            this.lblPlost.BackColor = System.Drawing.Color.Transparent;
            this.lblPlost.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPlost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPlost.Location = new System.Drawing.Point(6, 59);
            this.lblPlost.Name = "lblPlost";
            this.lblPlost.Size = new System.Drawing.Size(0, 26);
            this.lblPlost.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(1, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 26);
            this.label6.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(10, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "LOST%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(10, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "WIN %";
            // 
            // lblCprWin
            // 
            this.lblCprWin.AutoSize = true;
            this.lblCprWin.BackColor = System.Drawing.Color.Transparent;
            this.lblCprWin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCprWin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCprWin.Location = new System.Drawing.Point(6, 5);
            this.lblCprWin.Name = "lblCprWin";
            this.lblCprWin.Size = new System.Drawing.Size(0, 26);
            this.lblCprWin.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(16, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 81);
            this.panel2.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblCprLost);
            this.panel4.Controls.Add(this.lblCprWin);
            this.panel4.Location = new System.Drawing.Point(141, 315);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(82, 87);
            this.panel4.TabIndex = 15;
            // 
            // lblCprLost
            // 
            this.lblCprLost.AutoSize = true;
            this.lblCprLost.BackColor = System.Drawing.Color.Transparent;
            this.lblCprLost.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCprLost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCprLost.Location = new System.Drawing.Point(6, 48);
            this.lblCprLost.Name = "lblCprLost";
            this.lblCprLost.Size = new System.Drawing.Size(0, 26);
            this.lblCprLost.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPprLost);
            this.panel3.Controls.Add(this.lblPprWin);
            this.panel3.Location = new System.Drawing.Point(268, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(86, 87);
            this.panel3.TabIndex = 16;
            // 
            // lblPprLost
            // 
            this.lblPprLost.AutoSize = true;
            this.lblPprLost.BackColor = System.Drawing.Color.Transparent;
            this.lblPprLost.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPprLost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPprLost.Location = new System.Drawing.Point(6, 48);
            this.lblPprLost.Name = "lblPprLost";
            this.lblPprLost.Size = new System.Drawing.Size(0, 26);
            this.lblPprLost.TabIndex = 16;
            // 
            // lblPprWin
            // 
            this.lblPprWin.AutoSize = true;
            this.lblPprWin.BackColor = System.Drawing.Color.Transparent;
            this.lblPprWin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPprWin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPprWin.Location = new System.Drawing.Point(6, 5);
            this.lblPprWin.Name = "lblPprWin";
            this.lblPprWin.Size = new System.Drawing.Size(0, 26);
            this.lblPprWin.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(16, 141);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(65, 154);
            this.panel5.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblCwin);
            this.panel6.Controls.Add(this.lblCdraw);
            this.panel6.Controls.Add(this.lblClost);
            this.panel6.Location = new System.Drawing.Point(141, 131);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(82, 162);
            this.panel6.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblPwin);
            this.panel7.Controls.Add(this.lblPlost);
            this.panel7.Controls.Add(this.lblPdraw);
            this.panel7.Location = new System.Drawing.Point(268, 131);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(86, 162);
            this.panel7.TabIndex = 19;
            // 
            // lblplayername
            // 
            this.lblplayername.AutoSize = true;
            this.lblplayername.BackColor = System.Drawing.Color.Transparent;
            this.lblplayername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayername.ForeColor = System.Drawing.Color.Maroon;
            this.lblplayername.Location = new System.Drawing.Point(147, 17);
            this.lblplayername.Name = "lblplayername";
            this.lblplayername.Size = new System.Drawing.Size(54, 23);
            this.lblplayername.TabIndex = 4;
            this.lblplayername.Text = "shilat";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.lblplayername);
            this.panel8.Location = new System.Drawing.Point(125, 71);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(229, 54);
            this.panel8.TabIndex = 20;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Maroon;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReset.Location = new System.Drawing.Point(65, 440);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 33);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ScoreAndStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 500);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScoreAndStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreAndStatistics";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPc;
        private System.Windows.Forms.Label lblCwin;
        private System.Windows.Forms.Label lblCdraw;
        private System.Windows.Forms.Label lblClost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPwin;
        private System.Windows.Forms.Label lblPdraw;
        private System.Windows.Forms.Label lblPlost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCprWin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCprLost;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPprLost;
        private System.Windows.Forms.Label lblPprWin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblplayername;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnReset;
    }
}