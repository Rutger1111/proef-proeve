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

    
    

    void Start()
    {
       GameObject parentSelectedClothes = GameObject.Find("ParentClothParts");
       
       foreach(Transform clothesSelected in parentSelectedClothes.transform)
       {
           selectedclothes.Add(clothesSelected.gameObject);
       }
        
        GameObject parentShownClothes = GameObject.Find("Panel");

        foreach (Transform clothesShown in parentShownClothes.transform)
        {
            GameObject parentModelClothes = GameObject.Find("modelOutline");
            
                foreach (Transform ModelClothes in parentModelClothes.transform)
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
                    _finalScore = timeReference.timerDuration + stylePoints;
                   
                }
            }
        }
        foreach (GameObject Image in selectedclothes)
        {
            foreach (GameObject clothes in shownClothes)
            {
                if (Image.GetComponent<ClotheReference>().CL.Id == clothes.GetComponent<ClotheReference>().CL.Id)
                {
                    
                    _finalScore = timeReference.timerDuration + stylePoints;
                   
                }
            }
        }
    }

    public void gameOver()
    {
        scoreText.text = "score: " + _finalScore.ToString("F0");
    }


}
