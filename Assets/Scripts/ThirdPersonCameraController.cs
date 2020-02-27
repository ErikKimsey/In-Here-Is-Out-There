using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    public float rotationSpeed;
    public float moveSpeed;
    float inputX, inputY;
    public DynamicJoystick joystick;
    public Transform rotationTarget;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //HandleJoyStickControl();
    }

    void HandleJoyStickControl()
    {
        inputX = joystick.Horizontal * rotationSpeed * Time.deltaTime;
        inputY = joystick.Vertical * moveSpeed * Time.deltaTime;
        inputY = Mathf.Clamp(inputY, -90, 90);

        Debug.Log("inputX");    
        Debug.Log(inputX);

        transform.RotateAround(rotationTarget.position, Vector3.up, Time.deltaTime);
        if(inputX > 0)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            transform.Rotate(Vector3.up, inputY * -rotationSpeed * Time.deltaTime);
        }
        if(inputX < 0)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            transform.Rotate(Vector3.up, inputY * rotationSpeed * Time.deltaTime);
        }
        //Debug.Log(inputY);
        //Vector3 playerMovement = new Vector3(joystick.Horizontal, 0f, joystick.Vertical) * rotationSpeed;
        //transform.Translate(playerMovement, Space.Self);
    }
}
