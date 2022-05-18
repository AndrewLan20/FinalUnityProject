using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private float enemySpeed;
    public float enemyHealth;
    private bool isAgro;
    public bool swayHoriz;
    public bool swayVert;
    public bool rotateAttack;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }

        if (isAgro)
        {


            if (swayHoriz)
            { 
                
            }

            if (swayVert)
            { 
                
            }

            if (rotateAttack)
            { 
                
            }
        }

    }
}
