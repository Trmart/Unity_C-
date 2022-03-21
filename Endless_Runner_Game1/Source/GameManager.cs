//Taylor Martin
//CS-151
//PA 6 Game with Inheritence and Polymorphism 
//5/14/20
using UnityEngine; 
using UnityEngine.SceneManagement; 


public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false; 
    public float restartDelay = 1f; 
    // Update is called once per frame
    public GameObject completeLevelUI; 
    
    public void CompleteLevel()
    {
        //Debug.Log("LEVEL COMPLETE!"); 
        completeLevelUI.SetActive(true); //we set SetActive to true in order to enable it in our game 
    }
    
    public void EndGame() //creates an endgame function 
    {   if(gameHasEnded == false)
        {
            gameHasEnded = true; 
            Debug.Log("GAME OVER!"); //shoots a message to the console for debug 
            Invoke("Restart",restartDelay); //calls a MonoBehaviour memeber function invoke 
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //loads the current level that the player was on when hit game over
    }
}
