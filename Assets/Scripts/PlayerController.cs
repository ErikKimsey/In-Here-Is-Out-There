using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    


    /**

            
    */
    public float speed;
    public DynamicJoystick joystick;
    public Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * joystick.Vertical + Vector3.right * joystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        Debug.Log(joystick.Vertical);
        transform.Rotate(-joystick.Vertical / 10, 0f, -joystick.Horizontal/10);
    }
}
