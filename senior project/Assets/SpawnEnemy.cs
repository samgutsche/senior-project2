using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform enemySpawner;

    public GameObject enemyPrefab;

    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        Spawn();

    }
    void Spawn()
    {
        GameObject enemy = Instantiate(enemyPrefab, enemySpawner.position, enemySpawner.rotation);
        Rigidbody2D rb = enemy.GetComponent<Rigidbody2D>();
        
    }
}
