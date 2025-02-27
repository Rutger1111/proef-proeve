using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using Random = Unity.Mathematics.Random;

public class Score : MonoBehaviour
{
    
    [SerializeField] private TMPro.TMP_Text scoreText;
    [SerializeField] private float pointsForRightClothes;

    [HideInInspector] public List<GameObject> shownClothes;
    [HideInInspector] public List<GameObject> selectedclothes;

    private double _finalScore;
    private double stylePoints;

    private AIDresser _aiDresser;
    private Timer timeReference;

    void Start()
    {
        _aiDresser = GetComponent<AIDresser>();
        timeReference = GetComponent<Timer>();

        GameObject parentShownClothes = GameObject.Find("VoorbeeldPanel");

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




    public void SubmitClothes()
    {
        for (int i = 0; i < shownClothes.Count; i++)
        {
            for(int j = 0; j < selectedclothes.Count; j++)
            {
                if (shownClothes[i].GetComponent<ClotheReference>().CL.style == selectedclothes[j].GetComponent<ClotheReference>().CL.style)
                {
                    stylePoints += pointsForRightClothes;
                }

                if (shownClothes[i].GetComponent<ClotheReference>().CL.Id == selectedclothes[j].GetComponent<ClotheReference>().CL.Id)
                {
                    stylePoints += 5f;
                }
                else
                {
                    float idDifference = Mathf.Abs(selectedclothes[j].GetComponent<ClotheReference>().CL.Id - shownClothes[i].GetComponent<ClotheReference>().CL.Id);
                    float points = Mathf.Max(0, 10f - idDifference * 2f);

                    stylePoints += points;
                }
            }
        }
        
        

            

        CalculateScore();

    }

    public void CalculateScore()
    {
        if(stylePoints < 100)
        {
            _finalScore += stylePoints;
        }
        else
        {
            _finalScore += 100;
        }
       
    }

    public void gameOver()
    {
        scoreText.text = "score: " + _finalScore.ToString("F0");
    }


}
