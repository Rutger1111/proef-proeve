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
        GameObject parentSelectedClothes = GameObject.Find("ModelClothesParts");

        foreach (Transform clothesSelected in parentSelectedClothes.transform)
        {
            selectedclothes.Add(clothesSelected.gameObject);
        }

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
    }




    public void SubmitClothes()
    {
        foreach (GameObject image in selectedclothes)
        {
            foreach (GameObject clothes in shownClothes)
            {
                if (image.GetComponent<ClotheReference>().CL.style == clothes.GetComponent<ClotheReference>().CL.style)
                {
                    stylePoints += pointsForRightClothes;
                }

                if (image.GetComponent<ClotheReference>().CL.Id == clothes.GetComponent<ClotheReference>().CL.Id)
                {
                    stylePoints += 10f;
                }
                else
                {
                    idDifference = Mathf.Abs(image.GetComponent<ClotheReference>().CL.Id - clothes.GetComponent<ClotheReference>().CL.Id);
                    points = Mathf.Max(0, 10f - idDifference * 2f);

                    stylePoints += points;
                }
            }
        }
        

            

        CalculateScore();

    }

    public void CalculateScore()
    {
        _finalScore += stylePoints;
    }

    public void gameOver()
    {
        scoreText.text = "score: " + _finalScore.ToString("F0");
    }


}
