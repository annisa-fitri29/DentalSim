using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class Kuretase : MonoBehaviour
{
    [SerializeField] GameObject jaringanRusak;
    public Transform curette;
    public Transform newParent;
    void Start()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartFollowCurette());
        grabInteractable.deactivated.AddListener(x => NewParent());
    }

    public void StartFollowCurette()
    {
        jaringanRusak.transform.SetParent(curette);
    }

    public void NewParent()
    {
        jaringanRusak.transform.SetParent(newParent);
    }
}
