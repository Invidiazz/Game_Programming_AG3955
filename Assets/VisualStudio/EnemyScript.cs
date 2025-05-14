using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int damage = 10;
    public PlayerScript player;

    void Start()
    {
        if (player != null)
        {
            player.TakeDamage(damage);     //cause player damage
        }
    }
}
