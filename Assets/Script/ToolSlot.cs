using UnityEngine;

public class ToolSlot : MonoBehaviour
{
    [Tooltip("Tag des Werkzeugs, das hier reinpasst")]
    public string correctToolTag = "Hammer";

    [Tooltip("Referenz zum GameManager")]
    public ToolGameManager gameManager;

    private bool isCorrect = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(correctToolTag))
        {
            isCorrect = true;
            Debug.Log($"{name}: {other.name} ist richtig platziert!");
            gameManager.CheckAllTools();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(correctToolTag))
        {
            isCorrect = false;
            Debug.Log($"{name}: {other.name} wurde entfernt!");
            gameManager.CheckAllTools();
        }
    }

    public bool IsCorrect()
    {
        return isCorrect;
    }
}