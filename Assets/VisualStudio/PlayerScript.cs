using UnityEngine;
using UnityEngine.Rendering;

public class PlayerScript : EntityBase
{
    public int healthPlayer = 100;    //suprise suprise it's the players health
    private WeaponScript equippedWeapon;

    public float moveSpeed = 5f;   //moving speed
    public GameManager gameManager;

    void Start()
    {
        if (gameManager != null)
        {
            gameManager.AnnouncePlayer();  //Announce the player is in the game
        }

        equippedWeapon = new WeaponScript("Knife", 25);
        Debug.Log("Equipped: " + equippedWeapon.GetWeaponName());  //Equip the sharp one prong fork

        equippedWeapon.SetDamage(35);
        Debug.Log("Updated weapon damage: " + equippedWeapon.GetDamage());

        GameObject enemyByTag = GameObject.FindWithTag("Enemy");
        if (enemyByTag != null)
        {
            Debug.Log("Found enemy by tag: " + enemyByTag.name); 
        }

        AttackEnemy();                  //Find enemy && attack
    }

    void Update()
    {
        HandleMovement();

        if (Input.GetKeyDown(KeyCode.H))           //H for heal, because that's the most creative letter for it
        {
            Heal(10);
        }
    }

    void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0, moveZ);
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);     //movement stuff
    }

    public override void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Player took " + amount + " damage. Health is now " + health);   //Take dmg
        Debug.Log("Player goes ouchies");
    }

    public override void Speak()
    {
        Debug.Log("Player says: Let’s do this biaches!"); //The player has quite the potty mouth
    }

    void AttackEnemy()
    {
        int damageDealt = equippedWeapon.GetDamage();
        Debug.Log("Player attacked enemy and did  " + damageDealt + " points of damage!"); //Damage done
    }
}

//Bless this mess :D

