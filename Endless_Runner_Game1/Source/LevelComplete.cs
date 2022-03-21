//Taylor Martin
//CS-151
//PA 6 Game with Inheritence and Polymorphism 
//5/14/20
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LevelComplete : MonoBehaviour
{
   public void LoadNextLevel()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loads the next scene in our game, starting with scene 0 for the menu and then loading each additional scene 
   }
}
