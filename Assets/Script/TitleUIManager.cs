using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TitleUIManager : MonoBehaviour
{
    [SerializeField] GameObject menuUI;
    [SerializeField] GameObject patientUI;
    [SerializeField] GameObject titleText;
    [SerializeField] GameObject aboutText;
    [SerializeField] GameObject scoreUI;
    [SerializeField] GameObject scoreBtn;
    [SerializeField] TextMeshProUGUI backText;

    bool backIsOn;

    void Start()
    {
        backIsOn = false;
    }

    public void pickPatient()
    {
        menuUI.SetActive(false);
        patientUI.SetActive(true);
    }
    public void showFinalScore()
    {
        scoreUI.SetActive(true);
        scoreBtn.SetActive(false);
    }
    
    public void showAbout()
    {
        aboutText.SetActive(true);
        titleText.SetActive(false);
        backIsOn = true;
        backText.text = "Back";
    }

    public void showTitle()
    {
        aboutText.SetActive(false);
        titleText.SetActive(true);
        backIsOn = false;
        backText.text = "About";
    }

    public void buttonClicked()
    {
        if(backIsOn == true)
        {
            showTitle();
        }
        else
        {
            showAbout();
        }
    }
}
