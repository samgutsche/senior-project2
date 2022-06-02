using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
       
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {

            currentHealth -= 1;
            healthBar.SetHealth(currentHealth);
        }
        
    }
    
    
}
