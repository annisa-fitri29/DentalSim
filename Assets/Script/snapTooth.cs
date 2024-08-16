using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class snapTooth : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tooth;
    public Transform tang;
    public Transform newParent;
    void Start()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartFollowTang());
        grabInteractable.deactivated.AddListener(x => StopFollowTang());
    }

    // Update is called once per frame
    public void StartFollowTang()
    {
        tooth.transform.SetParent(tang);
    }

    public void StopFollowTang()
    {
        tooth.transform.SetParent(newParent);
    }

}
