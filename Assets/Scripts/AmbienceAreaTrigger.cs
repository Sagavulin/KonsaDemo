using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceAreaTrigger : MonoBehaviour
{
    [SerializeField] private bool TriggerAtStart = false;
    [SerializeField] private string SoundEventEnter;
    [SerializeField] private string SoundEventExit;
    
    private void Start()
    {
        if (TriggerAtStart)
        {
            AkSoundEngine.PostEvent(SoundEventEnter, gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        AkSoundEngine.PostEvent(SoundEventEnter, gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        AkSoundEngine.PostEvent(SoundEventExit, gameObject);
    }
}
