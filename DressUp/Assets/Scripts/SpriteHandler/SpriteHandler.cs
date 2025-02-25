using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.UIElements;

public class SpriteHandler : MonoBehaviour
{

    public GameObject topHalf;
    public GameObject midHalf;
    public GameObject bottomHalf;
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
                topHalf.GetComponent<RawImage>().texture = clothingSettings.GetTexture();
                topHalf.GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();
                break;
            case EClothes.Torso:
                midHalf.GetComponent<RawImage>().texture = clothingSettings.GetTexture();
                midHalf.GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();
                break;
            case EClothes.Pants:
                bottomHalf.GetComponent<RawImage>().texture = clothingSettings.GetTexture();
                bottomHalf.GetComponent<ClotheReference>().CL = clothingSettings.GetCloth();
                break;
        }
        
    }
}
