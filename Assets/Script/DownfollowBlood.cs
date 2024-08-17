using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownfollowBlood : MonoBehaviour
{
    public GameObject down;
    public GameObject bloodWater;
    public float speed = 0.01f;

    void Start()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => GoDown());
    }
    public void GoDown()
    {
        bloodWater.transform.position = Vector3.MoveTowards(bloodWater.transform.position, down.transform.position, speed);
    }
}
