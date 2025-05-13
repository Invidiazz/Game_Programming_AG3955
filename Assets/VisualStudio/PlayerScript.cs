using UnityEngine;
using UnityEngine.Rendering;

public class PlayerScript : MonoBehaviour
{
    public int health = 100;
    private WeaponScript equippedWeapon;

    void Start()
    {
        equippedWeapon = new WeaponScript("Sword", 25);

        Debug.Log("Equipped: " + equippedWeapon.GetWeaponName());
        Debug.Log("Damage: " + equippedWeapon.GetDamage());

        equippedWeapon.SetDamage(35);

        Debug.Log("Updated weapon damage: " + equippedWeapon.GetDamage());

        AttackEnemy();
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Player took " + amount + " damage. Health now: " + health);
    }

    void AttackEnemy()
    {
        int damageDealt = equippedWeapon.GetDamage();
        Debug.Log("Player attacked enemy for " + damageDealt + " damage!");
    }
}
 //Bless this mess :D

