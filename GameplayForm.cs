using Game_Character_GUI.Class;
using Game_Character_GUI;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Diagnostics;

public partial class GameplayForm : Form
{
    private GameCharacter player;
    private Enemy currentEnemy;
    private List<Enemy> enemyList;
    private Point playerStartPos;  // Initial position of the player's PictureBox
    private Point enemyPos;       // Target position (enemy's PictureBox)
    private bool movingToEnemy;   // Flag to indicate direction of movement
    private int stepSize = 10;    // Distance to move per timer tick


    public GameplayForm(GameCharacter playerCharacter)
    {
        InitializeComponent();
        this.player = playerCharacter;
        LoadEnemies();


        StartBattle();
    }

    private void GameplayForm_Load(object sender, EventArgs e)
    {
               // Start by moving to the enemy
    }


    private void LoadEnemies()
    {
        enemyList = new List<Enemy>
        {
            new Enemy("Goblin", 100, 20),
            new Enemy("Orc", 150, 30),
            new Enemy("Dragon", 300, 50)
        };
    }

    private void StartBattle()
    {
        playerStartPos = picPlayer.Location;   // Save initial position
        enemyPos = picEnemy.Location;

        AddToBattleLog($"enemyPos initialized to: {enemyPos}", Color.Red);// Target position

        // Set the correct idle animation for the player
        if (GameMenu.CharacterType == "Warrior")
        {
            picPlayer.Image = Game_Character_GUI.Properties.Resources.WarriorIdle;
        }
        else if (GameMenu.CharacterType == "Mage")
        {
            picPlayer.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy;
        }

        // Update player display
        lblPlayerName.Text = $"Player: {player.Name}";
        // Player health bar
        playerHealthBar.Maximum = player.Health; // Set max health
        playerHealthBar.Value = player.Health;   // Start at full health

        LoadNextEnemy();
    }

    private void LoadNextEnemy()
    {
        if (enemyList.Count > 0)
        {
            // Randomly pick an enemy from the list
            Random random = new Random();
            int index = random.Next(enemyList.Count);
            currentEnemy = enemyList[index];
            enemyList.RemoveAt(index);  // Remove the picked enemy from the list

            // Update enemy display (name, health)
            lblEnemyName.Text = $"Enemy: {currentEnemy.Name}";
            EnemyHealthBar.Maximum = currentEnemy.Health; // Set max health
            EnemyHealthBar.Value = currentEnemy.Health;   // Start at full health


            // Set the correct idle animation for the current enemy
            switch (currentEnemy.Name)
            {
                case "Goblin":
                    picEnemy.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy;
                    break;
                case "Orc":
                    picEnemy.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy;
                    break;
                case "Dragon":
                    picEnemy.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy;
                    break;
                default:
                    picEnemy.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy; // Default GIF if no match
                    break;
            }
        }
        else
        {
            MessageBox.Show("You have defeated all the enemies! Congratulations!");
            this.Close(); // End the game or return to the main menu
        }
    }

    private void btnAttack_Click(object sender, EventArgs e)
    {
        movingToEnemy = true;
        if (player is Warrior warrior)
        {
            warrior.Attack();
            picPlayer.Image = Game_Character_GUI.Properties.Resources.WarriorAttack; // Warrior Attack GIF
        }
        else if (player is Mage mage)
        {
            mage.Attack();
            picPlayer.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy; // Mage Attack GIF
        }
        movingToEnemy = true;  // Start moving toward the enemy
        attackTimer.Start();

        // Apply damage to the enemy
        currentEnemy.TakeDamage(CalculatePlayerDamage());
        UpdateHealthBar(EnemyHealthBar, currentEnemy.Health);


        // Log the battle action
        AddToBattleLog($"Player attacks {currentEnemy.Name} for {CalculatePlayerDamage()} damage", Color.Red);

        // Check if the enemy is defeated
        if (currentEnemy.Health <= 0)
        {
            picEnemy.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy; // Enemy Defeat GIF
            AddToBattleLog($"{currentEnemy.Name} defeated!", Color.Green);

            player.LevelUp();
            AddToBattleLog(player.LevelUp(), Color.Blue);
            StartBattle();
        }
        else
        {
            EnemyTurn();
        }
    }

    private int CalculatePlayerDamage()
    {
        if (player is Warrior warrior)
        {
            return warrior.Strength * 2; // Example Warrior damage
        }
        else if (player is Mage mage)
        {
            return mage.Intelligence * 3 + mage.SpellPower; // Example Mage damage
        }
        return 0; // Fallback
    }

    private void EnemyTurn()
    {
        // Display enemy's attack animation
        picEnemy.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy; // Example enemy attack GIF

        // Perform the enemy's attack on the player, but include defense logic
        int damage = currentEnemy.Attack(player);
        int reducedDamage = player.Defend(damage); // The player's defense reduces the damage

        // Apply the reduced damage to the player's health
        player.Health -= reducedDamage;
        UpdateHealthBar(playerHealthBar, player.Health);


        // Log the enemy's action
        AddToBattleLog($"{currentEnemy.Name} attacks Player and deals {reducedDamage} damage!", Color.Gold);

        // Check if the player is defeated
        if (player.Health <= 0)
        {
            picPlayer.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy; // Player Defeat GIF
            MessageBox.Show("You have been defeated!");
            Application.Exit();
            return;
        }

        // After the attack, reset the enemy's GIF to their idle animation
        switch (currentEnemy.Name)
        {
            case "Goblin":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy;
                break;
            case "Orc":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy;
                break;
            case "Dragon":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy;
                break;
            default:
                picEnemy.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy; // Default idle GIF if no match
                break;
        }
    }

    public void UpdateHealthBar(ProgressBar healthBar, int currentHealth)
    {
        if (currentHealth < 0) currentHealth = 0; // Prevent negative health
        if (currentHealth > healthBar.Maximum) currentHealth = healthBar.Maximum; // Prevent overflow
        healthBar.Value = currentHealth;
    }


    private void btnCheckStats_Click(object sender, EventArgs e)
    {
        MessageBox.Show(player.CheckStats());
    }

    private void AddToBattleLog(string message, Color textColor)
    {
        int start = battleLog.TextLength;
        battleLog.AppendText(message + Environment.NewLine);
        battleLog.Select(start, message.Length);
        battleLog.SelectionColor = textColor;
        battleLog.Select(battleLog.TextLength, 0); // Deselect text
    }

    private Point MoveTowards(Point current, Point target, int step)
    {
        int dx = target.X - current.X;  // Horizontal difference
        int dy = target.Y - current.Y;  // Vertical difference
        int distance = (int)Math.Sqrt(dx * dx + dy * dy);  // Calculate the distance

        if (distance <= step) return target; // If close enough, snap to the target

        // Calculate new position by stepping toward the target
        int stepX = (dx * step) / distance;
        int stepY = (dy * step) / distance;

        return new Point(current.X + stepX, current.Y + stepY);
    }

    private void attackTimer_Tick_1(object sender, EventArgs e)
    {
        AddToBattleLog($"Moving towards enemy at {enemyPos}",Color.Red);
        // Debugging current positions
        Debug.WriteLine($"Player Position: {picPlayer.Location}, Enemy Position: {enemyPos}");

        if (movingToEnemy)
        {
            // Move the player towards the enemy
            picPlayer.Location = MoveTowards(picPlayer.Location, enemyPos, stepSize);

            // Ensure that the player and enemy are brought to the front during movement

            // Check if the player has reached the enemy
            if (picPlayer.Location == enemyPos)
            {
                movingToEnemy = false;
            }
        }
        else
        {
            // After attacking, move the player back to the starting position
            picPlayer.Location = MoveTowards(picPlayer.Location, playerStartPos, stepSize);

            // Check if the player has returned to the start position
            if (picPlayer.Location == playerStartPos)
            {
                attackTimer.Stop(); // Stop the timer when the player reaches the start position
            }
        }
    }



}
