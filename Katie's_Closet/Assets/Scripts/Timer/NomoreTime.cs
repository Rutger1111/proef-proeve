using UnityEngine;

public class NomoreTime : MonoBehaviour
{

    [SerializeField] private GameObject scoreboard;

    private Timer time;
    private Score _score;
    void Start()
    {
        time = GetComponent<Timer>();
        _score = GetComponent<Score>();

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
