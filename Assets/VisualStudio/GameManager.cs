using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void AnnouncePlayer()
    {
        Debug.Log("Your end has entered the server");
    }

    void Start()
    {
        // Damage all
        EntityBase[] allEntities = FindObjectsOfType<EntityBase>();

        foreach (EntityBase entity in allEntities)
        {
            entity.TakeDamage(15);
        }

        GameObject enemy = GameObject.FindWithTag("Enemy");

        if (enemy != null)
        {
            EnemyScript enemyScript = enemy.GetComponent<EnemyScript>();
            if (enemyScript != null)
            {
                enemyScript.ReactToPlayer();  // React to the player
            }
            else
            {
                Debug.LogWarning("EnemyScript component has not been found on the Enemy GameObject");
            }
        }
        else
        {
            Debug.LogWarning("No GameObject with tag 'Enemy' found anywhere in the scene :( ");
        }
    }

    void Update()
    {
        
    }
}


//warnings beware, I will ghost you harder than the 17 african princes in my hotmail
