using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle"){
            FindObjectOfType<Manager>().EndGame();
        } 

    }
}
