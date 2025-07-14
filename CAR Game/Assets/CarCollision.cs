using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyCar"))
        {
            Debug.Log("Game Over! You hit a car!");
            SceneManager.LoadScene("SampleScene");
        }
    }
}       
