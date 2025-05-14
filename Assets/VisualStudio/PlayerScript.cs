using UnityEngine;
using UnityEngine.Rendering;

public class PlayerScript : MonoBehaviour
{
    public int health = 100;    //suprise suprise it's the players health
    private WeaponScript equippedWeapon;

    public float moveSpeed = 5f;   //moving speed
    public GameManager gameManager; 

    void Start()
    {
        if (gameManager != null)
        {
            gameManager.AnnouncePlayer();  //Announce the player is in the game
        }

        equippedWeapon = new WeaponScript("Sword", 25);
        Debug.Log("Equipped: " + equippedWeapon.GetWeaponName());  //Equip the weapon

        equippedWeapon.SetDamage(35);
        Debug.Log("Updated weapon damage: " + equippedWeapon.GetDamage());

    

    
        GameObject enemyByTag = GameObject.FindWithTag("Enemy");
        if (enemyByTag != null)
        {
            Debug.Log("Found enemy by tag: " + enemyByTag.name);
        }

        
        AttackEnemy();                  //Find enemy & attack
    }

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical"); 

        Vector3 movement = new Vector3(moveX, 0, moveZ);
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);     //movement stuff
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Player took " + amount + " damage. Health now: " + health);   //Take dmg
    }

    void AttackEnemy()
    {
        int damageDealt = equippedWeapon.GetDamage();
        Debug.Log("Player attacked enemy for " + damageDealt + " damage!");
    }
}
//Bless this mess :D

