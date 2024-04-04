using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceTrigger : MonoBehaviour
{
    private void Start()
    {
        AkSoundEngine.PostEvent("Amb_base", gameObject);
    }
}
