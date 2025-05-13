using UnityEngine;

public class WeaponScript
{
    public string weaponName;
    public int damage;

    public WeaponScript ( string name, int dmg )
    {
        weaponName = name;
        damage = dmg;
    }

    public void PrintInfo()
    {
        UnityEngine.Debug.Log("Weapon: " + weaponName + ", Damage: " + damage);
    }

}
