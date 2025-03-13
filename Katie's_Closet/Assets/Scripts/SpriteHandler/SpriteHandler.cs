using System.Collections.Generic;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class SpriteHandler : MonoBehaviour
{

    [SerializeField] private List<GameObject> hair =new List<GameObject>();
    [SerializeField] private List<GameObject> backHair;
    [SerializeField] private List<GameObject> shirts =new List<GameObject>();
    [SerializeField] private List<GameObject> pants =new List<GameObject>();
    [SerializeField] private List<GameObject> shoes =new List<GameObject>();

    public Wardrobe _Wardrobe;
    public void Invoke(ClotheSettings clothingSettings)
    {
        print(clothingSettings);
        ChangeSprite(clothingSettings);
    }

    public void ChangeSprite(ClotheSettings clothingSettings)
    {
        switch (clothingSettings.GetClothKind())
        {
            case EClothes.Head:
                for (int i = 0; i < clothingSettings.GetTexture().Count; i++)
                {
                    Color color = hair[i].GetComponent<RawImage>().color;
                    hair[i].GetComponent<RawImage>().color = new Color(color.r, color.g, color.b, 225);
                    hair[i].GetComponent<RawImage>().texture = clothingSettings.GetTexture()[i];
                    hair[i].GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();
                    
                    if (i < backHair.Count)
                    {
                        Color backHairColor = backHair[i].GetComponent<RawImage>().color;
                        backHair[i].GetComponent<RawImage>().color = new Color(backHairColor.r, backHairColor.g, backHairColor.b, 225);

                        
                        backHair[i].GetComponent<RawImage>().texture = clothingSettings.GetTexture()[i];
                        backHair[i].GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();
                    }
                }
                break;
            case EClothes.Shirts:
                for (int i = 0; i < clothingSettings.GetTexture().Count; i++)
                {
                    Color color = shirts[i].GetComponent<RawImage>().color;
                    shirts[i].GetComponent<RawImage>().color = new Color(color.r,color.g,color.b, 225);
                    shirts[i].GetComponent<RawImage>().texture = clothingSettings.GetTexture()[i];
                    shirts[i].GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();

                }
                break;
            case EClothes.Pants:
                for (int i = 0; i < clothingSettings.GetTexture().Count; i++)
                {
                    Color color = pants[i].GetComponent<RawImage>().color;
                    pants[i].GetComponent<RawImage>().color = new Color(color.r,color.g,color.b, 225);
                    pants[i].GetComponent<RawImage>().texture = clothingSettings.GetTexture()[i];
                    pants[i].GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();

                }
                break;
            case EClothes.Shoes:
                for (int i = 0; i < clothingSettings.GetTexture().Count; i++)
                {
                    Color color = shoes[i].GetComponent<RawImage>().color;
                    shoes[i].GetComponent<RawImage>().color = new Color(color.r,color.g,color.b, 225);
                    shoes[i].GetComponent<RawImage>().texture = clothingSettings.GetTexture()[i];
                    shoes[i].GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();

                }
                break;
        }
        
    }
}
