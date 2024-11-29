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
    public GameplayForm(GameCharacter playerCharacter)
    {
        InitializeComponent();
        this.player = playerCharacter;
        InitializePlayer();
        LoadEnemies();
        StartBattle();
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
        if (GameMenu.CharacterType == "Warrior")
        {
            picPlayer.Image = Game_Character_GUI.Properties.Resources.WarriorIdle;
        }
        else if (GameMenu.CharacterType == "Mage")
        {
            picPlayer.Image = Game_Character_GUI.Properties.Resources.MageIdle;
        }
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
            lblEnemyName.Text = $"{currentEnemy.Name}";
            lblEnemyName.ForeColor = Color.Red;
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
        int damage = 0;
        if (player is Warrior warrior)
        {
            damage = warrior.Attack();
            currentEnemy.TakeDamage(damage);
            AddToBattleLog($"Player attacks {currentEnemy.Name} for {warrior.Attack()} damage", Color.Red);
            ShowDamagePopup(damage, picEnemy);
            picPlayer.Image = Game_Character_GUI.Properties.Resources.WarriorAttack;
        }
        else if (player is Mage mage)
        {
            damage = mage.Attack();
            currentEnemy.TakeDamage(damage);
            AddToBattleLog($"Player attacks {currentEnemy.Name} for {mage.Attack()} damage", Color.Red);
            ShowDamagePopup(damage, picEnemy);
            picPlayer.Image = Game_Character_GUI.Properties.Resources.MageAttack;
        }


        UpdateHealthBar(EnemyHealthBar, currentEnemy.Health);

        Timer animationTimer = new Timer();


        if (GameMenu.CharacterType == "Warrior")
        {
            animationTimer.Interval = 3000;
        }
        else if (GameMenu.CharacterType == "Mage")
        {
            animationTimer.Interval = 6000;
        }
        animationTimer.Tick += (s, ev) =>
        {
            if (player is Warrior)
                picPlayer.Image = Game_Character_GUI.Properties.Resources.WarriorIdle;
            else if (player is Mage)
                picPlayer.Image = Game_Character_GUI.Properties.Resources.MageIdle;
            animationTimer.Stop();
            animationTimer.Dispose();
        };
        animationTimer.Start();

        if (currentEnemy.Health <= 0)
        {
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

    private void ShowDamagePopup(int damage, Control target)
    {
        Label damageLabel = new Label
        {
            Text = $"-{damage}",
            AutoSize = true,
            Font = new Font("Arial", 16, FontStyle.Bold),
            ForeColor = Color.Red,
            BackColor = Color.Transparent
        };

        damageLabel.Location = new Point(
            target.Left + (target.Width / 2) - (damageLabel.Width / 2),
            target.Top - 20
        );

        this.Controls.Add(damageLabel);

        int animationSteps = 15;
        int stepDuration = 100;
        int moveUpPixels = 1;
        int alpha = 255;

        Timer animationTimer = new Timer();
        animationTimer.Interval = stepDuration;
        animationTimer.Tick += (s, e) =>
        {
            if (animationSteps > 0)
            {
                damageLabel.Top -= moveUpPixels;

                alpha -= 255 / 20;
                damageLabel.ForeColor = Color.FromArgb(
                    Math.Max(alpha, 0),
                    damageLabel.ForeColor.R,
                    damageLabel.ForeColor.G,
                    damageLabel.ForeColor.B
                );

                animationSteps--;
            }
            else
            {
                animationTimer.Stop();
                animationTimer.Dispose();
                this.Controls.Remove(damageLabel);
                damageLabel.Dispose();
            }
        };

        animationTimer.Start();
    }


    private void EnemyTurn()
    {
        picEnemy.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy;
        int damage = currentEnemy.Attack(player);
        int reducedDamage = player.Defend(damage);

        if (reducedDamage == 0)
        {
            AddToBattleLog($"{currentEnemy.Name} attacked blocked", Color.Green);
        }
        else
        {
            player.Health -= reducedDamage;
            AddToBattleLog($"{currentEnemy.Name} attacks Player and deals {reducedDamage} damage!", Color.Gold);
        }
        ShowDamagePopup(reducedDamage, picPlayer);

        UpdateHealthBar(playerHealthBar, player.Health);

        if (player.Health <= 0)
        {
            MessageBox.Show("You have been defeated!");
            Application.Exit();
            return;
        }

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
                picEnemy.Image = Game_Character_GUI.Properties.Resources.MageIdleEnemy;
                break;
        }
    }

    public void InitializePlayer()
    {
        lblPlayerName.Text = $"{player.Name}";
        lblPlayerName.ForeColor = Color.White;
        playerHealthBar.Maximum = player.Health;
        playerHealthBar.Value = player.Health;
    }
    public void UpdateHealthBar(ProgressBar healthBar, int currentHealth)
    {
        if (currentHealth < 0) currentHealth = 0;
        if (currentHealth > healthBar.Maximum) currentHealth = healthBar.Maximum;
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
        battleLog.Select(battleLog.TextLength, 0);
    }
}
