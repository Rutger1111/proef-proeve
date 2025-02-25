using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.UIElements;

public class SpriteHandler : MonoBehaviour
{

    public GameObject hair;
    public GameObject shirts;
    public GameObject pants;
    public GameObject shoes;
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
                hair.GetComponent<RawImage>().texture = clothingSettings.GetTexture();
                hair.GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();
                break;
            case EClothes.Shirts:
                shirts.GetComponent<RawImage>().texture = clothingSettings.GetTexture();
                shirts.GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();
                break;
            case EClothes.Pants:
                pants.GetComponent<RawImage>().texture = clothingSettings.GetTexture();
                pants.GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();
                break;
            case EClothes.Shoes:
                shoes.GetComponent<RawImage>().texture = clothingSettings.GetTexture();
                shoes.GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();
                break;
        }
        
    }
}
