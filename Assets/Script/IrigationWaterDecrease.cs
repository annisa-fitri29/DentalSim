using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class IrigationDecreaseWater : MonoBehaviour
{
    public AudioSource suction;
    public AudioClip clip;
    [SerializeField] GameObject water;
    [SerializeField] Vector3 startPosition;
    [SerializeField] Vector3 endPosition;
    [SerializeField] float speed = 1.0f;
    void Start()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => DecreaseWater());
        grabInteractable.deactivated.AddListener(x => StopAudio());
    }

    // Update is called once per frame
    void DecreaseWater()
    {
        //water.SetActive(true);
        suction.PlayOneShot(clip);
        water.transform.position = Vector3.Lerp(startPosition, endPosition, speed * Time.deltaTime);
    }

    public void StopAudio()
    {
        suction.Stop();
    }
}
