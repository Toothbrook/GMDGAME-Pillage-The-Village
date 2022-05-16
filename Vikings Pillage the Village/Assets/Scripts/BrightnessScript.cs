using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessScript : MonoBehaviour
{
    [SerializeField]
    Slider brightnessSlider;
    public Light sceneLight;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("brightnessValue"))
        {
            Load();
            ChangeBrightness();
        }
        else
        {
            PlayerPrefs.SetFloat("brightnessValue", 1);
            Load();
        }    
    }

    public void ChangeBrightness()
    {
        sceneLight.intensity = brightnessSlider.value;
        Save();
    }

    private void Load()
    {
        brightnessSlider.value = PlayerPrefs.GetFloat("brightnessValue");
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("brightnessValue", brightnessSlider.value);
    }
}
