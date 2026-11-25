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
        Debug.Log("Stopped the application");
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene("Start");
    }
}
