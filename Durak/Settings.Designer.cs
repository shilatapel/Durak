using System.ComponentModel;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Durak
{
    partial class Settings
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
            this.btnSettingsClose = new System.Windows.Forms.Button();
            this.lblSuit = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.picBoxSuit = new System.Windows.Forms.PictureBox();
            this.picBoxTable = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSuitRight = new Durak.Classes.TriangleButton();
            this.btnSuitLeft = new Durak.Classes.TriangleButton();
            this.btnTableLeft = new Durak.Classes.TriangleButton();
            this.btnTableRight = new Durak.Classes.TriangleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettingsClose
            // 
            this.btnSettingsClose.BackColor = System.Drawing.Color.Maroon;
            this.btnSettingsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSettingsClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSettingsClose.Location = new System.Drawing.Point(136, 406);
            this.btnSettingsClose.Name = "btnSettingsClose";
            this.btnSettingsClose.Size = new System.Drawing.Size(95, 38);
            this.btnSettingsClose.TabIndex = 0;
            this.btnSettingsClose.Text = "Close";
            this.btnSettingsClose.UseVisualStyleBackColor = false;
            this.btnSettingsClose.Click += new System.EventHandler(this.btnSettingsClose_Click);
            // 
            // lblSuit
            // 
            this.lblSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSuit.ForeColor = System.Drawing.Color.Maroon;
            this.lblSuit.Location = new System.Drawing.Point(38, 124);
            this.lblSuit.Name = "lblSuit";
            this.lblSuit.Size = new System.Drawing.Size(100, 23);
            this.lblSuit.TabIndex = 2;
            this.lblSuit.Text = "Suit";
            // 
            // lblTable
            // 
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTable.ForeColor = System.Drawing.Color.Maroon;
            this.lblTable.Location = new System.Drawing.Point(38, 289);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(100, 23);
            this.lblTable.TabIndex = 3;
            this.lblTable.Text = "Table";
            // 
            // picBoxSuit
            // 
            this.picBoxSuit.Location = new System.Drawing.Point(266, 84);
            this.picBoxSuit.Name = "picBoxSuit";
            this.picBoxSuit.Size = new System.Drawing.Size(80, 110);
            this.picBoxSuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSuit.TabIndex = 4;
            this.picBoxSuit.TabStop = false;
            // 
            // picBoxTable
            // 
            this.picBoxTable.Location = new System.Drawing.Point(266, 240);
            this.picBoxTable.Name = "picBoxTable";
            this.picBoxTable.Size = new System.Drawing.Size(80, 110);
            this.picBoxTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTable.TabIndex = 5;
            this.picBoxTable.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 44);
            this.panel1.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Yehuda CLM", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(132, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Settings";
            // 
            // btnSuitRight
            // 
            this.btnSuitRight.Angle = 0F;
            this.btnSuitRight.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSuitRight.EdgesCount = 3;
            this.btnSuitRight.Location = new System.Drawing.Point(352, 108);
            this.btnSuitRight.Name = "btnSuitRight";
            this.btnSuitRight.Size = new System.Drawing.Size(32, 61);
            this.btnSuitRight.TabIndex = 9;
            this.btnSuitRight.UseVisualStyleBackColor = false;
            this.btnSuitRight.Click += new System.EventHandler(this.btnSuitRight_Click);
            // 
            // btnSuitLeft
            // 
            this.btnSuitLeft.Angle = 66F;
            this.btnSuitLeft.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSuitLeft.EdgesCount = 3;
            this.btnSuitLeft.Location = new System.Drawing.Point(228, 108);
            this.btnSuitLeft.Name = "btnSuitLeft";
            this.btnSuitLeft.Size = new System.Drawing.Size(32, 61);
            this.btnSuitLeft.TabIndex = 8;
            this.btnSuitLeft.UseVisualStyleBackColor = false;
            this.btnSuitLeft.Click += new System.EventHandler(this.btnSuitLeft_Click);
            // 
            // btnTableLeft
            // 
            this.btnTableLeft.Angle = 66F;
            this.btnTableLeft.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTableLeft.EdgesCount = 3;
            this.btnTableLeft.Location = new System.Drawing.Point(228, 264);
            this.btnTableLeft.Name = "btnTableLeft";
            this.btnTableLeft.Size = new System.Drawing.Size(32, 61);
            this.btnTableLeft.TabIndex = 7;
            this.btnTableLeft.UseVisualStyleBackColor = false;
            this.btnTableLeft.Click += new System.EventHandler(this.btnTableLeft_Click);
            // 
            // btnTableRight
            // 
            this.btnTableRight.Angle = 0F;
            this.btnTableRight.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTableRight.EdgesCount = 3;
            this.btnTableRight.Location = new System.Drawing.Point(352, 264);
            this.btnTableRight.Name = "btnTableRight";
            this.btnTableRight.Size = new System.Drawing.Size(32, 61);
            this.btnTableRight.TabIndex = 6;
            this.btnTableRight.UseVisualStyleBackColor = false;
            this.btnTableRight.Click += new System.EventHandler(this.btnTableRight_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSuitRight);
            this.Controls.Add(this.btnSuitLeft);
            this.Controls.Add(this.btnTableLeft);
            this.Controls.Add(this.btnTableRight);
            this.Controls.Add(this.picBoxTable);
            this.Controls.Add(this.picBoxSuit);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblSuit);
            this.Controls.Add(this.btnSettingsClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private Durak.Classes.TriangleButton btnSuitLeft;
        private Durak.Classes.TriangleButton btnSuitRight;

        private Durak.Classes.TriangleButton btnTableLeft;

        private Durak.Classes.TriangleButton btnTableRight;

        private System.Windows.Forms.PictureBox picBoxSuit;
        private System.Windows.Forms.PictureBox picBoxTable;

        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblSuit;

        private System.Windows.Forms.Button btnSettingsClose;

        #endregion

        private Panel panel1;
        private Label lblTitle;
    }
}