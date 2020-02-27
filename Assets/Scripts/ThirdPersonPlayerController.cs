using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonPlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;
    private float inputX, inputY;
    public DynamicJoystick joystick;
    public Transform rotationTarget;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HandleZMovement();
        
    }

    void HandleZMovement()
    {
        
        inputY = joystick.Vertical * moveSpeed * Time.deltaTime;
        inputX = joystick.Horizontal * moveSpeed * Time.deltaTime;
        if (inputY > 0)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            HandleXMovement();
            //transform.Rotate(Vector3.up, inputY * -rotationSpeed * Time.deltaTime);
        }
        if (inputY < 0)
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
            HandleXMovement();
            //transform.Rotate(Vector3.up, inputY * rotationSpeed * Time.deltaTime);
            //HandleRotation(inputX);
        }
    }

    void HandleXMovement()
    {
        Debug.Log(joystick.Horizontal);
        inputX = joystick.Horizontal * moveSpeed * Time.deltaTime;
        if (inputX > 0)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            //transform.Rotate(Vector3.up, inputY * -rotationSpeed * Time.deltaTime);
        }
        if (inputX < 0)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            //transform.Rotate(Vector3.up, inputY * rotationSpeed * Time.deltaTime);
        }
        
    }

    void HandleRotation(float xRot)
    {
        transform.Rotate(Vector3.up, xRot * rotationSpeed * Time.deltaTime);
    }

}
