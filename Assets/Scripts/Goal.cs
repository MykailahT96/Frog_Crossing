using UnityEngine;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{

    void OnTriggerEnter2D()
    {
        Debug.Log("Level Complete");
        Score.CurrentScore += 100;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
