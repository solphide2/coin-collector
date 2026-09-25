using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    
    public void PlayGame()
    {
        Debug.Log("Play Game");
        //SceneManager.LoadScene("GameScene");
        
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }  
    public void GoToHomePage()
    {
        SceneManager.LoadScene("MainMenu");
    }
} //class  //refresh
