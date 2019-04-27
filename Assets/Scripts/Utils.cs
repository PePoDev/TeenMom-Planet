using UnityEngine;
using UnityEngine.SceneManagement;

public class Utils : MonoBehaviour
{
	
	public void LoadNextScene()
	{
		Initiate.Fade(SceneManager.GetActiveScene().buildIndex + 1, Color.black, 1f);
	}

	public void LoadHomepage()
	{
		Initiate.Fade(1, Color.black, 1f);
	}

	public void OpenUrl(string url)
	{
		Application.OpenURL(url);
	}
}
