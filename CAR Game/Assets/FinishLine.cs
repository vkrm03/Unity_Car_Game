using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameUIManager uiManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            uiManager.ShowWinner("Player Wins!");
            Time.timeScale = 0;
        }
        else if (other.gameObject.CompareTag("AI"))
        {
            uiManager.ShowWinner("AI Wins!");
            Time.timeScale = 0;
        }
    }
}
