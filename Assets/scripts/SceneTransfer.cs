using UnityEngine;

public class SceneTransfer : MonoBehaviour
{
    private Animator ButtonAnimator;

    void Start()
    {
        ButtonAnimator = GetComponent<Animator>();
    }

    public void GoToStartMenu()
    {
        ButtonAnimator.SetTrigger("PlayExplode");

        UnityEngine.SceneManagement.SceneManager.LoadScene("StartMenu");
        ButtonAnimator.SetTrigger("PlayIdle");
    }

    public void GoToGame()
    {

        ButtonAnimator.SetTrigger("PlayExplode");
        //UnityEngine.SceneManagement.SceneManager.LoadScene("GamePlay");
        ButtonAnimator.SetTrigger("PlayIdle");
    }
        
}
