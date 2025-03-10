using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using Random = Unity.Mathematics.Random;

public class Score : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text finalScoreText;
    [SerializeField] private TMPro.TMP_Text scoreText;
    [SerializeField] private TMPro.TMP_Text HighScoreText;
    
    public List<GameObject> shownClothes;
    public List<GameObject> selectedclothes;

    private float _finalScore;
    private float stylePoints;
    private float HighScore;

    private AIDresser _aiDresser;
    private Timer timeReference;
    private SaveClothes _saveClothes;
    
    public List<GameObject> matchingClothes = new List<GameObject>();

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

           
            
            

            shownClothes.Clear();


            GameObject parentModelClothes = GameObject.Find("modelOutline");


            foreach (Transform ModelClothes in parentModelClothes.transform)
            {
                if (!shownClothes.Contains(ModelClothes.gameObject))
                {
                    shownClothes.Add(ModelClothes.gameObject);
                }
            }
            GameObject parentSelectedClothes = GameObject.Find("ParentClothParts");

            foreach (Transform clothesSelected in parentSelectedClothes.transform)
            {
                selectedclothes.Add(clothesSelected.gameObject);
            }
        
        
    }
    private void UpdateHighScore()
    {
        HighScore = PlayerPrefs.GetFloat("highscore");    
    }


    private void Update()
    {
        scoreText.text = _finalScore.ToString("F0");
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SubmitClothes();
        }

        save();
    }

    public void SubmitClothes()
    {
        

        for (int i = 0; i < shownClothes.Count; i++)
        {
            for(int j = 0; j < selectedclothes.Count; j++)
            {
                for (int k = 0; k < _saveClothes.complatedClothes.Count; k++)
                {
                    stylePoints += 1;
                    //_saveClothes.complatedClothes.Add();
                }
                    if (shownClothes[i].GetComponent<ClotheReference>().CL.style == selectedclothes[j].GetComponent<ClotheReference>().CL.style)
                        {
                            stylePoints += 1;
                            
                            _saveClothes.complatedClothes[k].savedClothes.Add(selectedclothes[j]);
                            
                            matchingClothes.Add(selectedclothes[j]);
                        }

                        if (shownClothes[i].GetComponent<ClotheReference>().CL.Id == selectedclothes[j].GetComponent<ClotheReference>().CL.Id)
                        {
                            stylePoints += 3f;
                        }
                    }
                

                
                /*
                else
                {
                    float idDifference = Mathf.Abs(selectedclothes[j].GetComponent<ClotheReference>().CL.Id - shownClothes[i].GetComponent<ClotheReference>().CL.Id);
                    float points = Mathf.Max(0, 10f - idDifference * 2f);

                    stylePoints += points;
                }
                */
            }
        }
        CalculateScore();
        
        if (matchingClothes.Count > 0)
        {
            //_saveClothes.savedClothes(matchingClothes);
        }
        
        
    }

    public void CalculateScore()
    {
       _finalScore += stylePoints;
       stylePoints = 0;
    }

    public void gameOver()
    {
        HighScoreText.text = HighScore.ToString("F0");
        scoreText.text = _finalScore.ToString("F0");
        finalScoreText.text = _finalScore.ToString("F0");
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

