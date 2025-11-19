using UnityEngine;

public class ToolGameManager : MonoBehaviour
{
    [Header("Alle Tool-Slots hier reinziehen")]
    public ToolSlot[] toolSlots;       

    public AudioSource successSound;

    private bool hasPlayed = false;

    public void CheckAllTools()
    {
        foreach (ToolSlot slot in toolSlots)
        {
            if (!slot.IsCorrect())
            {
                hasPlayed = false;    
                return;
            }
        }

        
        if (!hasPlayed)
        {
            successSound.Play();
            Debug.Log("✓ ALLE WERKZEUGE SIND RICHTIG PLATZIERT! ✓");
            hasPlayed = true;
        }
    }

   
    public void ResetPuzzle()
    {
        hasPlayed = false;
    }
}