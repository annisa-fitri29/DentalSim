using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckProcedure : MonoBehaviour
{
    public ChangeScore changeScore;
    public bool bein = false;
    public bool tools = false;
    public bool tang = false;
    public bool irigasi = false;
    public bool curette = false;
    public bool cotton = false;

    public void beinDone()
    {
        bein = true;
        changeScore.procedureSucceed();
    }
}
