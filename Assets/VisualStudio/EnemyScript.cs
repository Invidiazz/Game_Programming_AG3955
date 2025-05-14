using UnityEngine;

public class EnemyScript : EntityBase
{
    public int damage = 10;
    public PlayerScript player;

    private bool hasSpoken = false;

    void Start()
    {
        if (player != null)
        {
            player.TakeDamage(damage);     //cause player dmg
        }
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        Debug.Log("well ouchies, that wasn't very nice now was it?"); //take damage response... and no it wasnt't that nice
    }

    public override void Speak()
    {
        if (!hasSpoken)
        {
            base.Speak();
            Debug.Log("Enemy: I shall steal ya mom"); //it can speak, should add that it only does it once in start of the encounter. No need to steal mom every second

            hasSpoken = true;
        }
    } //now mom is only stolen once, yey!

    public void ReactToPlayer()
    {
        Debug.Log("Thy foe has spotted ya");
        Speak();
    }
}

