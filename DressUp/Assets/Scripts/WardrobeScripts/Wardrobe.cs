
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DressUp/Wardrobe")]
public class Wardrobe : ScriptableObject
{
    //wardrobe is a scriptable object to easily make new literal wardrobes, a wardrobe contains lots of clothes in the same category like shoes.
    public List<Cloth> clothesTextures = new List<Cloth>();
    // choose() chooses a random image for the ai-dresser
    public Cloth Choose(){
        
        int index = Random.Range(0, clothesTextures.Count);
        return clothesTextures[index];
    }
}
