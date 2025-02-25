using UnityEngine;

public class NomoreTime : MonoBehaviour
{
    public Timer time;
    public GameObject scoreboard;
    public Score _score;
    void Start()
    {
        scoreboard.SetActive(false);
    }

    
    void Update()
    {
        if (time.timerDuration <= 0) 
        {
            scoreboard.SetActive(true);
            _score.gameOver();
        }
    }
}
