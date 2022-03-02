using UnityEngine;
using UnityEngine.SceneManagement; //add so i can change/reload a scene

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            //invoke takes 2 parameters (function and a delay)
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        //SceneManager.LoadScene("Level01") //this loads the scene you specifie
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
