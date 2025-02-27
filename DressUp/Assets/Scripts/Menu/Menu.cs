using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{


    [SerializeField] private GameObject plane;

    private Timer _timer;
    private PopupTimer _popupTimer;
    private Score _score;
    private AIDresser _aiDresser;


    private void Start()
    {
        _timer = GetComponent<Timer>();
        _popupTimer = GetComponent<PopupTimer>();
        _score = GetComponent<Score>();
        _aiDresser = GetComponent<AIDresser>();
    }
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
        _popupTimer.ResetTimer();
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
