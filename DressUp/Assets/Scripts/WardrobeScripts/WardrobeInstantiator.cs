using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class WardrobeInstantiator : MonoBehaviour
{
    public GameObject gridPrefab;
    public GameObject boxiePrefab;
    public Transform canvasTransform;
    public List<Wardrobe> wardrobes;
    public SpriteHandler spriteHandler;

    private List<GameObject> buttonsList = new List<GameObject>();

    public int index;

    public UIScale _uiscale;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        /*for (int index = 0; index <= wardrobes.Count - 1; index ++){
            GameObject gameObject = Instantiate(gridPrefab,canvasTransform);
            gameObject.transform.parent = canvasTransform.GetChild(1);
            //this for loop makes a cloth for every cloth in the wardrobe
            for (int I = 0; I < wardrobes[index].clothesTextures.Count; I ++){
                GameObject gameObject1 = Instantiate(boxiePrefab, gameObject.transform);
                //sets the settings of the cloth
                gameObject1.GetComponent<ClotheSettings>().cloth = wardrobes[index].clothesTextures[I];
            }
        }*/
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
                switch(gameObject1.GetComponent<ClotheSettings>().cloth.clothKind){
                    case EClothes.Head:
                        GameObject.Find("EventSystem").GetComponent<SpriteHandler>().hair.Add(this.gameObject);
                        break;           
                    case EClothes.Pants:
                        GameObject.Find("EventSystem").GetComponent<SpriteHandler>().pants.Add(this.gameObject);
                        break;           
                    case EClothes.Shirts:
                        GameObject.Find("EventSystem").GetComponent<SpriteHandler>().shirts.Add(this.gameObject);
                        break;           
                    case EClothes.Shoes:
                        GameObject.Find("EventSystem").GetComponent<SpriteHandler>().shoes.Add(this.gameObject);
                        break;           
                }

                
                
            }
        

    }
}
