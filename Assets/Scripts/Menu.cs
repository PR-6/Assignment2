using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    List<string> colors = new List<string>() { "White", "Red", "Blue", "Green" };
    private static bool overSizedBallValue;
    public Dropdown dropdown;

    private void Awake()
    {
        PlayerPrefs.DeleteAll();
        PopulateList();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ToggleChanged(bool newValue)
    {
        PlayerPrefs.SetInt("OverSizeBall", 1);
    }

    public void DropDownIndexChanged(int index)
    {
        Debug.Log(colors[index]);
        PlayerPrefs.SetString("SelectedColor", colors[index]);
        Debug.Log(colors[index]);
    }

    void PopulateList()
    {
        dropdown.AddOptions(colors);
    }

}
