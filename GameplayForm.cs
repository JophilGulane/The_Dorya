using Game_Character_GUI;
using Game_Character_GUI.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

public partial class GameplayForm : Form
{
    private GameCharacter player;
    private Enemy currentEnemy;
    private List<Enemy> enemyList;

    //Score
    private int Score = 0;

    private Timer enemyTurnTimer;
    private int enemyTurnDelay = 5000;
    public GameplayForm(GameCharacter playerCharacter)
    {
        InitializeComponent();
        player = playerCharacter;
        InitializePlayer();
        StartBattle();
    }

    private void LoadEnemies(int Level)
    {
        enemyList = new List<Enemy>
        {
            new Enemy("Skeleton", Level, 100, 10),
            new Enemy("Bat", Level, 125, 15),
            new Enemy("Orc", Level, 150, 20)
        };
    }

    private void StartBattle()
    {
        LoadNextEnemy();
    }

    private void LoadNextEnemy()
    {

        Random random = new Random();
        int EnemyLevel = random.Next((player.Level + 1) / 2, player.Level);
        LoadEnemies(EnemyLevel);
        int index = random.Next(enemyList.Count);
        currentEnemy = enemyList[index];
        currentEnemy.Level = EnemyLevel;

        SetEnemyIdle();
        lblEnemyName.Text = $"{currentEnemy.Name} lvl. {currentEnemy.Level}";
        lblEnemyName.ForeColor = Color.Red;

        EnemyHealthBar.Maximum = currentEnemy.Health;
        EnemyHealthBar.Value = currentEnemy.Health;
        EnemyHealthBar.ProgressColor = Color.Red;
        UpdateHealthBar(EnemyHealthBar, currentEnemy.Health);
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
            target.Top - 50
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
        EnemyAttack();
    }

    private void EnemyTurnTimer_Tick(object sender, EventArgs e)
    {
        enemyTurnTimer.Stop();
        EnemyTurn();
        StartPlayerTurn();
    }

    private void StartPlayerTurn()
    {
        AddToBattleLog("Enemy's Turn!", Color.Green);
        EnablePlayerControls();
    }

    private void StartEnemyTurn()
    {
        enemyTurnTimer = new Timer();
        enemyTurnTimer.Interval = enemyTurnDelay;
        enemyTurnTimer.Tick += EnemyTurnTimer_Tick;

        AddToBattleLog("Enemy's Turn!", Color.Green);
        DisablePlayerControls();
        enemyTurnTimer.Start();
        Timer DelayEnemyAttack = new Timer();
        DelayEnemyAttack.Interval = 3000;
        DelayEnemyAttack.Start();
    }



    public void InitializePlayer()
    {
        if (GameMenu.CharacterType == "Warrior")
        {
            picPlayer.Image = Game_Character_GUI.Properties.Resources.FemaleWarriorIdle;
        }
        else if (GameMenu.CharacterType == "Mage")
        {
            picPlayer.Image = Game_Character_GUI.Properties.Resources.MageIdle;
        }

        lblPlayerName.Text = $"{player.Name} lvl. {player.Level}";
        lblPlayerName.ForeColor = Color.White;
        playerHealthBar.Maximum = player.Health;
        playerHealthBar.Value = player.Health;
        playerHealthBar.ProgressColor = Color.Green;
        lblPlayerHealth.Text = $"{player.Health}/{playerHealthBar.Maximum}";

        lblScore.Text = $"Score: {Score}";
        if (player is Warrior warrior)
        {
            energyBar.Value = warrior.Stamina;
            energyBar.Maximum = warrior.Stamina;
            energyBar.ProgressColor = Color.Orange;
        }
        else if (player is Mage mage)
        {
            energyBar.Value = mage.Mana;
            energyBar.Maximum = mage.Mana;
            energyBar.ProgressColor = Color.Blue;
        }

    }
    public void UpdateHealthBar(ProgressBar healthBar, int currentHealth)
    {
        if (currentHealth < 0) currentHealth = 0;
        if (currentHealth > healthBar.Maximum) currentHealth = healthBar.Maximum;
        healthBar.Value = currentHealth;

        if (healthBar.Name == "playerHealthBar")
        {
            lblPlayerHealth.Text = $"{player.Health}/{playerHealthBar.Maximum}";
        }
        else if (healthBar.Name == "EnemyHealthBar")
        {
            lblEnemyHealth.Text = $"{currentEnemy.Health}/{EnemyHealthBar.Maximum}";
        }
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



    private void ActivateSkill(string skill) 
    {
        int damage = 0;
        int energyCost = 0;
        int buff = 0;
        if (skill == "BasicAttack")
        {
            damage = SkillData.CurrentPlayer.UseResortSkill() * (player.Level + 1 / 2);
            energyCost = SkillData.CurrentPlayer.EnergyCost;
        }
        else if (skill == "SkillOne")
        {
            damage = SkillData.CurrentPlayer.UseBasicSkill() * (player.Level + 1 / 2);
            energyCost = SkillData.CurrentPlayer.EnergyCost;
        }
        else if (skill == "SkillTwo")
        {
            damage = SkillData.CurrentPlayer.UseUltimateSkill() * (player.Level + 1 / 2);
            energyCost = SkillData.CurrentPlayer.EnergyCost;
        }
        else if (skill == "Buff")
        {
            buff = SkillData.CurrentPlayer.UseBuffSkill() * (player.Level + 1 / 2);
            energyCost = SkillData.CurrentPlayer.EnergyCost;
        }

        if (player is Warrior warrior)
        {
            if (warrior.Stamina >= energyCost)
            {
                warrior.Stamina -= energyCost;
                UpdateEnergyBar(energyBar, warrior.Stamina);
                PlayerAttack(damage);
                EnemyHurt();
            }
            else
            {
                AddToBattleLog($"Not enough stamina", Color.Red);
            }
        }
        else if (player is Mage mage)
        {
            if (mage.Mana >= energyCost)
            {
                mage.Mana -= energyCost;
                UpdateEnergyBar(energyBar, mage.Mana);
                PlayerAttack(damage);
                EnemyHurt();
            }
            else
            {
                AddToBattleLog($"Not enough mana", Color.Red);
            }
        }
    }

    private void energyBar_Click(object sender, EventArgs e)
    {
        energyBar.ForeColor = Color.White;
    }

    public void UpdateEnergyBar(ProgressBar energyBar, int currentEnergy)
    {
        if (currentEnergy < 0) currentEnergy = 0;
        if (currentEnergy > energyBar.Maximum) currentEnergy = energyBar.Maximum;
        energyBar.Value = currentEnergy;
    }
    private void BtnBasicAttack_Click(object sender, EventArgs e)
    {
        ActivateSkill("BasicAttack");
    }

    private void btnSkillOne_Click(object sender, EventArgs e)
    {
        ActivateSkill("SkillOne");
    }

    private void btnSkillTwo_Click(object sender, EventArgs e)
    {
        ActivateSkill("SkillTwo");
    }

    private void btnBuff_Click(object sender, EventArgs e)
    {
        ActivateSkill("SkillTwo");
    }

    private void PlayerAttack(int damage)
    {
        currentEnemy.TakeDamage(damage);
        AddToBattleLog($"Player attacks {currentEnemy.Name} using {SkillData.CurrentPlayer.Name} for {damage} damage", Color.Red);
        ShowDamagePopup(damage, picEnemy);
        UpdateHealthBar(EnemyHealthBar, currentEnemy.Health);
        PlayPlayerAttackAnimation();

        if (currentEnemy.Health <= 0)
        {
            player.LevelUp();
            playerHealthBar.Maximum = player.Health;
            lblPlayerName.Text = $"{player.Name} lvl. {player.Level}";
            UpdateHealthBar(playerHealthBar, player.Health);
            HealthRegen();
            AddScore();
            AddToBattleLog($"{currentEnemy.Name} defeated!", Color.Green);
            AddToBattleLog($"{player.Level - 1} --> {player.Level} ", Color.Blue);
            StartBattle();
        }
        else
        {
            StartEnemyTurn();
        }

    }

    private void PlayPlayerAttackAnimation()
    {
        if (GameMenu.CharacterType == "Warrior")
        {
            picPlayer.Image = Game_Character_GUI.Properties.Resources.FemaleWarriorSlowAttack;
        }
        else if (GameMenu.CharacterType == "Mage")
        {
            picPlayer.Image = Game_Character_GUI.Properties.Resources.MageAttack;
        }
        EnemyHurt();
        Timer playerAttackTimer = new Timer();
        playerAttackTimer.Interval = 2000;
        playerAttackTimer.Tick += (s, e) =>
        {
            playerAttackTimer.Stop();
            playerAttackTimer.Dispose();
            PlayerIdle();
            SetEnemyIdle();
        };
        playerAttackTimer.Start();
        AddToBattleLog("Player Attack Animation", Color.Green);
    }

    private void PlayEnemyAttackAnimation()
    {
        EnemyAttackAnimation();
        PlayerHurt();
        Timer enemyAttackTimer = new Timer();
        enemyAttackTimer.Interval = 2000;
        enemyAttackTimer.Tick += (s, e) =>
        {
            enemyAttackTimer.Stop();
            enemyAttackTimer.Dispose();
            PlayerIdle();
            SetEnemyIdle();
        };
        enemyAttackTimer.Start();
        AddToBattleLog("Player Attack Animation", Color.Green);
    }

    private void AddScore()
    {
        Score += 1;
        lblScore.Text = $"Score: {Score.ToString()}";
    }

    private void HealthRegen()
    {
        player.Health = playerHealthBar.Maximum;
    }

    private void SetEnemyIdle()
    {
        switch (currentEnemy.Name)
        {
            case "Skeleton":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.SkeletonIdle;
                break;
            case "Bat":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.BatIdle;
                break;
            case "Orc":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.OrcIdle;
                break;

        }
    }

    private void EnemyHurt()
    {
        switch (currentEnemy.Name)
        {
            case "Skeleton":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.SkeletonHurt;
                break;
            case "Bat":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.BatIdle;
                break;
            case "Orc":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.OrcHurt;
                break;

        }
    }

    private void PlayerHurt()
    {
        if (GameMenu.CharacterType == "Warrior")
        {
            picPlayer.Image = Game_Character_GUI.Properties.Resources.FemaleWarriorHurt;
        }
        else if (GameMenu.CharacterType == "Mage")
        {
            picPlayer.Image = Game_Character_GUI.Properties.Resources.MageHurt;
        }
    }

    private void EnemyDeath()
    {
        switch (currentEnemy.Name)
        {
            case "Skeleton":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.SkeletonDeath;
                break;
            case "Bat":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.BatIdle;
                break;
            case "Orc":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.OrcDeath;
                break;

        }
    }

    private void EnemyAttackAnimation()
    {
        switch (currentEnemy.Name)
        {
            case "Skeleton":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.SkeletonAttack1;
                break;
            case "Bat":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.BatAttack;
                break;
            case "Orc":
                picEnemy.Image = Game_Character_GUI.Properties.Resources.OrcAttack;
                break;

        }
    }

    private void EnemyAttack()
    {
        PlayEnemyAttackAnimation();
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
            MessageBox.Show($"Final Score is {Score}");
            return;
        }
    }

    private void EnablePlayerControls()
    {
        btnBasicAttack.Enabled = true;
        btnSkillOne.Enabled = true;
        btnSkillTwo.Enabled = true;
        btnBuff.Enabled = true;
    }

    private void DisablePlayerControls()
    {
        btnBasicAttack.Enabled = false;
        btnSkillOne.Enabled = false;
        btnSkillTwo.Enabled = false;
        btnBuff.Enabled = false;
    }

    private void PlayerIdle()
    {
        if (GameMenu.CharacterType == "Warrior")
        {
            picPlayer.Image = Game_Character_GUI.Properties.Resources.FemaleWarriorIdle;
        }
        else if (GameMenu.CharacterType == "Mage")
        {
            picPlayer.Image = Game_Character_GUI.Properties.Resources.MageIdle;
        }
    }
}
