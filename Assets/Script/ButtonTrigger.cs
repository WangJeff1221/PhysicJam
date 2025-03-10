using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject door;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (door != null)
            {
                door.SetActive(false);
            }
        }
    }
}
