using UnityEngine;
using UnityEngine.UI;

public class PlayerSettings : MonoBehaviour
{

    public static string playerName;

    public InputField nameText; 
    
    public static int totalLives;

    public Dropdown lifeCount;

    public void UpdateName()
    {
        playerName = nameText.text;
        Debug.Log(nameText.text);
    }

    public void UpdateLifeCount()
    {
        switch(lifeCount.value)
        {
            case 0:
                totalLives = 1;
                break;

            case 1:
                totalLives = 2;
                break;

            case 2:
                totalLives = 3;
                break;
        }

        Debug.Log(totalLives);
    }

}
