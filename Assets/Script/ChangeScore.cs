using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScore : MonoBehaviour
{
    public int totalScore = 4;
    
    public void procedureSucceed()
    {
        totalScore += 16;
    }

    public void wrongTool()
    {
        totalScore -= 2;
        if(totalScore <= 0)
        {
            totalScore = 0;
        }
    }

    public void wrongProcedure()
    {
        totalScore -= 5;
        if(totalScore <= 0)
        {
            totalScore = 0;
        }
    }
}
