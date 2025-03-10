using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private List<GameObject> tutorialPanel = new List<GameObject>();
    [SerializeField] private GameObject tutorialPanel1;
    [SerializeField] private GameObject tutorialPanel2;
    [SerializeField] private GameObject tutorialPanel3;
    [SerializeField] private GameObject tutorialPanel4;

    [SerializeField] private GameObject modelPanel;
    [SerializeField] private GameObject escapePanel;
    [SerializeField] private List<GameObject> ClothingSlothes = new List<GameObject>();
    public List<ClotheReference> _clothref;
    private int index = 0;


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

    public void NextPanel(int direction)
    {
        if (index >= tutorialPanel.Count || index < 0)
        {
            index = 0;
            CloseTutorial();
        }
        else
        {
            tutorialPanel[index].SetActive(false);
            index += direction;
            tutorialPanel[index].SetActive(true);
        }

    }

    public void OpenTutorial()
    {
        tutorialPanel1.SetActive(true);
    }
    public void CloseTutorial()
    {
        tutorialPanel1.SetActive(false);
    }
    /*public void Tutorial1()
    {
        tutorialPanel1.SetActive(false);
        tutorialPanel2.SetActive(true);
        tutorialPanel3.SetActive(false);
    }
    public void Tutorial2()
    {
        tutorialPanel2.SetActive(false);
        tutorialPanel3.SetActive(true);
        tutorialPanel4.SetActive(false);
    }
    public void Tutorial3()
    {
        tutorialPanel3.SetActive(false);
        tutorialPanel4.SetActive(true);
    }
    public void Tutorial4()
    {
        tutorialPanel4.SetActive(false);
    }*/
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
        try{
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
        catch{
            return;
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
