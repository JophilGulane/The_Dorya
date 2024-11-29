using System;
using System.Windows.Forms;
using Game_Character_GUI.Class;

namespace Game_Character_GUI
{
    public partial class GameMenu : Form
    {
        public static string PlayerName;
        public static string CharacterType;

        public GameMenu()
        {
            InitializeComponent();
        }

        // Start Game button click
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Get the player name and selected character type
            PlayerName = txtName.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(PlayerName) || string.IsNullOrEmpty(CharacterType))
            {
                MessageBox.Show("Please enter a name and select a character type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hide the main menu form and open the gameplay form
            this.Hide();

            // Create the corresponding player character and enemy based on the selected character type
            GameCharacter playerCharacter = CreatePlayerCharacter(CharacterType);
            Enemy enemyCharacter = new Enemy("Goblin", 100, 20);  // Example enemy, you can customize this

            // Pass the player and enemy characters to the gameplay form
            GameplayForm gameplayForm = new GameplayForm(playerCharacter);
            gameplayForm.Show();
        }

        // Exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method to create the player character based on the selected character type
        private GameCharacter CreatePlayerCharacter(string characterType)
        {
            if (characterType == "Warrior")
            {
                return new Warrior(PlayerName, 1, 100, 15);  // Example Warrior
            }
            else if (characterType == "Mage")
            {
                return new Mage(PlayerName, 1, 100, 15, 10);  // Example Mage
            }
            else
            {
                // Default case, could throw an error or return a generic character
                return new Warrior(PlayerName, 100, 30, 20);  // Default
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void picWarrior_Click(object sender, EventArgs e)
        {
            CharacterType = "Warrior";
            HighlightSelection(picWarrior);
        }

        private void picMage_Click(object sender, EventArgs e)
        {
            CharacterType = "Mage";
            HighlightSelection(picMage);
        }

        private void HighlightSelection(PictureBox selectedPictureBox)
        {
            // Reset all picture borders
            picMage.BorderStyle = BorderStyle.None;
            picWarrior.BorderStyle = BorderStyle.None;
            picMage.BackColor = default;
            picWarrior.BackColor = default;

            // Highlight the selected picture
            selectedPictureBox.BorderStyle = BorderStyle.Fixed3D;
            selectedPictureBox.BackColor = System.Drawing.Color.Red;
        }
    }
}
