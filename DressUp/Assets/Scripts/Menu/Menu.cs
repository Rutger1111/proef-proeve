using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{


    [SerializeField] private GameObject plane;

    [SerializeField] private List<GameObject> plcs = new List<GameObject>();
    private bool pauseScreen;

    private Timer _timer;
    private PopupTimer _popupTimer;
    public Score _score;
    private AIDresser _aiDresser;

    public List<ClotheReference> _clothref;


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
        SceneManager.LoadScene("AIMode");
    }

    public void Inleveren()
    {
        try{
            _aiDresser.ChooseDress();

            _score.SubmitClothes();

            plane.SetActive(true);

            _popupTimer.ResetTimer();

            for(int i = 0; i < _clothref.Count; i++){
            _clothref[i].placeholderr();
            }
            

            foreach(var i in plcs){
            i.GetComponent<RawImage>().color = new Color(255,255,255,0);
                    
            }
            
        }

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
