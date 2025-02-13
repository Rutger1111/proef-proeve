using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.UIElements;

public class SpriteHandler : MonoBehaviour
{

    public GameObject topHalf;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Invoke(ClotheSettings clothingSettings)
    {
        ChangeSprite(clothingSettings);
    }

    public void ChangeSprite(ClotheSettings clothingSettings)
    {
        topHalf.GetComponent<RawImage>().texture = clothingSettings.GetTexture();
    }
}
