using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class volume : MonoBehaviour
{
   

    public Slider slider;
    public AudioSource myMusic;

  


   

   
    public void Slider(float volume)
    {
        AudioListener.volume = volume;
    //    volumeText.text = volume.ToString("0.0");
    }
    public void VolumeApply()
    {
        PlayerPrefs.SetFloat("masterVolume", myMusic.volume);
        Debug.Log(PlayerPrefs.GetFloat("masterVolume"));
     //   StartCoroutine(ConfirmationBox());
    }
   
    
}
