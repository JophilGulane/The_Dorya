using System.Drawing;
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
            this.btnBasicAttack = new System.Windows.Forms.Button();
            this.Txt_Test = new System.Windows.Forms.TextBox();
            this.btnSkillOne = new System.Windows.Forms.Button();
            this.btnSkillTwo = new System.Windows.Forms.Button();
            this.btnBuff = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
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
            this.lblPlayerName.Location = new System.Drawing.Point(38, 14);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(429, 23);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picPlayer
            // 
            this.picPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Location = new System.Drawing.Point(161, 196);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(345, 270);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer.TabIndex = 2;
            this.picPlayer.TabStop = false;
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEnemyName.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyName.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnemyName.Location = new System.Drawing.Point(537, 13);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(425, 23);
            this.lblEnemyName.TabIndex = 3;
            this.lblEnemyName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picEnemy
            // 
            this.picEnemy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picEnemy.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy.Location = new System.Drawing.Point(501, 194);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(331, 270);
            this.picEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy.TabIndex = 5;
            this.picEnemy.TabStop = false;
            // 
            // btnCheckStats
            // 
            this.btnCheckStats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckStats.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckStats.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCheckStats.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheckStats.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckStats.ForeColor = System.Drawing.Color.Red;
            this.btnCheckStats.Location = new System.Drawing.Point(25, 131);
            this.btnCheckStats.Name = "btnCheckStats";
            this.btnCheckStats.Size = new System.Drawing.Size(100, 50);
            this.btnCheckStats.TabIndex = 10;
            this.btnCheckStats.Text = "Check Status";
            this.btnCheckStats.UseVisualStyleBackColor = false;
            this.btnCheckStats.Click += new System.EventHandler(this.btnCheckStats_Click);
            // 
            // battleLog
            // 
            this.battleLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.battleLog.BackColor = System.Drawing.Color.DarkCyan;
            this.battleLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.battleLog.Location = new System.Drawing.Point(407, 146);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(189, 78);
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
            // btnBasicAttack
            // 
            this.btnBasicAttack.Location = new System.Drawing.Point(25, 206);
            this.btnBasicAttack.Name = "btnBasicAttack";
            this.btnBasicAttack.Size = new System.Drawing.Size(100, 50);
            this.btnBasicAttack.TabIndex = 13;
            this.btnBasicAttack.Text = "Basic Attack";
            this.btnBasicAttack.UseVisualStyleBackColor = true;
            this.btnBasicAttack.Click += new System.EventHandler(this.BtnBasicAttack_Click);
            // 
            // Txt_Test
            // 
            this.Txt_Test.Location = new System.Drawing.Point(739, 82);
            this.Txt_Test.Multiline = true;
            this.Txt_Test.Name = "Txt_Test";
            this.Txt_Test.ReadOnly = true;
            this.Txt_Test.Size = new System.Drawing.Size(164, 106);
            this.Txt_Test.TabIndex = 14;
            // 
            // btnSkillOne
            // 
            this.btnSkillOne.Location = new System.Drawing.Point(25, 281);
            this.btnSkillOne.Name = "btnSkillOne";
            this.btnSkillOne.Size = new System.Drawing.Size(100, 50);
            this.btnSkillOne.TabIndex = 15;
            this.btnSkillOne.Text = "Skill One";
            this.btnSkillOne.UseVisualStyleBackColor = true;
            this.btnSkillOne.Click += new System.EventHandler(this.btnSkillOne_Click);
            // 
            // btnSkillTwo
            // 
            this.btnSkillTwo.Location = new System.Drawing.Point(25, 356);
            this.btnSkillTwo.Name = "btnSkillTwo";
            this.btnSkillTwo.Size = new System.Drawing.Size(100, 50);
            this.btnSkillTwo.TabIndex = 16;
            this.btnSkillTwo.Text = "Skill Two";
            this.btnSkillTwo.UseVisualStyleBackColor = true;
            this.btnSkillTwo.Click += new System.EventHandler(this.btnSkillTwo_Click);
            // 
            // btnBuff
            // 
            this.btnBuff.Location = new System.Drawing.Point(25, 431);
            this.btnBuff.Name = "btnBuff";
            this.btnBuff.Size = new System.Drawing.Size(100, 50);
            this.btnBuff.TabIndex = 17;
            this.btnBuff.Text = "Buff";
            this.btnBuff.UseVisualStyleBackColor = true;
            this.btnBuff.Click += new System.EventHandler(this.btnBuff_Click);
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScore.Location = new System.Drawing.Point(450, 88);
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
            this.lblEnemyHealth.Location = new System.Drawing.Point(866, 9);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(96, 27);
            this.lblEnemyHealth.TabIndex = 23;
            this.lblEnemyHealth.Text = "Enemy Health";
            this.lblEnemyHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayerHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealth.Location = new System.Drawing.Point(40, 9);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(96, 27);
            this.lblPlayerHealth.TabIndex = 24;
            this.lblPlayerHealth.Text = "Enemy Health";
            this.lblPlayerHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.Location = new System.Drawing.Point(44, 39);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.ProgressColor = System.Drawing.Color.Red;
            this.playerHealthBar.Size = new System.Drawing.Size(400, 30);
            this.playerHealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.playerHealthBar.TabIndex = 21;
            // 
            // energyBar
            // 
            this.energyBar.Location = new System.Drawing.Point(44, 88);
            this.energyBar.Name = "energyBar";
            this.energyBar.ProgressColor = System.Drawing.Color.Red;
            this.energyBar.Size = new System.Drawing.Size(400, 20);
            this.energyBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.energyBar.TabIndex = 20;
            // 
            // EnemyHealthBar
            // 
            this.EnemyHealthBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.EnemyHealthBar.Location = new System.Drawing.Point(572, 39);
            this.EnemyHealthBar.Name = "EnemyHealthBar";
            this.EnemyHealthBar.ProgressColor = System.Drawing.Color.Red;
            this.EnemyHealthBar.Size = new System.Drawing.Size(389, 37);
            this.EnemyHealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyHealthBar.TabIndex = 19;
            // 
            // GameplayForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.lblEnemyHealth);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.energyBar);
            this.Controls.Add(this.EnemyHealthBar);
            this.Controls.Add(this.btnBuff);
            this.Controls.Add(this.btnSkillTwo);
            this.Controls.Add(this.btnSkillOne);
            this.Controls.Add(this.Txt_Test);
            this.Controls.Add(this.btnBasicAttack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.btnCheckStats);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.picEnemy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameplayForm";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private Button btnCheckStats;
    private RichTextBox battleLog;
    private System.ComponentModel.IContainer components;
    public Timer attackTimer;
    private Panel panel1;
    private Button btnBasicAttack;
    private TextBox Txt_Test;
    private Button btnSkillOne;
    private Button btnSkillTwo;
    private Button btnBuff;
    private CustomProgressBar EnemyHealthBar;
    private CustomProgressBar energyBar;
    private CustomProgressBar playerHealthBar;
    private Label lblScore;
    private Label lblEnemyHealth;
    private Label lblPlayerHealth;
}
