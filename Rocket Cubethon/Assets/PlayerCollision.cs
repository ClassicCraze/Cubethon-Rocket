using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("Player has hit an obstacle.");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}