using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class IrigationDecreaseWater : MonoBehaviour
{
    public AudioSource suction;
    public AudioClip clip;

    // public GameObject bloodWater;
    // public Transform suctionObj;
    // public Transform newParent;
    void Start()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => DecreaseWater());
        grabInteractable.deactivated.AddListener(x => StopAudio());
    }

    // Update is called once per frame
    void DecreaseWater()
    {
        suction.PlayOneShot(clip);
        //bloodWater.transform.SetParent(suctionObj);
        
    }

    public void StopAudio()
    {
        suction.Stop();
        //bloodWater.transform.SetParent(newParent);

    }
}
