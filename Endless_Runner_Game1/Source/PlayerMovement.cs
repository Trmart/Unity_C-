//Taylor Martin
//CS-151
//PA 6 Game with Inheritence and Polymorphism 
//5/14/20
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; //makes a rigidbody object to use game physics 
    public float forwardForce = 2000f; 
    public float sidewaysForce = 500f; 
    // Update is called once per frame
    void FixedUpdate() // when using physics in unit use "fixed update" instead of update. 
    {
        //add a forward foce to the player 
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //adds forward force physics to move player forward through level

        if(Input.GetKey("d")) //if player presses d
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange); //moves player to the right
        }
        if(Input.GetKey("a")) //if player presses a 
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange); //moves player to the left, adds negative sign to make opposite movement 
        }

        if(rb.position.y < -1f) //if player falls off the map 
        {
            FindObjectOfType<GameManager>().EndGame(); //calls the FindObjectOfType memeber function to find the game manager object member function endgame
        }
    }
}
