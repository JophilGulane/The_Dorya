namespace Game_Character_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCharacterType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picWarrior = new System.Windows.Forms.PictureBox();
            this.picMage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWarrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(300, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Character Creation";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblName.Location = new System.Drawing.Point(274, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 30);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblCharacterType
            // 
            this.lblCharacterType.Font = new System.Drawing.Font("Arial", 14F);
            this.lblCharacterType.Location = new System.Drawing.Point(405, 102);
            this.lblCharacterType.Name = "lblCharacterType";
            this.lblCharacterType.Size = new System.Drawing.Size(184, 27);
            this.lblCharacterType.TabIndex = 2;
            this.lblCharacterType.Text = "Character Type:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtName.Location = new System.Drawing.Point(369, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(383, 30);
            this.txtName.TabIndex = 3;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Arial", 14F);
            this.btnStartGame.Location = new System.Drawing.Point(400, 348);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(200, 50);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 14F);
            this.btnExit.Location = new System.Drawing.Point(400, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picWarrior
            // 
            this.picWarrior.BackColor = System.Drawing.SystemColors.Control;
            this.picWarrior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWarrior.Image = ((System.Drawing.Image)(resources.GetObject("picWarrior.Image")));
            this.picWarrior.Location = new System.Drawing.Point(257, 174);
            this.picWarrior.Name = "picWarrior";
            this.picWarrior.Size = new System.Drawing.Size(179, 154);
            this.picWarrior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWarrior.TabIndex = 9;
            this.picWarrior.TabStop = false;
            this.picWarrior.Click += new System.EventHandler(this.picWarrior_Click);
            // 
            // picMage
            // 
            this.picMage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picMage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMage.Image = global::Game_Character_GUI.Properties.Resources.MageIdle;
            this.picMage.Location = new System.Drawing.Point(568, 174);
            this.picMage.Name = "picMage";
            this.picMage.Size = new System.Drawing.Size(184, 154);
            this.picMage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMage.TabIndex = 8;
            this.picMage.TabStop = false;
            this.picMage.Click += new System.EventHandler(this.picMage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "WARRIOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "MAGE";
            // 
            // GameMenu
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picWarrior);
            this.Controls.Add(this.picMage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCharacterType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picWarrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.PictureBox picMage;
        private System.Windows.Forms.PictureBox picWarrior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
