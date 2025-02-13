using UnityEngine;
using Random = Unity.Mathematics.Random;

public class Score : MonoBehaviour
{
    public Timer timeReference;
    public TMPro.TMP_Text scoreText;

    private double _finalScore;
    private double _stylePoints;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _finalScore = timeReference.timerDuration + _stylePoints;
        scoreText.text = "score: " + _finalScore.ToString("F0");
    }
}
