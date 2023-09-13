using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
	//This function gets connected to our playbutton
	public void PlayGame()
	{
		SceneManager.LoadScene("movement");
	}

	//this function gets connected to our quit button
	public void QuitGame()
	{
		//If we are in the unity editor run this code
#if UNITY_EDITOR
		//We cant quit the application in the editor
		//but we can stop the game from running.
		UnityEditor.EditorApplication.isPlaying = false;
#endif

		//else/then run this code
		Application.Quit();
	}
}
