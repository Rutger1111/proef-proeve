using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using Random = Unity.Mathematics.Random;




public class Score : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text finalScoreText;
    [SerializeField] private TMPro.TMP_Text scoreText;
    [SerializeField] private TMPro.TMP_Text aiScoreText;
    [SerializeField] private TMPro.TMP_Text aiFinalScoreText;
    [SerializeField] private TMPro.TMP_Text HighScoreText;
    
    public List<GameObject> shownClothes;
    public List<GameObject> selectedclothes;
    public List<GameObject> AIselectedclothes;

    public float _finalScore, AIFinalScore;
    public float stylePoints, AIStylePoints;
    private float HighScore;

    private AIDresser _aiDresser;
    private Timer timeReference;
    private SaveClothes _saveClothes;

    public bool multiplay;

    public Sprite win;
    public Sprite lose;

    public GameObject scoreScreen;
    void Start()
    {
        
        LookForObject();
        UpdateHighScore();
    }
    private void LookForObject()
    {
        
            _aiDresser = GetComponent<AIDresser>();
            timeReference = GetComponent<Timer>();
            _saveClothes = GetComponent<SaveClothes>();

           
            
            

         
            
            
        
    }
    private void UpdateHighScore()
    {
        HighScore = PlayerPrefs.GetFloat("highscore");    
    }


    private void Update()
    {
        scoreText.text = _finalScore.ToString("F0");

        if (multiplay == true)
        {
            aiScoreText.text = AIFinalScore.ToString("F0");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SubmitClothes();
        }

        save();
    }

    public void SubmitClothes()
    {
        complatedClothesList newList = new complatedClothesList();
        newList.savedImage = new List<Texture>();
        
        HashSet<Texture> uniqueTextures = new HashSet<Texture>();
        
        for (int i = 0; i < shownClothes.Count; i++)
        {
                for(int j = 0; j < selectedclothes.Count; j++)
                {
                    RawImage imageComponent = selectedclothes[j].GetComponent<RawImage>();
                        
                    if (imageComponent != null)
                    {
                        uniqueTextures.Add(imageComponent.mainTexture);
                        newList.savedImage.Add(imageComponent.mainTexture);
                    }
                    
                    if (shownClothes[i].GetComponent<ClotheReference>().CL.style == selectedclothes[j].GetComponent<ClotheReference>().CL.style)
                    { 
                        stylePoints += 1;
                    }

                    if (shownClothes[i].GetComponent<ClotheReference>().CL.Id == selectedclothes[j].GetComponent<ClotheReference>().CL.Id)
                    {
                        stylePoints += 3f;
                    }
                }

                if (multiplay == true)
                {
                    for (int j = 0; j < AIselectedclothes.Count; j++)
                    {

                        if (shownClothes[i].GetComponent<ClotheReference>().CL.style == AIselectedclothes[j].GetComponent<ClotheReference>().CL.style )
                        {
                            AIStylePoints += 1f;
                        }

                        if (shownClothes[i].GetComponent<ClotheReference>().CL.Id == AIselectedclothes[j].GetComponent<ClotheReference>().CL.Id)
                        {
                            AIStylePoints += 3f;
                        }
                    }     
                }
        }
        CalculateScore();
        
        if (newList.savedImage.Count > 0)
        {
            _saveClothes.complatedClothes.Add(newList);
        }
        
        
    }

    public void CalculateScore()
    {
       _finalScore += stylePoints;
       stylePoints = 0;
       if (multiplay == true)
       {
           AIFinalScore += AIStylePoints;
           AIStylePoints = 0;    
       }
    }

    public void gameOver()
    {
        _saveClothes.complated();       
        
        HighScoreText.text = HighScore.ToString("F0");
        scoreText.text = _finalScore.ToString("F0");
        finalScoreText.text = _finalScore.ToString("F0");
        aiFinalScoreText.text = AIFinalScore.ToString("F0");

        if (_finalScore > AIFinalScore && multiplay == false)
        {
            scoreScreen.GetComponent<Image>().sprite = win;
        }
        else if (AIFinalScore > _finalScore && multiplay == true)
        {
            scoreScreen.GetComponent<Image>().sprite = lose;
        }
    }

    public void save()
    {
        if (_finalScore >= HighScore)
        {
            HighScore = _finalScore;
            PlayerPrefs.SetFloat("highscore", HighScore);
            PlayerPrefs.Save();
        }
    }
}

