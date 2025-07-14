using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    public TextMeshProUGUI winnerText;
    public Button replayButton;

    void Start()
    {
        if (winnerText == null)
        {
            Debug.LogError("WinnerText is NULL! Please drag it in the Inspector.");
            return;
        }

        if (replayButton == null)
        {
            Debug.LogError("ReplayButton is NULL! Please assign it in the Inspector.");
            return;
        }

        winnerText.gameObject.SetActive(false);
        replayButton.gameObject.SetActive(false);

        replayButton.onClick.AddListener(RestartGame);
    }

    public void ShowWinner(string message)
    {
        winnerText.text = message;
        winnerText.gameObject.SetActive(true);
        replayButton.gameObject.SetActive(true);
    }

    void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
