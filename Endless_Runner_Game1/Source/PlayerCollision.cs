//Taylor Martin
//CS-151
//PA 6 Game with Inheritence and Polymorphism 
//5/14/20
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; 
    // Start is called before the first frame update
    
    void OnCollisionEnter(Collision collisionInfo) 
    {
        //Debug.Log(collisionInfo.collider.name); //displays the name of what the player object collided with 
        if(collisionInfo.collider.tag == "Obstacle") //if the player object hits another game object with the "Obstacle" Tag 
        {
            movement.enabled = false; // disable movement and make the player stop 
            FindObjectOfType<GameManager>().EndGame(); 
        }
    }
}
