using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FPController : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject camHolder;
    public float speed = 4;
    public float sprintSpeed = 7;
    public float sensitivity = 0.1f;
    public float maxForce = 1;
    public float jumpForce = 3;

    private Vector2 look;
    private float lookRotation;

    public bool isGrounded = false;
    public bool isSprinting = false;

    public void OnMove(InputAction.CallbackContext context)
    {
        //move = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        look = context.ReadValue<Vector2>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void LateUpdate()
    {
        Look();
    }

    private void Look()
    {
        //left right
        transform.Rotate(Vector3.up * look.x * sensitivity);

        //up down
        lookRotation += (-look.y * sensitivity);
        lookRotation = Mathf.Clamp(lookRotation, -45, 45);
        camHolder.transform.eulerAngles = new Vector3(lookRotation, camHolder.transform.eulerAngles.y, camHolder.transform.eulerAngles.z);
    }
}
