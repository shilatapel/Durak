using System.ComponentModel;

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
            this.button1 = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblSuit = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.picBoxSuit = new System.Windows.Forms.PictureBox();
            this.picBoxTable = new System.Windows.Forms.PictureBox();
            this.btnTableRight = new Durak.Classes.TriangleButton();
            this.btnTableLeft = new Durak.Classes.TriangleButton();
            this.btnSuitLeft = new Durak.Classes.TriangleButton();
            this.btnSuitRight = new Durak.Classes.TriangleButton();
            ((System.ComponentModel.ISupportInitialize) (this.picBoxSuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBoxTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lblSettings.Location = new System.Drawing.Point(155, 9);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(133, 31);
            this.lblSettings.TabIndex = 1;
            this.lblSettings.Text = "SETTINGS";
            // 
            // lblSuit
            // 
            this.lblSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lblSuit.Location = new System.Drawing.Point(38, 124);
            this.lblSuit.Name = "lblSuit";
            this.lblSuit.Size = new System.Drawing.Size(100, 23);
            this.lblSuit.TabIndex = 2;
            this.lblSuit.Text = "Suit";
            // 
            // lblTable
            // 
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lblTable.Location = new System.Drawing.Point(38, 280);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(100, 23);
            this.lblTable.TabIndex = 3;
            this.lblTable.Text = "Table";
            // 
            // picBoxSuit
            // 
            this.picBoxSuit.Location = new System.Drawing.Point(322, 85);
            this.picBoxSuit.Name = "picBoxSuit";
            this.picBoxSuit.Size = new System.Drawing.Size(80, 110);
            this.picBoxSuit.TabIndex = 4;
            this.picBoxSuit.TabStop = false;
            // 
            // picBoxTable
            // 
            this.picBoxTable.Location = new System.Drawing.Point(322, 241);
            this.picBoxTable.Name = "picBoxTable";
            this.picBoxTable.Size = new System.Drawing.Size(80, 110);
            this.picBoxTable.TabIndex = 5;
            this.picBoxTable.TabStop = false;
            // 
            // btnTableRight
            // 
            this.btnTableRight.Angle = 0F;
            this.btnTableRight.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTableRight.EdgesCount = 3;
            this.btnTableRight.Location = new System.Drawing.Point(408, 265);
            this.btnTableRight.Name = "btnTableRight";
            this.btnTableRight.Size = new System.Drawing.Size(32, 61);
            this.btnTableRight.TabIndex = 6;
            this.btnTableRight.UseVisualStyleBackColor = false;
            // 
            // btnTableLeft
            // 
            this.btnTableLeft.Angle = 66F;
            this.btnTableLeft.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTableLeft.EdgesCount = 3;
            this.btnTableLeft.Location = new System.Drawing.Point(284, 265);
            this.btnTableLeft.Name = "btnTableLeft";
            this.btnTableLeft.Size = new System.Drawing.Size(32, 61);
            this.btnTableLeft.TabIndex = 7;
            this.btnTableLeft.UseVisualStyleBackColor = false;
            // 
            // btnSuitLeft
            // 
            this.btnSuitLeft.Angle = 66F;
            this.btnSuitLeft.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSuitLeft.EdgesCount = 3;
            this.btnSuitLeft.Location = new System.Drawing.Point(284, 109);
            this.btnSuitLeft.Name = "btnSuitLeft";
            this.btnSuitLeft.Size = new System.Drawing.Size(32, 61);
            this.btnSuitLeft.TabIndex = 8;
            this.btnSuitLeft.UseVisualStyleBackColor = false;
            // 
            // btnSuitRight
            // 
            this.btnSuitRight.Angle = 0F;
            this.btnSuitRight.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSuitRight.EdgesCount = 3;
            this.btnSuitRight.Location = new System.Drawing.Point(408, 109);
            this.btnSuitRight.Name = "btnSuitRight";
            this.btnSuitRight.Size = new System.Drawing.Size(32, 61);
            this.btnSuitRight.TabIndex = 9;
            this.btnSuitRight.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 437);
            this.Controls.Add(this.btnSuitRight);
            this.Controls.Add(this.btnSuitLeft);
            this.Controls.Add(this.btnTableLeft);
            this.Controls.Add(this.btnTableRight);
            this.Controls.Add(this.picBoxTable);
            this.Controls.Add(this.picBoxSuit);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblSuit);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.button1);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize) (this.picBoxSuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBoxTable)).EndInit();
            this.ResumeLayout(false);
        }

        private Durak.Classes.TriangleButton btnSuitLeft;
        private Durak.Classes.TriangleButton btnSuitRight;

        private Durak.Classes.TriangleButton btnTableLeft;

        private Durak.Classes.TriangleButton btnTableRight;

        private System.Windows.Forms.PictureBox picBoxSuit;
        private System.Windows.Forms.PictureBox picBoxTable;

        private System.Windows.Forms.Label lblTable;

        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblSuit;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}