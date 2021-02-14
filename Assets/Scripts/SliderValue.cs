using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    // slider
    public static float gameSpeed;
    public Slider sliderUI;
    private Text textSliderValue;

    void Start()
    {
        textSliderValue = GetComponent<Text>();
        ShowSliderValue();
    }

    public void ShowSliderValue()
    {
        string sliderMessage = "Slider value = " + sliderUI.value;
        gameSpeed = sliderUI.value;
        textSliderValue.text = sliderMessage;
        PlayerPrefs.SetFloat("GameSpeed", sliderUI.value);
    }

    public static float getGameSpeed()
    {
        return gameSpeed;
    }
}
