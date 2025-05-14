using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
    public int health;

    public abstract void TakeDamage(int amount);

    public void Heal(int amount)
    {
        health += amount;
        Debug.Log($"{gameObject.name} healed by {amount}. Health is now {health}.");
    }
}
