using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    public int health = 3;
    private int score = 0;

    void Awake()
    {
        TextMeshProUGUI ScoreText = GameObject.FindWithTag("Text").GetComponent<TextMeshProUGUI>();
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        Debug.Log("Enemy took damage! Current health: " + health);

        if (health <= 0)
        {  
            score++;
            scoreText.SetText("Enemies Slain: " + score);
            Destroy(transform.parent.gameObject);
        }
    }
}