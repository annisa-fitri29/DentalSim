using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class UpfollowBlood : MonoBehaviour
{
    public GameObject up;
    public GameObject bloodWater;
    public float speed = 0.01f;

    void Start()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => GoUp());
    }
    public void GoUp()
    {
        bloodWater.transform.position = Vector3.MoveTowards(bloodWater.transform.position, up.transform.position, speed);
    }
}
