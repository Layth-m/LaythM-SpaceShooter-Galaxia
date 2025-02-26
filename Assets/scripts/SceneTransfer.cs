using UnityEngine;

public class SceneTransfer : MonoBehaviour
{
   


    public void GoToStartMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("StartMenu");
    }

    public void GoToGame()
    {


        UnityEngine.SceneManagement.SceneManager.LoadScene("GamePlay");


    }
        
}
