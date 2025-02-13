using UnityEngine;

public class ClothingSettings : MonoBehaviour
{
    public Cloth cloth;
    
    public Texture GetTexture(){
        return cloth.texture;
    }
    public int GetId(){
        return cloth.Id;
    }
    public EStyles GetStyle(){
        return cloth.style;
    }
}
