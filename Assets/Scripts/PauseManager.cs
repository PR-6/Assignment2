using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
	public Text pausedText;
	public GameObject playButton;
	public GameObject restartButton;
	public GameObject menuButton;
	public GameObject Player;

	private void Awake()
    {
		if (PlayerPrefs.GetInt("OverSizeBall", 0) > 0)
		{
			Player.transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
			Player.transform.position = new Vector3(0, 1.5f, 0);
		}
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.P))
		{
			if (Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
			}
			else if (Time.timeScale == 0)
			{
				Debug.Log("high");
				Time.timeScale = 1;
				hidePaused();
			}
		}
		var sphereRend = Player.GetComponent<Renderer>();

		if (PlayerPrefs.GetString("SelectedColor") == "Red")
		{
			sphereRend.material.SetColor("_Color", Color.red);
		}
		else if (PlayerPrefs.GetString("SelectedColor") == "Blue")
		{
			sphereRend.material.SetColor("_Color", Color.blue);
		}
		else if (PlayerPrefs.GetString("SelectedColor") == "Green")
		{
			sphereRend.material.SetColor("_Color", Color.green);
		} 
		else if (PlayerPrefs.GetString("SelectedColor") == "White")
		{
			sphereRend.material.SetColor("_Color", Color.white);
		}

	}

	public void Reload()
	{
		pauseControl();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void mainMenu()
    {
		pauseControl();
		SceneManager.LoadScene(0);
	}

	public void pauseControl()
	{
		if (Time.timeScale == 1)
		{
			Time.timeScale = 0;
			showPaused();
		}
		else if (Time.timeScale == 0)
		{
			Time.timeScale = 1;
			hidePaused();
		}
	}

	public void showPaused()
	{
		pausedText.gameObject.SetActive(true);
		playButton.gameObject.SetActive(true);
		restartButton.gameObject.SetActive(true);
		menuButton.gameObject.SetActive(true);
	}

	public void hidePaused()
	{
		pausedText.gameObject.SetActive(false);
		playButton.gameObject.SetActive(false);
		restartButton.gameObject.SetActive(false);
		menuButton.gameObject.SetActive(false);

	}
}
