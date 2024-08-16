using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class IrigationIncreaseWater : MonoBehaviour
{
    [SerializeField] GameObject water;
    [SerializeField] Vector3 startPosition;
    [SerializeField] Vector3 endPosition;
    [SerializeField] float speed = 1.0f;
    void Start()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => IncreaseWater());

    }

    // Update is called once per frame
    void IncreaseWater()
    {
        water.transform.position = Vector3.Lerp(startPosition, endPosition, speed * Time.deltaTime);
    }
    
}
