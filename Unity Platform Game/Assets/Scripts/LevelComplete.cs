using UnityEngine;
using UnityEngine.SceneManagement;

//dit is om zodra de END animation is gespeeld een new level te starten
public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel ()
    {
        //SceneManager.LoadScene gaat een bepaalde scene laden
        //SceneManager.GetActiveScene geeft aan met welke scene je wil laden
        //"buildIndex + 1" zal kijken naar welke buildindex numer onze huidige scene heeft en dat plus 1 doen en die scene vervolgens laden
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
