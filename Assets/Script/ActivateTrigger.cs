using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;



public class ActivateTrigger : MonoBehaviour
{
    public ParticleSystem water;
    public ParticleSystem blood;
    //public GameObject bloodWater;
    public Transform irigasiObj;
    public Transform newParent;
    public AudioSource irigasi;
    public AudioClip clip;

    public CheckProcedure checkProcedure;
    public ChangeScore changeScore;

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
        if(checkProcedure.irigasi == false)
        {
            changeScore.procedureSucceed();
            checkProcedure.irigasi = true;
        }
        irigasi.PlayOneShot(clip);
        water.Play();
        blood.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        //bloodWater.transform.SetParent(irigasiObj);
    }

    public void StopIrigation()
    {
        irigasi.Stop();
        water.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        //bloodWater.transform.SetParent(newParent);

    }


}
