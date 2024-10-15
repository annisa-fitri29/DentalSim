using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class snapCotton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cotton;
    public Transform tweezer;
    public Transform newParent;
    public ChangeScore changeScore;
    public CheckProcedure checkProcedure;
    void Start()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartFollowTweezer());
        grabInteractable.deactivated.AddListener(x => StopFollowTweezer());
    }

    // Update is called once per frame
    public void StartFollowTweezer()
    {
        cotton.transform.SetParent(tweezer);

        if(checkProcedure.cotton == false)
        {
            changeScore.procedureSucceed();
            checkProcedure.cotton = true;
        }
    }

    public void StopFollowTweezer()
    {
        cotton.transform.SetParent(newParent);
    }

}
