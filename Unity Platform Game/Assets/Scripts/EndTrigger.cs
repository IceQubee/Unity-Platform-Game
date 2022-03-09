using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
    //OnTriggerEnter is voor het triggeren van events zoals het einde van een level
    //je moet de box "is trigger" aanvinken in de box colider om het te laten werken
    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
