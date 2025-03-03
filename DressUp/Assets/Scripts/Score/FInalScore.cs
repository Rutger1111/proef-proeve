using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FInalScore : MonoBehaviour
{
    public List<GameObject> showClothes;
    public List<GameObject> selectedclothes;

    //public List<Wardrobe> wardrobes;

    public float score;

    //public GameObject ss;

    private float timer = 3f;
    void Start()
    {
        
    }

  
    void Update()
    {
        timer -= Time.deltaTime;
    }

    public void buttonClick()
    {
        foreach (GameObject image in selectedclothes)
        {
            foreach (GameObject clothes in showClothes)
            {
                if (image.GetComponent<ClotheReference>().CL.style == clothes.GetComponent<ClotheReference>().CL.style) 
                {
                    score += 5F;
                    timer = 3f;
                }
            }
            
        }
    }
}
