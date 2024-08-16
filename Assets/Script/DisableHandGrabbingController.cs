using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableHandGrabbingController : MonoBehaviour
{
    public GameObject leftControllerModel;
    public GameObject rightControllerModel;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(HideControllerModel);
        grabInteractable.selectExited.AddListener(ShowControllerModel);

    }

    void HideControllerModel(SelectEnterEventArgs args)
    {
        if(args.interactorObject.transform.tag == "Left Hand")
        {
            leftControllerModel.SetActive(false);
        }
        else if(args.interactorObject.transform.tag == "Right Hand")
        {
            rightControllerModel.SetActive(false);
        }
    }

    void ShowControllerModel(SelectExitEventArgs args)
    {
        if(args.interactorObject.transform.tag == "Left Hand")
        {
            leftControllerModel.SetActive(true);
        }
        else if(args.interactorObject.transform.tag == "Right Hand")
        {
            rightControllerModel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
