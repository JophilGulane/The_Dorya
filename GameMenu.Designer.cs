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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCharacterType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MageText = new System.Windows.Forms.TextBox();
            this.WarriorText = new System.Windows.Forms.TextBox();
            this.picWarrior = new System.Windows.Forms.PictureBox();
            this.picMage = new System.Windows.Forms.PictureBox();
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
            this.lblCharacterType.Location = new System.Drawing.Point(728, 59);
            this.lblCharacterType.Name = "lblCharacterType";
            this.lblCharacterType.Size = new System.Drawing.Size(119, 30);
            this.lblCharacterType.TabIndex = 2;
            this.lblCharacterType.Text = "Character Type:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtName.Location = new System.Drawing.Point(369, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(295, 30);
            this.txtName.TabIndex = 3;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Arial", 14F);
            this.btnStartGame.Location = new System.Drawing.Point(394, 325);
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
            this.btnExit.Location = new System.Drawing.Point(394, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "output-onlinegiftools.gif");
            this.imageList1.Images.SetKeyName(1, "output-onlinegiftools (1).gif");
            // 
            // MageText
            // 
            this.MageText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MageText.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MageText.ForeColor = System.Drawing.Color.Black;
            this.MageText.Location = new System.Drawing.Point(537, 117);
            this.MageText.Name = "MageText";
            this.MageText.Size = new System.Drawing.Size(184, 21);
            this.MageText.TabIndex = 10;
            this.MageText.Text = "MAGE";
            this.MageText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WarriorText
            // 
            this.WarriorText.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarriorText.Location = new System.Drawing.Point(279, 122);
            this.WarriorText.Name = "WarriorText";
            this.WarriorText.Size = new System.Drawing.Size(179, 21);
            this.WarriorText.TabIndex = 11;
            this.WarriorText.Text = "WARRIOR";
            this.WarriorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picWarrior
            // 
            this.picWarrior.BackColor = System.Drawing.SystemColors.Control;
            this.picWarrior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWarrior.Image = global::Game_Character_GUI.Properties.Resources.WarriorIdle;
            this.picWarrior.Location = new System.Drawing.Point(279, 150);
            this.picWarrior.Name = "picWarrior";
            this.picWarrior.Size = new System.Drawing.Size(163, 154);
            this.picWarrior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWarrior.TabIndex = 9;
            this.picWarrior.TabStop = false;
            this.picWarrior.Click += new System.EventHandler(this.picWarrior_Click);
            this.picWarrior.MouseEnter += new System.EventHandler(this.picWarrior_MouseEnter);
            this.picWarrior.MouseLeave += new System.EventHandler(this.picWarrior_MouseLeave);
            // 
            // picMage
            // 
            this.picMage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picMage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMage.Image = global::Game_Character_GUI.Properties.Resources.MageIdleEnemy;
            this.picMage.Location = new System.Drawing.Point(537, 150);
            this.picMage.Name = "picMage";
            this.picMage.Size = new System.Drawing.Size(184, 154);
            this.picMage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMage.TabIndex = 8;
            this.picMage.TabStop = false;
            this.picMage.Click += new System.EventHandler(this.picMage_Click);
            this.picMage.MouseEnter += new System.EventHandler(this.picMage_MouseEnter);
            this.picMage.MouseLeave += new System.EventHandler(this.picMage_MouseLeave);
            // 
            // GameMenu
            // 
            this.BackgroundImage = global::Game_Character_GUI.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(982, 485);
            this.Controls.Add(this.WarriorText);
            this.Controls.Add(this.MageText);
            this.Controls.Add(this.picWarrior);
            this.Controls.Add(this.picMage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCharacterType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnExit);
            this.Name = "GameMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picWarrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picMage;
        private System.Windows.Forms.PictureBox picWarrior;
        private System.Windows.Forms.TextBox MageText;
        private System.Windows.Forms.TextBox WarriorText;
    }
}
