using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class DunegonMain : MonoBehaviour
{
    //Initalize
    private User myUser;
    private Enemy Enemy;

    // Round Count
    private int roundCount = 1;

    // Control Button
    public Button theButton;
    public Button enemyButton;

    // Text Objects
    public GameObject LoseTextObject;
    public GameObject RoundTextObject;
    public GameObject HPTextObject;
    public GameObject AttackTextObject;
    public GameObject PotCountTextObject;
    public GameObject EnemyNameTextObject;
    public GameObject EnemyTextObject;

    private TextMeshProUGUI LoseText { get; set;}
    private TextMeshProUGUI RoundText { get; set;}
    private TextMeshProUGUI HPText { get; set;}
    private TextMeshProUGUI AttackText { get; set;}
    private TextMeshProUGUI PotCountText { get; set;}
    private TextMeshProUGUI EnemyNameText { get; set;}
    private TextMeshProUGUI EnemyText { get; set;}


    // Start is called before the first frame update
    void Start()
    {
        // Set Text to Texts
        LoseText = LoseTextObject.GetComponent<TextMeshProUGUI>();
        RoundText = RoundTextObject.GetComponent<TextMeshProUGUI>();
        HPText = HPTextObject.GetComponent<TextMeshProUGUI>();
        AttackText = AttackTextObject.GetComponent<TextMeshProUGUI>();
        PotCountText = PotCountTextObject.GetComponent<TextMeshProUGUI>();
        EnemyNameText = EnemyNameTextObject.GetComponent<TextMeshProUGUI>();
        EnemyText = EnemyTextObject.GetComponent<TextMeshProUGUI>();

        // Assign Button
        Button ContinueButton = theButton.GetComponent<Button>();
        Button NextEnemyButton = enemyButton.GetComponent<Button>();

        // Create user 
        myUser = new User();

        // Create Enemy
        Enemy = new Enemy();

        // Add listener after enemy is created so user can start actions
        ContinueButton.onClick.AddListener(buttonPress);
        NextEnemyButton.onClick.AddListener(newEnemy);
    }

    // Update is called once per frame
    void Update()
    {
        // Round update
        RoundText.text = "Round: " + roundCount;

        // User update
        HPText.text = "HP: " + myUser.getHP().ToString();
        AttackText.text = "Attack: " + myUser.getAttack().ToString();
        PotCountText.text = "HP Pot: " + myUser.getPot().ToString();

        // Enemy Update
        EnemyNameText.text = Enemy.getName().ToString();
        EnemyText.text = "HP: " + Enemy.getHP().ToString() + "\nAttack: " + Enemy.getAttack().ToString() + "\nSpeed: " + Enemy.getSpeed().ToString(); 
    }

    // Button Attack
    public void buttonPress()
    {
        runtime();
        // Check to see if use lost
        if (myUser.getHP() <= 0)
        {
            LoseText.text = "You Lost :/ \nRe-Run to try again!";
        }
    }

    private void runtime()
    {
        // Check that the game can still be played
        if (myUser.getHP() > 0)
        {
            if (Enemy.getHP() > 0)
            {
                // Check who is faster
                if (Enemy.getSpeed() > myUser.getSpeed())                 
                {
                    // If enemy is faster, enemy attacks first
                    int tempEnemy = Enemy.getAttack();
                    int userHP = myUser.getHP();
                    userHP = userHP - tempEnemy;
                    myUser.setHP(userHP);

                    // User attacks back
                    int tempUser = myUser.getAttack();
                    int enemyHP = Enemy.getHP();
                    enemyHP = enemyHP - tempUser;
                    Enemy.setHP(enemyHP);
                } else
                {
                    // If user is faster, attack first
                    int tempUser = myUser.getAttack();
                    int enemyHP = Enemy.getHP();
                    enemyHP = enemyHP - tempUser;
                    Enemy.setHP(enemyHP);

                    // Enemy attacks back
                    int tempEnemy = Enemy.getAttack();
                    int userHP = myUser.getHP();
                    userHP = userHP - tempEnemy;
                    myUser.setHP(userHP);
                }
            }
            // Check to see if a health pot should be used, set to 40 or lower
            if (myUser.getPot() > 0) 
            {
                if (myUser.getHP() <= 40)
                {
                    myUser.setPot(myUser.getPot() - 1);
                    myUser.setHP(100);
                }
            }
        }
    }

    // Button to spawn next enemy
    public void newEnemy()
    {
        // Check that the game should not be over
        if (myUser.getHP() > 0)
        {
            if (Enemy.getHP() <= 0)
            {
                // Apply Item drop bonuses from defeated enemy
                switch (Enemy.getItem())
                {
                    case "Goblins Pouch":
                        myUser.setPot(myUser.getPot() + 1);
                        break;
                    case "Vampire Cloak":
                        myUser.setSpeed(myUser.getSpeed() + .05f);
                        break;
                    case "Big Club":
                        myUser.setAttack(myUser.getAttack() + 1);
                        break;         
                }
                // Increase round count to accurately display amount of enemies defeated
                roundCount = roundCount + 1;
                spawner();
            }
        }
    }

    private void spawner()
    {
        // Pick a random number to choose the battle
        int rand_num = UnityEngine.Random.Range(0,3);

        // Switch on the random number, creating a random "order" of enemies
        switch (rand_num)
        {
            case 0:
                // Basic Goblin
                Enemy = new Enemy();
                break;
            case 1:
                // Vamp
                Enemy = new Enemy(40, 25, 5.5f, "Vampire", "Vampire Cloak");
                break;
            case 2:
                // Brute
                Enemy = new Enemy(50, 30, 2.0f, "Brute Goblin", "Big Club");
                break;          
        }
    }
}