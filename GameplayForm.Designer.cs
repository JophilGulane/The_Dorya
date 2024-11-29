using System.Drawing;
using System.Windows.Forms;
using System;

public partial class GameplayForm : Form
{
    private Label lblPlayerName;
    private PictureBox picPlayer;
    private Label lblEnemyName;
    private PictureBox picEnemy;
    private Button btnAttack;

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameplayForm));
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.EnemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.btnCheckStats = new System.Windows.Forms.Button();
            this.battleLog = new System.Windows.Forms.RichTextBox();
            this.attackTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblPlayerName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayerName.Location = new System.Drawing.Point(117, 20);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(169, 23);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player: ";
            // 
            // picPlayer
            // 
            this.picPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Location = new System.Drawing.Point(122, 196);
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
            this.lblEnemyName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEnemyName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnemyName.Location = new System.Drawing.Point(635, 20);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(175, 23);
            this.lblEnemyName.TabIndex = 3;
            this.lblEnemyName.Text = "Enemy: ";
            // 
            // picEnemy
            // 
            this.picEnemy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picEnemy.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy.Location = new System.Drawing.Point(536, 196);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(331, 270);
            this.picEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy.TabIndex = 5;
            this.picEnemy.TabStop = false;
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Transparent;
            this.btnAttack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAttack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.Font = new System.Drawing.Font("Arial", 14F);
            this.btnAttack.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAttack.Location = new System.Drawing.Point(228, 75);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(141, 45);
            this.btnAttack.TabIndex = 6;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // EnemyHealthBar
            // 
            this.EnemyHealthBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnemyHealthBar.Location = new System.Drawing.Point(536, 46);
            this.EnemyHealthBar.Name = "EnemyHealthBar";
            this.EnemyHealthBar.Size = new System.Drawing.Size(331, 23);
            this.EnemyHealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnemyHealthBar.TabIndex = 8;
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerHealthBar.BackColor = System.Drawing.SystemColors.Control;
            this.playerHealthBar.Location = new System.Drawing.Point(122, 46);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(345, 23);
            this.playerHealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.playerHealthBar.TabIndex = 9;
            // 
            // btnCheckStats
            // 
            this.btnCheckStats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckStats.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckStats.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCheckStats.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheckStats.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckStats.ForeColor = System.Drawing.Color.Red;
            this.btnCheckStats.Location = new System.Drawing.Point(38, 75);
            this.btnCheckStats.Name = "btnCheckStats";
            this.btnCheckStats.Size = new System.Drawing.Size(141, 47);
            this.btnCheckStats.TabIndex = 10;
            this.btnCheckStats.Text = "Check Status";
            this.btnCheckStats.UseVisualStyleBackColor = false;
            this.btnCheckStats.Click += new System.EventHandler(this.btnCheckStats_Click);
            // 
            // battleLog
            // 
            this.battleLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.battleLog.Location = new System.Drawing.Point(392, 87);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(222, 101);
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
            // GameplayForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.btnCheckStats);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.EnemyHealthBar);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.btnAttack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameplayForm";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            this.ResumeLayout(false);

    }

    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private ProgressBar EnemyHealthBar;
    private ProgressBar playerHealthBar;
    private Button btnCheckStats;
    private RichTextBox battleLog;
    private System.ComponentModel.IContainer components;
    public Timer attackTimer;
    private Panel panel1;
}
