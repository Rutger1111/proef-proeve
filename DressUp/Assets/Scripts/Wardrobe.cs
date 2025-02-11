
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DressUp/Wardrobe")]
public class Wardrobe : ScriptableObject
{
    public List<Cloth> clothesTextures = new List<Cloth>();
    public Texture Choose(){
        
        int index = Random.Range(0, clothesTextures.Count);
        return clothesTextures[index].texture;
    }
}
