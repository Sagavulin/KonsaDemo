using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepDetector : MonoBehaviour
{
    public LayerMask materialLayer;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, materialLayer))
        {
            string materialTag = hit.collider.tag;

            switch (materialTag)
            {
                case "Dirt":
                    AkSoundEngine.SetSwitch("Surface_Type", "Dirt", gameObject);
                    Debug.Log("DIRT");
                    break;
                case "Stone":
                    AkSoundEngine.SetSwitch("Surface_Type", "Stone", gameObject);
                    Debug.Log("STONE");
                    break;
                case "Wood":
                    AkSoundEngine.SetSwitch("Surface_Type", "Wood", gameObject);
                    Debug.Log("WOOD");
                    break;
            }
        }
    }
}
