using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            // Restart the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
