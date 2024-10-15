using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticInteractable : MonoBehaviour
{
    [Range(0,1)]
    public float intensity;
    public float duration;

    [Range(0,1)]
    public float stopIntensity;
    public float stopDuration;
    void Start()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        interactable.activated.AddListener(TriggerHaptic);
        interactable.deactivated.AddListener(StopHaptic);
    }

    public void TriggerHaptic(BaseInteractionEventArgs eventArgs)
    {
        if(eventArgs.interactorObject is UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor controllerInteractor)
        {
            TriggerHaptic(controllerInteractor.xrController);
        }
    }

    public void StopHaptic(BaseInteractionEventArgs eventArgs)
    {
        if(eventArgs.interactorObject is UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor controllerInteractor)
        {
            StopHaptic(controllerInteractor.xrController);
        }
    }

    public void TriggerHaptic(XRBaseController controller)
    {
        if(intensity > 0)
            controller.SendHapticImpulse(intensity, duration);

    }

    public void StopHaptic(XRBaseController controller)
    {
        if(intensity <= 0)
            controller.SendHapticImpulse(stopIntensity, stopDuration);

    }
}
