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
    public ChangeScore changeScore;
    public beinSkipped beinSkipped;
    public CheckProcedure checkProcedure;
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

        if(checkProcedure.bein == true)
        {
            if(checkProcedure.tang == false)
            {
                changeScore.procedureSucceed();
                checkProcedure.tang = true;
            }
        }

        else if(checkProcedure.bein == false)
        {
            beinSkipped.beinIsSkipped();
        }


    }

    public void StopFollowTang()
    {
        tooth.transform.SetParent(newParent);
    }

}
