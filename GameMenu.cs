using System;
using System.Drawing;
using System.Windows.Forms;
using Game_Character_GUI.Class;

namespace Game_Character_GUI
{
    public partial class GameMenu : Form
    {
        public static string PlayerName;
        public static string CharacterType;
        public static GameCharacter characterClass;

        public GameMenu()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            PlayerName = txtName.Text;

            if (string.IsNullOrEmpty(PlayerName) || string.IsNullOrEmpty(CharacterType))
            {
                MessageBox.Show("Please enter a name and select a character type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            characterClass = CreatePlayerCharacter(CharacterType);
            GameplayForm gameplayForm = new GameplayForm(characterClass);
            gameplayForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private GameCharacter CreatePlayerCharacter(string characterType)
        {
            if (characterType == "Warrior")
            {
                return new Warrior(PlayerName, 1, 100, 15);
            }
            else if (characterType == "Mage")
            {
                return new Mage(PlayerName, 1, 100, 15);
            }
            else
            {
                return null;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void picWarrior_Click(object sender, EventArgs e)
        {
            CharacterType = "Warrior";
            SkillData.CurrentPlayer = new WarriorSkills("",0,0,0,"");
            HighlightSelection(picWarrior);
        }

        private void picMage_Click(object sender, EventArgs e)
        {
            CharacterType = "Mage";
            SkillData.CurrentPlayer = new MageSkills("", 0, 0, 0, "");
            HighlightSelection(picMage);
        }

        private void HighlightSelection(PictureBox selectedPictureBox)
        {
            picWarrior.Image = Game_Character_GUI.Properties.Resources.FemaleWarriorIcon;
            picMage.Image = Game_Character_GUI.Properties.Resources.MagePreview;
            picMage.BackColor = Color.Gray;
            picWarrior.BackColor = Color.Gray;

            selectedPictureBox.BackColor = System.Drawing.Color.DeepPink;
            if (selectedPictureBox.Name == "picWarrior" )
            {
                picWarrior.Image = Game_Character_GUI.Properties.Resources.FemaleWarriorPreview;
            }
            else if (selectedPictureBox.Name == "picMage")
            {
                picMage.Image = Game_Character_GUI.Properties.Resources.MageIdle;
            }
        }
    }
}
