using UnityEngine;
using UnityEngine.SceneManagement;

public class Utilities : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Stopped");
    }
    
    public void QuittoMenu()
    {
        SceneManager.LoadScene("Start");
    }
}
