using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    
    [SerializeField] private float volume;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void OnEnable()
    {
        AudioObserverManager.OnVolumeSliderValueChanged += ProcessVolumeChanged;
    }

    private void OnDisable()
    {
        AudioObserverManager.OnVolumeSliderValueChanged -= ProcessVolumeChanged; 
    }

    private void ProcessVolumeChanged(float newVolume)
    {
        volume = newVolume;
    }
}
