using UnityEngine;

public class PlayerScript : MonoBehaviour
{
   public int health = 100;

    public void TakeDamage(int amount)
    {
        health-= amount;
        Debug.Log ("Player took " + amount + "damage.Health now: " + health);
    }
}
