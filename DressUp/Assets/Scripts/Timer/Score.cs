using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using Random = Unity.Mathematics.Random;

public class Score : MonoBehaviour
{
    public Timer timeReference;
    public TMPro.TMP_Text scoreText;

    private double _finalScore;
    public double stylePoints;
    public double pointsForRightClothes;

    public List<GameObject> shownClothes;
    public List<GameObject> selectedclothes;

    public AIDresser _aiDresser;

    public float points;
    public float idDifference;

    void Start()
    {
        

        GameObject parentShownClothes = GameObject.Find("Panel");

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
                    idDifference = Mathf.Abs(selectedclothes[j].GetComponent<ClotheReference>().CL.Id - shownClothes[i].GetComponent<ClotheReference>().CL.Id);
                    points = Mathf.Max(0, 10f - idDifference * 2f);

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
