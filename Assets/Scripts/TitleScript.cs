using UnityEngine.SceneManagement;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
	public GameObject loading_text;
	public GameObject menu_frame;
	
	private void Start()
	{
		
		menu_frame.SetActive(true);
		loading_text.SetActive(false);
	}
	
	public void ClickStart()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Debug.Log("Loading game");
		menu_frame.SetActive(false);
		loading_text.SetActive(true);
		SceneManager.LoadScene("Game");
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	public void ClickClose()
	{
		Application.Quit();
	}
}
