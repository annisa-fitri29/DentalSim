using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickTools : MonoBehaviour
{
    [SerializeField] GameObject[] disableTools;
    [SerializeField] GameObject[] enableModel;
    public CheckProcedure checkProcedure;
    public ChangeScore changeScore;
    public void donePicking()
    {
        for(int i = 0; i< disableTools.Length; i++)
        {
            disableTools[i].SetActive(false);
        }
        
        for(int i = 0; i< enableModel.Length; i++)
        {
            enableModel[i].SetActive(true);
        }
        
        checkProcedure.tools = true;
        changeScore.procedureSucceed();

    }
}
