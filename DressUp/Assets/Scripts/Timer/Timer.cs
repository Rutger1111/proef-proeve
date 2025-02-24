using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;

public class Timer : MonoBehaviour
{
    public float timerDuration;
    public float bestTime;
    public TMPro.TMP_Text timerText;
    public TMPro.TMP_Text bestTimeText;
    public TMPro.TMP_Text currentTime;
    
    public bool isTimerOn = true;

    public void Start()
    {
        float lastbesttime = PlayerPrefs.GetFloat("best time", bestTime);
        bestTimeText.text = "beste tijd: " + lastbesttime.ToString("F2");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ResetHighScores();   
        }
        // ternery operator to determan wether to use decimals or not and make the entire string ready
        string time = timerDuration > 30 ? "time: "+timerDuration.ToString("F0") : "time: " + timerDuration.ToString("F2");
        
        // checks wether it needs to subtract then subtracts
        if (timerDuration >= 0 && isTimerOn )
        {
            timerDuration -= Time.deltaTime;
        }
        
        // if its lower then 0 than it stops timer
        else
        {
            currentTime.text = "tijd: " + timerDuration.ToString("F2") + " sec";
            isTimerOn = false;
        }
        timerText.text = time;
        
        // if the current time is better than your previous best time than the high score will be updated to the current best score
        if (timerDuration > PlayerPrefs.GetFloat("best time", bestTime) && !isTimerOn)
        {
            bestTime = timerDuration;
            bestTimeText.text = "beste tijd: " + bestTime.ToString("F2") + " sec";
            PlayerPrefs.SetFloat("best time", bestTime);
        }
    }

    private void ResetHighScores()
    {
        PlayerPrefs.SetFloat("best time", bestTime = 0);
    }
}
