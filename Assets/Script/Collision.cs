using UnityEngine;

public class Collision : MonoBehaviour
{
    [Tooltip("Tag des richtigen Werkzeugs für diese Fläche")]
    public string correctToolTag;

    [Tooltip("Referenz auf den GameManager")]
    public ToolGameManager gameManager;

    private bool isCorrect = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(correctToolTag))
        {
            isCorrect = true;
            Debug.Log($"{name}: {other.tag} ist korrekt!");
            gameManager.CheckAllTriggers();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(correctToolTag))
        {
            isCorrect = false;
            Debug.Log($"{name}: {other.tag} wurde entfernt!");
            gameManager.CheckAllTriggers();
        }
    }

    public bool IsCorrect()
    {
        return isCorrect;
    }
}
