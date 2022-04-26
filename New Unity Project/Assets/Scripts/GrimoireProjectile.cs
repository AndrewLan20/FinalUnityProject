using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrimoireProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
    }

}
