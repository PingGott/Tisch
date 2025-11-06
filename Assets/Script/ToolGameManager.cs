using UnityEngine;

public class ToolGameManager : MonoBehaviour
{
    public Collision[] toolTriggers; 
    public AudioSource successSound;

    private bool hasPlayed = false;

    public void CheckAllTriggers()
    {
        foreach (Collision trigger in toolTriggers)
        {
            if (!trigger.IsCorrect())
            {
                hasPlayed = false;
                return;
            }
        }

        if (!hasPlayed)
        {
            successSound.Play();
            Debug.Log(" Alle Werkzeuge liegen richtig!");
            hasPlayed = true;
        }
    }
}
