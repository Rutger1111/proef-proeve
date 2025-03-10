using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{


    [SerializeField] private GameObject modelPanel;
    [SerializeField] private GameObject escapePanel;
    [SerializeField] private List<GameObject> ClothingSlothes = new List<GameObject>();
    public List<ClotheReference> _clothref;


    private Timer _timer;
    private PopupTimer _popupTimer;
    private Score _score;
    private AIDresser _aiDresser;

    
    private bool isEscapeMenuOpen;


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

    public void SubmitClothes()
    {
       
            _aiDresser.ChooseDress();

            _score.SubmitClothes();

            modelPanel.SetActive(true);

            _popupTimer.ResetTimer();

            for(int i = 0; i < _clothref.Count; i++){
                _clothref[i].placeholderr();
            }
            

            foreach(var i in ClothingSlothes){
                i.GetComponent<RawImage>().color = new Color(255,255,255,0);
                    
            }
            
        
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Return()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            Debug.Log("Ruben sucks");
            modelPanel.SetActive(true);
        }
        
        if (Input.GetKeyDown(KeyCode.Escape) && isEscapeMenuOpen == false)
        {
            OpenEscapeMenu();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isEscapeMenuOpen == true)
        {
            CloseEscapeMenu();
        }
    }

    public void OpenEscapeMenu()
    {
        escapePanel.SetActive(true);

        isEscapeMenuOpen = true;
    }
    public void CloseEscapeMenu()
    {
        escapePanel.SetActive(false);

        isEscapeMenuOpen = false;
    }
}
