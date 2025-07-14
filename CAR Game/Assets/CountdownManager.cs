using System.Collections;
using UnityEngine;
using TMPro;

public class CountdownManager : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    public GameObject playerCar;
    public GameObject Other_cars;

    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        countdownText.gameObject.SetActive(true);

        countdownText.text = "3";
        yield return new WaitForSeconds(1f);

        countdownText.text = "2";
        yield return new WaitForSeconds(1f);

        countdownText.text = "1";
        yield return new WaitForSeconds(1f);

        countdownText.text = "GO!";
        yield return new WaitForSeconds(1f);

        countdownText.gameObject.SetActive(false);

        if (playerCar != null)
            playerCar.GetComponent<car_mov>().enabled = true;

        if (Other_cars != null)
        {
            auto_run[] aiScripts = Other_cars.GetComponentsInChildren<auto_run>();

            foreach (auto_run ai in aiScripts)
            {
                ai.enabled = true;
            }

            if (aiScripts.Length == 0)
            {
                Debug.LogWarning("No auto_run scripts found under Other_car! 🚨");
            }
        }
        else
        {
            Debug.LogError("Other_car is not assigned in CountdownManager! 🚨");
        }
    }
}
