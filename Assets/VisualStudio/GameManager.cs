using UnityEngine;

public class GameManager : MonoBehaviour
{

    public void AnnouncePlayer()
    {
        Debug.Log("Player is in the game");   //I mean I think we know what it does
    }

    void Start()
    {
        EntityBase[] allEntities = FindObjectsOfType<EntityBase>();

        foreach (EntityBase entity in allEntities)
        {
            entity.TakeDamage(15);  //all objects custom dmg
        }
    }

    void Update()
    {}
}

//warnings beware, I will ghost you harder than the 17 african princes in my email
