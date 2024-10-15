using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolWarning : MonoBehaviour
{
    public GameObject warning;

    public void showWarning()
    {
        warning.SetActive(true);
    }

    public void closeWarning()
    {
        warning.SetActive(false);
    }
}
