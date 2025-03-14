using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
public class EnemyHealth : MonoBehaviour
{

    private int maxHealth = 100;
    private int currentHealth;
    public Slider healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;

    }

    public void TakeDamage(int damage)
    {

        currentHealth -= damage;
        healthBar.value = currentHealth;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {

        if(GameManager.Instance !=null){

            GameManager.Instance.IncrementScore();
            GameManager.Instance.LoadNextScene();
        }
    }
}
