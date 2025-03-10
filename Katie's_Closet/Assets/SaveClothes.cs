using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SaveClothes : MonoBehaviour
{
    public List<complatedClothesList> complatedClothes;
    public List<GameObject> panel;

    public GameObject canvas;

    public GameObject model;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            complated();
            
            print("hhhh");
        }
    }

    public void complated()
    {
        print("check");
        for (int i = 0; i < complatedClothes.Count; i++)
        {
            print("heck");
            for (int j = 0; j < complatedClothes[i].savedClothes.Count; j++)
            {
                print("deck");
                for (int k = 0; k < panel.Count; k++)
                {
                    print("fff");
                    
                    GameObject prefab = Instantiate(complatedClothes[i].savedClothes[j], panel[k].transform);

                    GameObject prefab2 = Instantiate(model, panel[k].transform);
                    
                    prefab.GetComponent<RawImage>().color = new Color(255, 255, 255, 255);

                    prefab2.transform.SetParent(canvas.transform);
                    prefab.transform.SetParent(canvas.transform);

                    //refab.transform.localScale = new Vector3(10,10,10);     
                }
               
            }
        }
        
    }

    public void savedClothes(List<GameObject> selectedClothes)
    {
        complatedClothesList newlist = new complatedClothesList();
        
        foreach (var clothes in selectedClothes)
        {
            newlist.savedClothes.Add(clothes);
        }
        
        complatedClothes.Add(newlist);
    }
}

[Serializable] public class complatedClothesList
{
    public List<GameObject> savedClothes;
}
