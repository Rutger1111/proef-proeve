using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;

public class Timer : MonoBehaviour
{
    [SerializeField] public float timerDuration;
    [SerializeField] private TMPro.TMP_Text timerText;

    [SerializeField] private bool isTimerOn = true;

    private PopupTimer _popupTimer;
    public void Start()
    {
        _popupTimer = GetComponent<PopupTimer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ResetHighScores();   
        }
        // ternery operator to determan wether to use decimals or not and make the entire string ready
        string time = timerDuration > 30 ? timerDuration.ToString("F0") : timerDuration.ToString("F0");
        timerText.text = time;
        // checks whether it needs to subtract then subtracts
        if (timerDuration >= 0 && _popupTimer.timer <= 0)
        {
            timerDuration -= Time.deltaTime;
        }
        
        // if its lower then 0 than it stops timer
        else if (timerDuration <= 0)
        {
            
            GetComponent<Score>().gameOver();
            timerText.text = "0";
            //currentTime.text = "tijd: " + timerDuration.ToString("F2") + " sec";
        }
        
        
        // if the current time is better than your previous best time than the high score will be updated to the current best score
        //if (timerDuration > PlayerPrefs.GetFloat("best time", bestTime) && !isTimerOn)
        {
            //bestTime = timerDuration;
            //bestTimeText.text = "beste tijd: " + bestTime.ToString("F2") + " sec";
            //PlayerPrefs.SetFloat("best time", bestTime);
        }
    }

    private void ResetHighScores()
    {
        //PlayerPrefs.SetFloat("best time", bestTime = 0);
    }
}
