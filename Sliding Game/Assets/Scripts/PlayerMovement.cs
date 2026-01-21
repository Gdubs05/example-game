using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
  
    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Apply a force to the z-axis

        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //Move Player right
        }

        if (Keyboard.current.aKey.isPressed)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0,  0, ForceMode.VelocityChange); //Move Player left
        }

        if (rb.position.y < -1f)
        {
            GameManager gm = Object.FindFirstObjectByType<GameManager>();
            gm.EndGame();
        }
    }
}
