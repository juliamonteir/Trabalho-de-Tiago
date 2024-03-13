using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlerSlider : MonoBehaviour
{
    [SerializeField] private Slider volumeSlide;
    
    private void Start()
    {
        volumeSlide.onValueChanged.AddListener(ChecarVolume);
    }
    
    private void ChecarVolume(float slidervalue)
    {
        AudioObserverManager.ChangeVolumeSliderValue(slidervalue);
    }
}
