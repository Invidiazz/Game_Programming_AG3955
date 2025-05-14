using UnityEngine;

public class TurretScript : MonoBehaviour, IDamageable
{
    public int integrity = 50;

    public void TakeDamage(int amount)
    {
        integrity -= amount;
        Debug.Log("Turret was damaged! Integrity: " + integrity);
    }
}
