using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeScript : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    public AudioMixer audioMixer;

    void Start()
    {
        if (PlayerPrefs.HasKey("volumeValue"))
        {
            Load();
            //SetVolume();
        }
        else
        {
            PlayerPrefs.SetFloat("volumeValue", 0);
            Load();
        }
    }

    public void SetVolume()
    {
        audioMixer.SetFloat("Volume", volumeSlider.value);
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volumeValue");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("volumeValue", volumeSlider.value);
    }
}
