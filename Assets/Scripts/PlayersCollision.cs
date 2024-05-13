using UnityEngine;

public class PlayersCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obsticle")
        {
            movement.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();

            //Debug.Log("We hit an Obsticle");
        }
    }
}
