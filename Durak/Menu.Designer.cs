
using System.Windows.Forms;

namespace Durak
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBoxHi = new System.Windows.Forms.ToolStripMenuItem();
            this.GameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.pnlDeck = new System.Windows.Forms.Panel();
            this.pnlAi = new System.Windows.Forms.Panel();
            this.pnlTrump = new System.Windows.Forms.Panel();
            this.pnlAboveTrump = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDiscardPile = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxHi,
            this.GameToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.ScoreToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(984, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBoxHi
            // 
            this.toolStripTextBoxHi.BackColor = System.Drawing.Color.White;
            this.toolStripTextBoxHi.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBoxHi.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripTextBoxHi.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTextBoxHi.Image")));
            this.toolStripTextBoxHi.Name = "toolStripTextBoxHi";
            this.toolStripTextBoxHi.Size = new System.Drawing.Size(28, 27);
            // 
            // GameToolStripMenuItem
            // 
            this.GameToolStripMenuItem.AutoSize = false;
            this.GameToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.GameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameToolStripMenuItem,
            this.LoadGameToolStripMenuItem,
            this.SaveGameToolStripMenuItem});
            this.GameToolStripMenuItem.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.GameToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GameToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.GameToolStripMenuItem.Name = "GameToolStripMenuItem";
            this.GameToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.GameToolStripMenuItem.Size = new System.Drawing.Size(94, 23);
            this.GameToolStripMenuItem.Text = "Game";
            this.GameToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // NewGameToolStripMenuItem
            // 
            this.NewGameToolStripMenuItem.AutoSize = false;
            this.NewGameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.NewGameToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NewGameToolStripMenuItem.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.NewGameToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            this.NewGameToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewGameToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.NewGameToolStripMenuItem.Text = "New";
            this.NewGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // LoadGameToolStripMenuItem
            // 
            this.LoadGameToolStripMenuItem.AutoSize = false;
            this.LoadGameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LoadGameToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoadGameToolStripMenuItem.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadGameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LoadGameToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.LoadGameToolStripMenuItem.Name = "LoadGameToolStripMenuItem";
            this.LoadGameToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.LoadGameToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoadGameToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.LoadGameToolStripMenuItem.Text = "Load";
            this.LoadGameToolStripMenuItem.Click += new System.EventHandler(this.LoadGameToolStripMenuItem_Click);
            // 
            // SaveGameToolStripMenuItem
            // 
            this.SaveGameToolStripMenuItem.AutoSize = false;
            this.SaveGameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SaveGameToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveGameToolStripMenuItem.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveGameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SaveGameToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.SaveGameToolStripMenuItem.Name = "SaveGameToolStripMenuItem";
            this.SaveGameToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.SaveGameToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.SaveGameToolStripMenuItem.Text = "Save";
            this.SaveGameToolStripMenuItem.Click += new System.EventHandler(this.SaveGameToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SettingsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.SettingsToolStripMenuItem.Text = "Settings ";
            // 
            // ScoreToolStripMenuItem
            // 
            this.ScoreToolStripMenuItem.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ScoreToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.ScoreToolStripMenuItem.Name = "ScoreToolStripMenuItem";
            this.ScoreToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ScoreToolStripMenuItem.Size = new System.Drawing.Size(180, 23);
            this.ScoreToolStripMenuItem.Text = "Score and Statistics";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.HelpToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayer.Location = new System.Drawing.Point(212, 473);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(600, 150);
            this.pnlPlayer.TabIndex = 5;
            // 
            // pnlDeck
            // 
            this.pnlDeck.BackColor = System.Drawing.Color.Transparent;
            this.pnlDeck.Location = new System.Drawing.Point(212, 281);
            this.pnlDeck.Name = "pnlDeck";
            this.pnlDeck.Size = new System.Drawing.Size(600, 150);
            this.pnlDeck.TabIndex = 6;
            // 
            // pnlAi
            // 
            this.pnlAi.BackColor = System.Drawing.Color.Transparent;
            this.pnlAi.Location = new System.Drawing.Point(212, 73);
            this.pnlAi.Name = "pnlAi";
            this.pnlAi.Size = new System.Drawing.Size(600, 150);
            this.pnlAi.TabIndex = 7;
            // 
            // pnlTrump
            // 
            this.pnlTrump.BackColor = System.Drawing.Color.Transparent;
            this.pnlTrump.Location = new System.Drawing.Point(42, 298);
            this.pnlTrump.Name = "pnlTrump";
            this.pnlTrump.Size = new System.Drawing.Size(100, 80);
            this.pnlTrump.TabIndex = 8;
            // 
            // pnlAboveTrump
            // 
            this.pnlAboveTrump.BackColor = System.Drawing.Color.Transparent;
            this.pnlAboveTrump.Location = new System.Drawing.Point(15, 281);
            this.pnlAboveTrump.Name = "pnlAboveTrump";
            this.pnlAboveTrump.Size = new System.Drawing.Size(72, 100);
            this.pnlAboveTrump.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(848, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 291);
            this.label1.TabIndex = 10;
            this.label1.Text = "1";
            // 
            // btnDone
            // 
            this.btnDone.Enabled = false;
            this.btnDone.Location = new System.Drawing.Point(848, 560);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 11;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnTake
            // 
            this.btnTake.Enabled = false;
            this.btnTake.Location = new System.Drawing.Point(848, 612);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(75, 23);
            this.btnTake.TabIndex = 12;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(848, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 13;
            // 
            // pnlDiscardPile
            // 
            this.pnlDiscardPile.BackColor = System.Drawing.Color.Transparent;
            this.pnlDiscardPile.Location = new System.Drawing.Point(28, 473);
            this.pnlDiscardPile.Name = "pnlDiscardPile";
            this.pnlDiscardPile.Size = new System.Drawing.Size(72, 100);
            this.pnlDiscardPile.TabIndex = 10;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 671);
            this.Controls.Add(this.pnlDiscardPile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTrump);
            this.Controls.Add(this.pnlAboveTrump);
            this.Controls.Add(this.pnlAi);
            this.Controls.Add(this.pnlDeck);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durak";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnDone;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel pnlAboveTrump;
        private System.Windows.Forms.Panel pnlDiscardPile;
        private System.Windows.Forms.Panel pnlTrump;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Panel pnlDeck;
        private System.Windows.Forms.Panel pnlAi;

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBoxHi;
        private System.Windows.Forms.ToolStripMenuItem NewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveGameToolStripMenuItem;
    }
}