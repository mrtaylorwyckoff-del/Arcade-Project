using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Sword : MonoBehaviour
{
    private int score = 0;
    public int damage = 1;
    [SerializeField] TMP_Text scoreText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyHealth enemy = collision.gameObject.GetComponent<EnemyHealth>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);

            score++;

            scoreText.SetText("Enemies Slain: " + score);
        }
    }
}
