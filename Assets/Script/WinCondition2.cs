using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WinCondition2 : MonoBehaviour
{
    public TextMeshProUGUI winText;
    public Button restartButton;    

    void Start()
    {
        winText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);

        restartButton.onClick.AddListener(RestartLevel);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            winText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);

            Time.timeScale = 0f;
        }
    }

    void RestartLevel()
    {
        Time.timeScale = 1f;

        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
