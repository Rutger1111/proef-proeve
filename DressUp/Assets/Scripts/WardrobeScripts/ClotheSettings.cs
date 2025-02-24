using UnityEngine;

public class ClotheSettings : MonoBehaviour
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
    public void ChangeSprite(){
        GameObject.Find("EventSystem").GetComponent<SpriteHandler>().Invoke(this);
    }
    public EClothes GetClothKind()
    {
        return cloth.clothKind;
    }
}
