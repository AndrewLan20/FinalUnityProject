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

    Vector3 jumpVelocity;
    public float jumpSpeed = 12.0f;
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

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && jumpVelocity.y < 0)
        {
            jumpVelocity.y = -2f;
        }

        // controls camera input
        float MouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        mainCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * MouseX);
        //----------------------------------------------------------------------------
        //yayS
        // controls player movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        charMove = transform.right * horizontalInput + transform.forward * verticalInput;
        speed = 12f;
        controller.Move(charMove * jumpSpeed * Time.deltaTime);

        jumpVelocity.y += gravity * Time.deltaTime;
        controller.Move(jumpVelocity * Time.deltaTime);
    }
}
