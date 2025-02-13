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
        for (int index = 0; index <= wardrobes.Count - 1; index ++){
            GameObject gameObject = Instantiate(gridPrefab,canvasTransform);
            for (int I = 0; I < wardrobes[index].clothesTextures.Count; I ++){
                GameObject gameObject1 = Instantiate(boxiePrefab, gameObject.transform);
                gameObject1.GetComponent<ClotheSettings>().cloth = wardrobes[index].clothesTextures[I];
            }
        }
    }
}
