using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class WardrobeInstantiator : MonoBehaviour
{
    public GameObject gridPrefab;
    public GameObject boxiePrefab;
    public Transform canvasTransform;
    public List<Wardrobe> wardrobes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int index = 0; index <= wardrobes.Count - 1; index ++){
            GameObject gameObject = Instantiate(gridPrefab,canvasTransform);
            for (int I = 0; I <= wardrobes[index].clothesTextures.Count; I ++){
                Instantiate(boxiePrefab, gameObject.transform);
            }
        }
    }
}
