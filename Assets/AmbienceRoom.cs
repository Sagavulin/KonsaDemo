using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceRoom : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        AkSoundEngine.PostEvent("Amb_RoomIn", gameObject);
        Debug.Log("TriggerENTER");
    }

    private void OnTriggerExit(Collider other)
    {
        AkSoundEngine.PostEvent("Amb_RoomOut", gameObject);
        Debug.Log("TriggerEXIT");

    }
}
