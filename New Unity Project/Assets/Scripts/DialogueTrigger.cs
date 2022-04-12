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

    [Header("Ink JSON")]
    [SerializeField] private TextAsset InkJSON;
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
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log(InkJSON.text);
            }
        }
        else
        {
            interact.SetActive(false);
            Debug.Log("You're far from Steven");
        }
    }

   
    
}
