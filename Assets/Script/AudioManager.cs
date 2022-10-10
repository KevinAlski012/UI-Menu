using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource lagu;
    public AudioMixer mixer;
    public Slider volumeSlider;
    public void ToggleMusic()
    {
        if (!lagu.isPlaying) lagu.Play();
        else lagu.Stop();
    }

    private void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
    }
    public void SetMusicVolume(float sliderValue)
    {
        mixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }
}
