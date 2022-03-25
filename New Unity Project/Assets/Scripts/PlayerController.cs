using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject mainCamera;
    public float mouseSensitivity = 100.0f;
    float xRotation = 0f;
    float horizontalInput;
    float verticalInput;
    Vector3 charMove;
    public CharacterController controller;
    public float speed;
    public float airSpeed = 12f;
    public float jumpheight = 3f;
    Vector3 jumpVelocity;
    
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = .4f;
    public LayerMask groundMask;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
    }

    // Update is called once per frame
    void Update()
    {


        // controls camera input
        float MouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        mainCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * MouseX);
        //----------------------------------------------------------------------------
        
        // controls player movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        charMove = transform.right * horizontalInput + transform.forward * verticalInput;
        speed = 12f;
        controller.Move(charMove * speed* Time.deltaTime);

        
        controller.Move(jumpVelocity * Time.deltaTime);

        //controls player physics

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (Input.GetKeyDown("space") && isGrounded)
        {
            jumpVelocity.y = Mathf.Sqrt(jumpheight * -2f * gravity);
        }

        jumpVelocity.y += gravity * Time.deltaTime;

        if (isGrounded && jumpVelocity.y < 0)
        {
            jumpVelocity.y = -2f;
        }

    }
}
