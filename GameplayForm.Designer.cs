﻿using System.Drawing;
using System.Windows.Forms;
using System;

public partial class GameplayForm : Form
{
    private Label lblPlayerName;
    private PictureBox picPlayer;
    private Label lblEnemyName;
    private PictureBox picEnemy;

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameplayForm));
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCheckStats = new System.Windows.Forms.Button();
            this.battleLog = new System.Windows.Forms.RichTextBox();
            this.attackTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSkillOne = new System.Windows.Forms.Button();
            this.btnSkillTwo = new System.Windows.Forms.Button();
            this.btnBuff = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.lblTurns = new System.Windows.Forms.Label();
            this.btnBasicAttack = new System.Windows.Forms.Button();
            this.playerHealthBar = new CustomProgressBar();
            this.energyBar = new CustomProgressBar();
            this.EnemyHealthBar = new CustomProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayerName.Location = new System.Drawing.Point(143, 14);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(301, 23);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Location = new System.Drawing.Point(200, 150);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(250, 250);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 2;
            this.picPlayer.TabStop = false;
            this.picPlayer.Click += new System.EventHandler(this.picPlayer_Click);
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEnemyName.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyName.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnemyName.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblEnemyName.Location = new System.Drawing.Point(606, 102);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(126, 23);
            this.lblEnemyName.TabIndex = 3;
            this.lblEnemyName.Text = "Enemy lvl.999";
            this.lblEnemyName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picEnemy
            // 
            this.picEnemy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picEnemy.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy.Location = new System.Drawing.Point(550, 150);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(250, 250);
            this.picEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy.TabIndex = 5;
            this.picEnemy.TabStop = false;
            // 
            // btnCheckStats
            // 
            this.btnCheckStats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckStats.BackColor = System.Drawing.SystemColors.Control;
            this.btnCheckStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCheckStats.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCheckStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckStats.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckStats.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCheckStats.Image = global::Game_Character_GUI.Properties.Resources.WarriorFace;
            this.btnCheckStats.Location = new System.Drawing.Point(25, 8);
            this.btnCheckStats.Name = "btnCheckStats";
            this.btnCheckStats.Size = new System.Drawing.Size(100, 100);
            this.btnCheckStats.TabIndex = 10;
            this.btnCheckStats.UseVisualStyleBackColor = false;
            this.btnCheckStats.Click += new System.EventHandler(this.btnCheckStats_Click);
            // 
            // battleLog
            // 
            this.battleLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.battleLog.BackColor = System.Drawing.Color.DarkCyan;
            this.battleLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.battleLog.Location = new System.Drawing.Point(550, 8);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(250, 88);
            this.battleLog.TabIndex = 11;
            this.battleLog.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 12;
            // 
            // btnSkillOne
            // 
            this.btnSkillOne.BackgroundImage = global::Game_Character_GUI.Properties.Resources.MageSkillOne;
            this.btnSkillOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSkillOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkillOne.Location = new System.Drawing.Point(25, 200);
            this.btnSkillOne.Name = "btnSkillOne";
            this.btnSkillOne.Size = new System.Drawing.Size(80, 80);
            this.btnSkillOne.TabIndex = 15;
            this.btnSkillOne.UseVisualStyleBackColor = true;
            this.btnSkillOne.Click += new System.EventHandler(this.btnSkillOne_Click);
            // 
            // btnSkillTwo
            // 
            this.btnSkillTwo.BackgroundImage = global::Game_Character_GUI.Properties.Resources.MageSkillTwo;
            this.btnSkillTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSkillTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkillTwo.Location = new System.Drawing.Point(25, 286);
            this.btnSkillTwo.Name = "btnSkillTwo";
            this.btnSkillTwo.Size = new System.Drawing.Size(80, 80);
            this.btnSkillTwo.TabIndex = 16;
            this.btnSkillTwo.UseVisualStyleBackColor = true;
            this.btnSkillTwo.Click += new System.EventHandler(this.btnSkillTwo_Click);
            // 
            // btnBuff
            // 
            this.btnBuff.BackgroundImage = global::Game_Character_GUI.Properties.Resources.MageBuff;
            this.btnBuff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuff.Location = new System.Drawing.Point(25, 372);
            this.btnBuff.Name = "btnBuff";
            this.btnBuff.Size = new System.Drawing.Size(80, 80);
            this.btnBuff.TabIndex = 17;
            this.btnBuff.UseVisualStyleBackColor = true;
            this.btnBuff.Click += new System.EventHandler(this.btnBuff_Click);
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScore.Location = new System.Drawing.Point(842, 8);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(146, 55);
            this.lblScore.TabIndex = 22;
            this.lblScore.Text = "Score: ";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyHealth
            // 
            this.lblEnemyHealth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEnemyHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyHealth.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealth.ForeColor = System.Drawing.Color.White;
            this.lblEnemyHealth.Location = new System.Drawing.Point(727, 125);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(207, 14);
            this.lblEnemyHealth.TabIndex = 23;
            this.lblEnemyHealth.Text = "Enemy Health";
            this.lblEnemyHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayerHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealth.Location = new System.Drawing.Point(139, 14);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(95, 21);
            this.lblPlayerHealth.TabIndex = 24;
            this.lblPlayerHealth.Text = "Player Health";
            this.lblPlayerHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurns
            // 
            this.lblTurns.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTurns.BackColor = System.Drawing.Color.Transparent;
            this.lblTurns.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurns.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTurns.Location = new System.Drawing.Point(407, 453);
            this.lblTurns.Name = "lblTurns";
            this.lblTurns.Size = new System.Drawing.Size(189, 45);
            this.lblTurns.TabIndex = 25;
            this.lblTurns.Text = "Turns";
            this.lblTurns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTurns.Visible = false;
            // 
            // btnBasicAttack
            // 
            this.btnBasicAttack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBasicAttack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBasicAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasicAttack.Image = global::Game_Character_GUI.Properties.Resources.BasicAttack;
            this.btnBasicAttack.Location = new System.Drawing.Point(25, 114);
            this.btnBasicAttack.Name = "btnBasicAttack";
            this.btnBasicAttack.Size = new System.Drawing.Size(80, 80);
            this.btnBasicAttack.TabIndex = 26;
            this.btnBasicAttack.UseVisualStyleBackColor = false;
            this.btnBasicAttack.Click += new System.EventHandler(this.btnBasicAttack_Click_1);
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.Location = new System.Drawing.Point(143, 39);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.ProgressColor = System.Drawing.Color.Red;
            this.playerHealthBar.Size = new System.Drawing.Size(301, 30);
            this.playerHealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.playerHealthBar.TabIndex = 21;
            // 
            // energyBar
            // 
            this.energyBar.Location = new System.Drawing.Point(143, 88);
            this.energyBar.Name = "energyBar";
            this.energyBar.ProgressColor = System.Drawing.Color.Red;
            this.energyBar.Size = new System.Drawing.Size(301, 20);
            this.energyBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.energyBar.TabIndex = 20;
            // 
            // EnemyHealthBar
            // 
            this.EnemyHealthBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.EnemyHealthBar.Location = new System.Drawing.Point(610, 125);
            this.EnemyHealthBar.Name = "EnemyHealthBar";
            this.EnemyHealthBar.ProgressColor = System.Drawing.Color.Red;
            this.EnemyHealthBar.Size = new System.Drawing.Size(236, 14);
            this.EnemyHealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyHealthBar.TabIndex = 19;
            // 
            // GameplayForm
            // 
            this.BackgroundImage = global::Game_Character_GUI.Properties.Resources._24;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.btnBasicAttack);
            this.Controls.Add(this.lblTurns);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.lblEnemyHealth);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.energyBar);
            this.Controls.Add(this.EnemyHealthBar);
            this.Controls.Add(this.btnBuff);
            this.Controls.Add(this.btnSkillTwo);
            this.Controls.Add(this.btnSkillOne);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.btnCheckStats);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picEnemy);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameplayForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            this.ResumeLayout(false);

    }

    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private Button btnCheckStats;
    private RichTextBox battleLog;
    private System.ComponentModel.IContainer components;
    public Timer attackTimer;
    private Panel panel1;
    private Button btnSkillOne;
    private Button btnSkillTwo;
    private Button btnBuff;
    private CustomProgressBar EnemyHealthBar;
    private CustomProgressBar energyBar;
    private CustomProgressBar playerHealthBar;
    private Label lblScore;
    private Label lblEnemyHealth;
    private Label lblPlayerHealth;
    private Label lblTurns;
    public Button btnBasicAttack;
}
