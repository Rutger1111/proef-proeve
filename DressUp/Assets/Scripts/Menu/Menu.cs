using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    public Timer timer;
    public PopupTimer popupTimer;
    public Score _score;

    public AIDresser _aiDresser;
    public GameObject plane;
    
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
        _aiDresser.ChooseDress();
        plane.SetActive(true);
        popupTimer.ResetTimer();
        _score.SubmitClothes();
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
