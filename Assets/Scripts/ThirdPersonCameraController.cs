using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    public float moveSpeed;
    float inputX, inputY;
    public DynamicJoystick joystick;
     public Transform player;
     public Camera playerCamera;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      float X = joystick.Horizontal * moveSpeed;
      float Y = joystick.Vertical * moveSpeed;
      player.Rotate(0, X, 0);
      // if (playerCamera.transform.eulerAngles.x + (-Y) > 80 && playerCamera.transform.eulerAngles.x + (-Y) < 280) { 
      //   playerCamera.transform.RotateAround(player.position, playerCamera.transform.right, Y);
      // } else {
      //      playerCamera.transform.RotateAround(player.position, playerCamera.transform.right, -Y);
      // }
    }

}
