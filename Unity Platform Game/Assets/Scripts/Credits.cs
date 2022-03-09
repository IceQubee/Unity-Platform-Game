using UnityEngine;

public class Credits : MonoBehaviour
{
    //make sure this is public so the function is found when yu add a on click event
    public void Quit ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
