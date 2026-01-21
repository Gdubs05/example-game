using UnityEngine;
public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            GameManager gm = Object.FindFirstObjectByType<GameManager>();
            gm.EndGame();
        }
    }

}
