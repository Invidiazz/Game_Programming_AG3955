using UnityEngine;

public class WeaponScript
{
    private string weaponName;
    private int damage;

    public WeaponScript(string name, int dmg)
    {
        weaponName = name;
        damage = dmg;
    }

    public int GetDamage()
    {
        return damage;
    }

    public string GetWeaponName()
    {
        return weaponName;
    }

    public void SetDamage(int newDamage)
    {
        if (newDamage > 0)
        {
            damage = newDamage;
        }
    }
}