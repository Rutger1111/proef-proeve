using UnityEngine;

public class Timer : MonoBehaviour
{
    public double timerDuration;
    public TMPro.TMP_Text timerText;
    
    private bool _isTimerOn = true;
    
    void Update()
    {
        // ternery operator to determan wether to use decimals or not and make the entire string ready
        string time = timerDuration > 30 ? "time: "+timerDuration.ToString("F0") : "time: " + timerDuration.ToString("F2");
        // checks wether it needs to subtract then subtracts
        if (timerDuration >= 0 && _isTimerOn )
        {
            timerDuration -= Time.deltaTime;
        }
        // if its lower then 0 than it stops timer and sets it 0
        else
        {
            timerDuration = 0;
            _isTimerOn = false;
        }
        timerText.text = time;
    }
}
