using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    private bool playerInRange;
    private float minDistance;
    // Start is called before the first frame update
    public GameObject player;
    [Header("Interact")]
    [SerializeField] private GameObject interact;
    void Start()
    {
        playerInRange = false;
        interact.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        minDistance = 7.5f;

        if (Vector3.Distance(transform.position, player.transform.position) < minDistance)
        {
            playerInRange = true;
        }
        else {
            playerInRange = false;
        }

        if (playerInRange)
        {
            interact.SetActive(true);
            Debug.Log("You're close to Steven");
        }
        else
        {
            interact.SetActive(false);
            Debug.Log("You're far from Steven");
        }
    }

   
    
}
