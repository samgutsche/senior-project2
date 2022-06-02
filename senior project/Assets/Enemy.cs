using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;

    public void TakeDamage(int damage){
        health -= damage;
        Destroy(gameObject);
        if (health <= 0) {
            Destroy(gameObject);
        }

    }
    void Die() {
        Destroy(gameObject);
    }
}
