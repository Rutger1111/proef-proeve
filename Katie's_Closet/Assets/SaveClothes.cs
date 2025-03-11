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

    public GameObject canvas;
    public GameObject model;
    
    private int currentClothingIndex = 0;
    
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            complated();
        }
    }
    public void complated()
    {
        if (complatedClothes.Count == 0) return;
        
       if (currentClothingIndex < complatedClothes.Count)
        {
            var item = complatedClothes[currentClothingIndex];

        
            GameObject prefab2 = Instantiate(model);
            prefab2.transform.SetParent(canvas.transform);
            prefab2.transform.localPosition = Vector3.zero;

           
            for (int i = 0; i < item.savedImage.Count; i++)
            {
                Texture savedImage = item.savedImage[i];

                
                if (i == 0) 
                {
                    Transform hairChild = FindDeepChild(prefab2.transform, "Hair_Voorbeeld");
                    if (hairChild != null && savedImage != null)
                    {
                        ApplySavedImageToChild(hairChild, savedImage);
                    }
                }
                else if (i == 1) 
                {
                    Transform shoesChild = FindDeepChild(prefab2.transform, "Shoes_Voorbeeld");
                    if (shoesChild != null && savedImage != null)
                    {
                        ApplySavedImageToChild(shoesChild, savedImage);
                    }
                }
                else if (i == 2) 
                {
                    Transform pantsChild = FindDeepChild(prefab2.transform, "Pants_Voorbeeld");
                    if (pantsChild != null && savedImage != null)
                    {
                        ApplySavedImageToChild(pantsChild, savedImage);
                    }
                }
                else if (i == 3) 
                {
                    Transform shirtChild = FindDeepChild(prefab2.transform, "Shirt_Voorbeeld");
                    if (shirtChild != null && savedImage != null)
                    {
                        ApplySavedImageToChild(shirtChild, savedImage);
                    }
                }
            }
            
            currentClothingIndex++;
        }
    }
    
    private void ApplySavedImageToChild(Transform child, Texture savedImage)
    {
        
        RawImage rawImage = child.GetComponent<RawImage>();
        if (rawImage != null)
        {
            rawImage.texture = savedImage; 
        }
    }

    private Transform FindDeepChild(Transform parent, string childName)
    {
        foreach (Transform child in parent)
        {
            if (child.name == childName)
            {
                return child;
            }

            var result = FindDeepChild(child, childName);
            if (result != null) return result;
        }
        return null;
    }
}

[Serializable]
public class complatedClothesList
{
    public List<Texture> savedImage;
}
