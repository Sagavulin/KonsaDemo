using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceAreaTrigger : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        AkSoundEngine.PostEvent("Amb_tower", gameObject);
        Debug.Log("TriggerENTER");
    }

    private void OnTriggerExit(Collider other)
    {
        AkSoundEngine.PostEvent("Amb_base", gameObject);
        Debug.Log("TriggerEXIT");

    }
}
