//Taylor Martin
//CS-151
//PA 6 Game with Inheritence and Polymorphism 
//5/14/20
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager; 
    // Update is called once per frame
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel(); //when the trigger game object is collided with or hit it triggers an end game function 
    }
}
