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
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(250, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Character Creation";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblName.Location = new System.Drawing.Point(321, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 30);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblCharacterType
            // 
            this.lblCharacterType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterType.Location = new System.Drawing.Point(425, 115);
            this.lblCharacterType.Name = "lblCharacterType";
            this.lblCharacterType.Size = new System.Drawing.Size(184, 27);
            this.lblCharacterType.TabIndex = 2;
            this.lblCharacterType.Text = "Select Class";
            this.lblCharacterType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtName.Location = new System.Drawing.Point(410, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 30);
            this.txtName.TabIndex = 3;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Arial", 14F);
            this.btnStartGame.Location = new System.Drawing.Point(410, 337);
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
            this.btnExit.Location = new System.Drawing.Point(410, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWarrior
            // 
            this.lblWarrior.AutoSize = true;
            this.lblWarrior.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarrior.Location = new System.Drawing.Point(309, 134);
            this.lblWarrior.Name = "lblWarrior";
            this.lblWarrior.Size = new System.Drawing.Size(130, 25);
            this.lblWarrior.TabIndex = 12;
            this.lblWarrior.Text = "WARRIOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "MAGE";
            // 
            // picWarrior
            // 
            this.picWarrior.BackColor = System.Drawing.Color.Gray;
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
            this.picMage.BackColor = System.Drawing.Color.Gray;
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
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1000, 500);
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
        private System.Windows.Forms.Label lblWarrior;
        private System.Windows.Forms.Label label2;
    }
}
