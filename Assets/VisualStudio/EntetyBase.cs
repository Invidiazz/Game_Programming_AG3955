using UnityEngine;

public class EntityBase : MonoBehaviour
{
    public int health = 100;

    public virtual void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log($"{gameObject.name} took {amount} damage. Health is now {health}");
    }

    public void Heal(int amount)
    {
        health += amount;
        Debug.Log($"{gameObject.name} healed by {amount}. Health: {health}");
    }

    public virtual void Speak()
    {
        Debug.Log($"{gameObject.name} says: YOOOOOOOOOOOOOOOOOOOOOOOOOO, sick meininki "); // it can be a annoying kid now :D
    }
}


//shoooould give all charachters a health of 100, take damage and heal.



//Does it work? in theory yes, techincally kinda. In unity? hell naw