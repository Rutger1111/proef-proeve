using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.UIElements;

public class SpriteHandler : MonoBehaviour
{

    public List<GameObject> hair =new List<GameObject>();
    public List<GameObject> shirts =new List<GameObject>();
    public List<GameObject> pants =new List<GameObject>();
    public List<GameObject> shoes =new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Invoke(ClotheSettings clothingSettings)
    {
        ChangeSprite(clothingSettings);
    }

    public void ChangeSprite(ClotheSettings clothingSettings)
    {
        switch (clothingSettings.GetClothKind())
        {
            case EClothes.Head:
                for (int i = 0; i < clothingSettings.GetTexture().Count; i++)
                {
                    hair[i].GetComponent<RawImage>().texture = clothingSettings.GetTexture()[i];
                    hair[i].GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();

                }
                break;
            case EClothes.Shirts:
                for (int i = 0; i < clothingSettings.GetTexture().Count; i++)
                {
                    shirts[i].GetComponent<RawImage>().texture = clothingSettings.GetTexture()[i];
                    shirts[i].GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();

                }
                break;
            case EClothes.Pants:
                for (int i = 0; i < clothingSettings.GetTexture().Count; i++)
                {
                    pants[i].GetComponent<RawImage>().texture = clothingSettings.GetTexture()[i];
                    pants[i].GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();

                }
                break;
            case EClothes.Shoes:
                for (int i = 0; i < clothingSettings.GetTexture().Count; i++)
                {
                    shoes[i].GetComponent<RawImage>().texture = clothingSettings.GetTexture()[i];
                    shoes[i].GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();

                }
                break;
        }
        
    }
}
