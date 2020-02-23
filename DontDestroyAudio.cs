using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    volume v;
    void Awake()
    {
        
        DontDestroyOnLoad(transform.gameObject);
    }
}
