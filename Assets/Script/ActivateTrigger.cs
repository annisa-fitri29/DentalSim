using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;



public class ActivateTrigger : MonoBehaviour
{
    public ParticleSystem water;
    [SerializeField] GameObject bloodWater;
    [SerializeField] Vector3 startPosition;
    [SerializeField] Vector3 endPosition;
    [SerializeField] float speed = 10.0f;
    //public ParticleSystem blood;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartIrigation());
        grabInteractable.deactivated.AddListener(x => StopIrigation());
    }

    // Update is called once per frame
    public void StartIrigation()
    {
        bloodWater.SetActive(true);
        bloodWater.transform.position = Vector3.Lerp(startPosition, endPosition, speed * Time.deltaTime);
        water.Play();
        
    }

    public void StopIrigation()
    {
        water.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
    }
}
