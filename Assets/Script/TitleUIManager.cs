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

        if(changeScore.totalScore < 51)
        {
            scoreText.SetText("Try again! You can do it!<br> <br> Final Score: <br>" + changeScore.totalScore);
        }
        else if(changeScore.totalScore<70 && changeScore.totalScore>50)
        {
            scoreText.SetText("You are improving! Try again!<br> <br> Final Score: <br>" + changeScore.totalScore);
        }
        else if(changeScore.totalScore<86 && changeScore.totalScore>69)
        {
            scoreText.SetText("Nice! You will do greatly with more training!<br> <br> Final Score: <br>" + changeScore.totalScore);
        } 
        else if(changeScore.totalScore>85)
        {
            scoreText.SetText("Excelent work there! Nicely done<br> <br> Final Score: <br>" + changeScore.totalScore);
        }
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
