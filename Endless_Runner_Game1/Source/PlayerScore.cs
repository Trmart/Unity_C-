//Taylor Martin
//CS-151
//PA 6 Game with Inheritence and Polymorphism 
//5/14/20
using UnityEngine;
using UnityEngine.UI; 
public class PlayerScore : MonoBehaviour
{
    public Transform player; 
    public Text scoreText; 
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "High Score:" + player.position.z.ToString("0");  //converts the play position on the z axis to a string and displays it as a score
    }
}
