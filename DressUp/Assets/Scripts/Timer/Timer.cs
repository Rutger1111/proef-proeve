using UnityEngine;

public class Timer : MonoBehaviour
{
    public double timerDuration = 120;
    public TMPro.TMP_Text timerText;
    
    private bool _isTimerOn = true;
    
    void Update()
    {
        string time = timerDuration > 30 ? "time: "+timerDuration.ToString("F0") : "time: " + timerDuration.ToString("F2");
        if (timerDuration >= 0 && _isTimerOn )
        {
            timerDuration -= 1 * Time.deltaTime;
        }
        else
        {
            timerDuration = 0;
            _isTimerOn = false;
        }
        timerText.text = time;
    }
}
