using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] public GameObject scoreBoard;

    
    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("InleverKnop");
    }

    public void Inleveren()
    {
        scoreBoard.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene("Menu");
    }
}
