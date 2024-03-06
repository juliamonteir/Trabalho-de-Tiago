using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlerSlider : MonoBehaviour
{
    public Slider volumeSlide;
    
    private void Start()
    {
        if (AudioManager.Instance == null)
        {
            return;
        }

        volumeSlide.value = AudioManager.Instance.volume;

        volumeSlide.onValueChanged.AddListener(ChecarVolume);
    }
    
    private void ChecarVolume(float value)
    {
        AudioManager.Instance.volume = value;
    }
}
