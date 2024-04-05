using System.Collections;
using System.Collections.Generic;
using AK.Wwise;
using UnityEngine;

public class AudioOcclusion : MonoBehaviour
{
    [SerializeField] GameObject Audiolistener;
    [SerializeField] bool UseOcclusion = false;
    [SerializeField] string RTPC_LoPass = "RTPC_Occlusion_LoPass";
    [SerializeField] string RTPC_Volume = "RTPC_Occlusion_Volume";
    [SerializeField] float LoPass_Max = 1;
    [SerializeField] float Volume_Max = 1;
    [SerializeField] bool UseDebug = false;
    [SerializeField] string NameOfListener = "Insert Name Here";
    [SerializeField] string IgnoreTypeOccluder = "Insert Name Here";
    private float MaxDistanceOcclusion;
    private Color rayColor = Color.red;
    
    // Start is called before the first frame update
    void Start()
    {
        MaxDistanceOcclusion = GetComponent<SphereCollider>().radius;
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (!UseOcclusion || Audiolistener == null)
        {
            return;
        }

        Vector3 direction = Audiolistener.transform.position - this.transform.position;
        RaycastHit OutInfo;
        bool hit = Physics.Raycast(this.transform.position, direction, out OutInfo);

        if (hit)
        {
            if (UseDebug)
            {
                print(OutInfo.collider.gameObject.name);
                
                // Draw a visual representation of the raycast
                Debug.DrawRay(transform.position, transform.forward * 100, rayColor);
            }

            if (OutInfo.collider.gameObject.name != NameOfListener &&
                OutInfo.collider.gameObject.name != IgnoreTypeOccluder)
            {
                AkSoundEngine.SetRTPCValue(RTPC_LoPass, LoPass_Max, gameObject);
                AkSoundEngine.SetRTPCValue(RTPC_Volume, Volume_Max, gameObject);
            }
            else
            {
                AkSoundEngine.SetRTPCValue(RTPC_LoPass, 0, gameObject);
                AkSoundEngine.SetRTPCValue(RTPC_Volume, 0, gameObject);
            }
        }
    }
}
