using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Win");
            SceneManager.LoadScene("Level3");
        }
    }
}
