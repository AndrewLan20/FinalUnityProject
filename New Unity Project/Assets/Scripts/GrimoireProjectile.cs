using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrimoireProjectile : MonoBehaviour
{
    private GameObject Enemy;
    private EnemyBehaviour enemyStats;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.Find("EnemyPrefab");
        enemyStats = Enemy.gameObject.GetComponent<EnemyBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit " + other.name + "!");
        Destroy(gameObject);
        if (other.gameObject.CompareTag("NPC"))
        {
            Debug.Log("WHAT'S WRONG WITH YOU");
        }

        if (other.gameObject.CompareTag("Enemy NPC"))
        {
            enemyStats.enemyHealth -=  5.0f;
            Debug.Log(" current enemy health: " + enemyStats.enemyHealth);
            
        }

    }

}
