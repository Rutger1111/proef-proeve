using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.UIElements;

public class SpriteHandler : MonoBehaviour
{

    public GameObject topHalf;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSprite(ClothingSettings clothingSettings)
    {
        topHalf.GetComponent<RawImage>().texture = clothingSettings.GetTexture();
    }
}
