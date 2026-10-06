using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        Debug.Log("Enemy took damage! Current health: " + health);

        if (health <= 0)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
