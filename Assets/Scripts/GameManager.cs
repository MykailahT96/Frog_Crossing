using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level_01");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("EndScene");
    }
}
