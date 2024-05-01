using UnityEngine.SceneManagement;
using UnityEngine;

public class GoHomeToTitle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {		
			Cursor.lockState = CursorLockMode.None;
			SceneManager.LoadScene("Title");
			Cursor.lockState = CursorLockMode.None;
        }
    }
}
