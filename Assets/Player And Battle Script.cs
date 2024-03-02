using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAndBattleScript : MonoBehaviour
{

    public int playerHealth = 100;
    public int playerLevel = 1;
    public int playerAttackDamage = 20;
    public int playerExpereince = 0;
    public int playerXPCap = 20;
    public int PlayerLevelUp;
    public int enemyHealth;
   
    // Start is called before the first frame update
    void Start()
    {
        // Establish health and AD as well as the enemies health.
        playerHealth = 100;
        playerAttackDamage = 20;
        enemyHealth = Random.Range(40, 100);
        Debug.Log("Welcome!!! You're probably wondering about your stats so here they are. Health :" + playerHealth + " Attack Damage: " + playerAttackDamage + " Level: " + playerLevel);
        Debug.Log("Can you hear that? Try Pressing W to Look Ahead!");

    }

    // Update is called once per frame
    void Update()
    {
        //Its time to get the enemy to appear and the battle stage to begin

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("OMG!!! An Enemy Has Approached!!! and its health is:  " + enemyHealth + " Hit it Using R");
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            enemyHealth = enemyHealth - playerAttackDamage;
            Debug.Log("WOW!!! That did some damage, its health is now at" + enemyHealth);

        }

        if (enemyHealth <= 0)
        {
            Debug.Log("God that was scary, good kill. Your Reward is XP! Here have 20 xp");
            playerExpereince++;
            Victory();
            
            
        }

                
    } 

    void Victory()
    {
        if (playerXPCap <= 20)
        {
            Debug.Log("Congratulations on the Level up!");
            playerExpereince = 0;
            playerHealth = playerHealth + 50;
            playerAttackDamage = playerAttackDamage + 20;
            playerLevel = playerLevel + 1;
            enemyHealth = playerAttackDamage * 10;
            EndGame();

            Debug.Log("Lets have a look at your stats! You health is now at:" + playerHealth + "Your Attack Damage is now at: " + playerAttackDamage + "Your Level is Now: " + playerLevel);
            Debug.Log("Your Experience has been reset to: " + playerExpereince);
            Debug.Log("Oh NO!!! This one is higher level, destroy this one now with your upgraded stats! its health is now at " + enemyHealth);
        }
    }


    void EndGame()
    {
        if (playerLevel == 5)
        {
            Destroy(gameObject);
            Debug.Log("Congratulations on winning the game, thank you for Playing!");
        }
    }

    


}
