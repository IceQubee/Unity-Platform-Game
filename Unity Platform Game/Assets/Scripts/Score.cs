using UnityEngine;
using UnityEngine.UI; //add UI library

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    
    void Update()
    {
        //"scoreText.text" for editing the text
        //"player.position.z" referes to player position on Z axis
        //".ToString" i there to convert out Z axis data that is stored in a float to a string (you have to do this when yu want text)
        //"("0")" so it doesnt show decimal numbers in the scoreText (this can be use bc its a string now)
        scoreText.text = player.position.z.ToString("0");
        
    }
}
