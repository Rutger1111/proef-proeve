using System.Collections.Generic;
using System.Linq;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class WardrobeInstantiator : MonoBehaviour
{
    public GameObject gridPrefab;
    public GameObject boxiePrefab;
    public Transform canvasTransform;
    public List<Wardrobe> wardrobes;
    public SpriteHandler spriteHandler;

    private List<GameObject> buttonsList = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*for (int index = 0; index <= wardrobes.Count - 1; index ++){
            GameObject gameObject = Instantiate(gridPrefab,canvasTransform);
            gameObject.transform.parent = canvasTransform.GetChild(1);
            for (int I = 0; I < wardrobes[index].clothesTextures.Count; I ++){
                GameObject gameObject1 = Instantiate(boxiePrefab, gameObject.transform);
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
            }
        

    }
}
