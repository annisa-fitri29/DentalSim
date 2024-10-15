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

    [SerializeField] GameObject Timer;

    [SerializeField] TextMeshProUGUI backText;
    TextMeshProUGUI scoreText;
    public ChangeScore changeScore;

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
        Timer.SetActive(false);
        scoreText.SetText("It is done! Let's see what's your score below<br> <br> Final Score: <br>" + changeScore.totalScore);
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
