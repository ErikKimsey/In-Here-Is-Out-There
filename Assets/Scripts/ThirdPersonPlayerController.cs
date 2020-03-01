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
    public Vector3 anglesToRotate;
    private Vector3 currentDirectionVertex;
    public Rigidbody rb;

    // 
    void Start()
    {
      rb = GetComponent<Rigidbody>();
      currentDirectionVertex = Vector3.forward * Time.deltaTime;
    }

    // 
    void Update()
    {
        HandleZMovement();
        // NewRotate();      
    }

    // 
    void NewRotate(){
        anglesToRotate = new Vector3(0, joystick.Horizontal * rotationSpeed * Time.deltaTime, 0);
        transform.Rotate(anglesToRotate);
    }

    // 
    void HandleZMovement()
    {
        
        inputY = joystick.Vertical * moveSpeed * Time.deltaTime;
        inputX = joystick.Horizontal * moveSpeed * Time.deltaTime;
        if (inputY > 0)
        {
            currentDirectionVertex = Vector3.forward * Time.deltaTime;
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            HandleXMovement();
        }
        if (inputY < 0)
        {
            currentDirectionVertex = -Vector3.forward * Time.deltaTime;
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
            HandleXMovement();
        }
        if(inputY == 0){
          transform.Translate(currentDirectionVertex);
        }
        
    }

    // 
    void HandleXMovement()
    {
        inputX = joystick.Horizontal * moveSpeed * Time.deltaTime;
        if (inputX > 0)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (inputX < 0)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        } 
    }
}
