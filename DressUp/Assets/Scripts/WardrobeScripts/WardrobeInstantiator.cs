using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class WardrobeInstantiator : MonoBehaviour
{
    public GameObject gridPrefab;
    public GameObject boxiePrefab;
    public Transform canvasTransform;
    public List<Wardrobe> wardrobes;
    public SpriteHandler spriteHandler;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for loop makes for every wardrobe a grid
        for (int index = 0; index <= wardrobes.Count - 1; index ++){
            GameObject gameObject = Instantiate(gridPrefab,canvasTransform);
            gameObject.transform.parent = canvasTransform.GetChild(1);
            //this for loop makes a cloth for every cloth in the wardrobe
            for (int I = 0; I < wardrobes[index].clothesTextures.Count; I ++){
                GameObject gameObject1 = Instantiate(boxiePrefab, gameObject.transform);
                //sets the settings of the cloth
                gameObject1.GetComponent<ClotheSettings>().cloth = wardrobes[index].clothesTextures[I];
            }
        }
    }
}
