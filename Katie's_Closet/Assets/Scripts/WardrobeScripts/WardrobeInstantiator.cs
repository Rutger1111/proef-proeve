using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
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
    private SoundManager _soundManager;
  

    void Start()
    { 
        spriteHandler = GetComponent<SpriteHandler>();
        _uiscale = GetComponent<UIScale>();
        _soundManager = GetComponent<SoundManager>();
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

        _soundManager.PlaySoundTrack(0);
        
        foreach (var button in buttonsList) 
        { 
            Destroy(button);
            _soundManager.nodes[1].source.Clear();
        }
        
        GameObject gameObject = Instantiate(gridPrefab, canvasTransform);

        buttonsList.Add(gameObject);

        gameObject.transform.parent = canvasTransform.GetChild(1);
        for (int I = 0; I < wardrobes[buttonIndex].clothesTextures.Count; I++)
        {
            GameObject gameObject1 = Instantiate(boxiePrefab, gameObject.transform);
            gameObject1.GetComponent<ClotheSettings>().cloth = wardrobes[buttonIndex].clothesTextures[I];
            gameObject1.GetComponent<RawImage>().texture = wardrobes[buttonIndex].clothesTextures[I].iconTexture;
            _soundManager.nodes[1].source.Add(gameObject1.GetComponent<AudioSource>());
        }
    }
}
