using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class WardrobeInstantiator : MonoBehaviour
{
    [SerializeField] private GameObject gridPrefab;
    [SerializeField] private GameObject boxiePrefab;
    [SerializeField] private Transform canvasTransform;
    [SerializeField] private List<Wardrobe> wardrobes;
    
    private List<GameObject> buttonsList = new List<GameObject>();
    private UIScale _uiscale;
    private SpriteHandler spriteHandler;
  

    void Start()
    { 
        spriteHandler = GetComponent<SpriteHandler>();
        _uiscale = GetComponent<UIScale>();
    }
    private void Update()
    {
        foreach (var button in buttonsList.ToList())
        {
            if (button == null)
            {
                buttonsList.Remove(button);
            }
        }
       
    }
    public void buttonInstatiate(int buttonIndex)
    {
        _uiscale.ButttonSizeChanger(buttonIndex);

        foreach (var button in buttonsList) 
        { 
            Destroy(button);
        }
        
        GameObject gameObject = Instantiate(gridPrefab, canvasTransform);

        buttonsList.Add(gameObject);

        gameObject.transform.parent = canvasTransform.GetChild(1);
        for (int I = 0; I < wardrobes[buttonIndex].clothesTextures.Count; I++)
        {
            GameObject gameObject1 = Instantiate(boxiePrefab, gameObject.transform);
            gameObject1.GetComponent<ClotheSettings>().cloth = wardrobes[buttonIndex].clothesTextures[I];
            gameObject1.GetComponent<RawImage>().texture = wardrobes[buttonIndex].clothesTextures[I].iconTexture;
        }
        

    }
}
