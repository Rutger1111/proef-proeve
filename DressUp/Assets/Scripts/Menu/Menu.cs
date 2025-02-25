using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] public GameObject scoreBoard;
    public Timer timer;

    public Score _score;
    
    public void ExitGame()
    {
        Application.Quit();
    }

    public void SinglePlayerGame()
    {
        SceneManager.LoadScene("SinglePlayer");
    }
    
    public void MultiPlayerGame()
    {
        SceneManager.LoadScene("dressup");
    }

    public void Inleveren()
    {
      


        scoreBoard.SetActive(true);
        timer.isTimerOn = false;
        Debug.Log(timer.bestTime);

        _score.SubmitClothes();
    }

    public void Retry()
    {
        SceneManager.LoadScene("Menu");
    }
}
