using System.Collections.Generic;
using UnityEngine;

public class ClothingSettings : MonoBehaviour
{
    public Cloth cloth;
    
    public List<Texture> GetTexture(){
        return cloth.textures;
    }
    public int GetId(){
        return cloth.Id;
    }
    public EStyles GetStyle(){
        return cloth.style;
    }
}
