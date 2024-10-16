using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientUIManager : MonoBehaviour
{
    [SerializeField] GameObject nabilScene;
    [SerializeField] GameObject patientUI;
    [SerializeField] GameObject menuUI;
    [SerializeField] GameObject ToothUI;

    public void startNabil()
    {
        nabilScene.SetActive(true);
        //patientUI.SetActive(false);
        ToothUI.SetActive(false);
    }

    public void backToMenu()
    {
        patientUI.SetActive(false);
        menuUI.SetActive(true);
    }

    public void openToothMenu()
    {
        patientUI.SetActive(false);
        ToothUI.SetActive(true);
    }
}
