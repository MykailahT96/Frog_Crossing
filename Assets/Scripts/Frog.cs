using UnityEngine;
using UnityEngine.SceneManagement;


public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
            rb.MovePosition(rb.position + Vector2.right);
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left);
        else if(Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        else if(Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);
    }

    void OnTriggerEnter2D (Collider2D col, int PlayerSettings.totalLives)
    {
        if(col.tag == "Car")
        {
            totalLives = totalLives - 1;

            if(totalLives == 0)
            {
                Debug.Log("We Lost");
                Score.CurrentScore = 0;
                SceneManager.LoadScene("EndScene");
            }
            else
            {
                Debug.Log("Lost 1 Life");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                
            }
        }
    }
}
