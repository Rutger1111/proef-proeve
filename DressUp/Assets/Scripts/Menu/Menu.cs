using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] public GameObject scoreBoard;
    public Timer timer;

    
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
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Return()
    {
        SceneManager.LoadScene("Menu");
    }
}
