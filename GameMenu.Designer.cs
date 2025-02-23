﻿namespace Game_Character_GUI
{
    partial class GameMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCharacterType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCharacterType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWarrior = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picWarrior = new System.Windows.Forms.PictureBox();
            this.picMage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWarrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Goldenrod;
            this.lblTitle.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitle.Location = new System.Drawing.Point(357, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(307, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Character Creation";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblName.Location = new System.Drawing.Point(356, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 31);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblCharacterType
            // 
            this.lblCharacterType.BackColor = System.Drawing.Color.Transparent;
            this.lblCharacterType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterType.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCharacterType.Location = new System.Drawing.Point(425, 121);
            this.lblCharacterType.Name = "lblCharacterType";
            this.lblCharacterType.Size = new System.Drawing.Size(185, 44);
            this.lblCharacterType.TabIndex = 2;
            this.lblCharacterType.Text = "Select Class";
            this.lblCharacterType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtName.Font = new System.Drawing.Font("Playbill", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(461, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 31);
            this.txtName.TabIndex = 3;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Goldenrod;
            this.btnStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Playbill", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(410, 337);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(200, 50);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(410, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWarrior
            // 
            this.lblWarrior.AutoSize = true;
            this.lblWarrior.BackColor = System.Drawing.Color.Transparent;
            this.lblWarrior.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarrior.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblWarrior.Location = new System.Drawing.Point(318, 119);
            this.lblWarrior.Name = "lblWarrior";
            this.lblWarrior.Size = new System.Drawing.Size(110, 40);
            this.lblWarrior.TabIndex = 12;
            this.lblWarrior.Text = "WARRIOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(635, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "MAGE";
            // 
            // picWarrior
            // 
            this.picWarrior.BackColor = System.Drawing.Color.Goldenrod;
            this.picWarrior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWarrior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWarrior.Image = global::Game_Character_GUI.Properties.Resources.FemaleWarriorIcon1;
            this.picWarrior.Location = new System.Drawing.Point(279, 162);
            this.picWarrior.Name = "picWarrior";
            this.picWarrior.Size = new System.Drawing.Size(200, 150);
            this.picWarrior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWarrior.TabIndex = 9;
            this.picWarrior.TabStop = false;
            this.picWarrior.Click += new System.EventHandler(this.picWarrior_Click);
            // 
            // picMage
            // 
            this.picMage.BackColor = System.Drawing.Color.Goldenrod;
            this.picMage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMage.Image = global::Game_Character_GUI.Properties.Resources.MagePreview1;
            this.picMage.Location = new System.Drawing.Point(566, 162);
            this.picMage.Name = "picMage";
            this.picMage.Size = new System.Drawing.Size(200, 150);
            this.picMage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMage.TabIndex = 8;
            this.picMage.TabStop = false;
            this.picMage.Click += new System.EventHandler(this.picMage_Click);
            // 
            // GameMenu
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::Game_Character_GUI.Properties.Resources.Background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWarrior);
            this.Controls.Add(this.picWarrior);
            this.Controls.Add(this.picMage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCharacterType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("MS Mincho", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creation";
            ((System.ComponentModel.ISupportInitialize)(this.picWarrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.PictureBox picMage;
        private System.Windows.Forms.PictureBox picWarrior;
        private System.Windows.Forms.Label lblWarrior;
        private System.Windows.Forms.Label label2;
    }
}
