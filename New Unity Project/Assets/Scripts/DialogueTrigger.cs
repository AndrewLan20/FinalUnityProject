using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    private bool playerInRange;
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
