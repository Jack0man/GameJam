using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public string nextSceneName = "_Envuirement_";
    [SerializeField] private int health = 3;
    [SerializeField] private bool isPlayer = false;

private int MAX_HEALTH = 3;
    
    public void Damage(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }

        this.health -= amount;

        if(health <= 0)
        {
            Die();
            if (isPlayer == true)
            {
                LoadNextScene();
            }
        }
    }

    public void SetHealth(int maxHealth, int health)
    {
        this.MAX_HEALTH = maxHealth;
        this.health = health;
    }
    
    private void Die()
    {
        Debug.Log("I am Dead!");
        Destroy(gameObject);
    }
    
    void LoadNextScene()
    {
        // Load the next scene
        SceneManager.LoadScene(nextSceneName);
    }

}
