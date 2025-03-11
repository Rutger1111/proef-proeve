using System.Collections.Generic;
using UnityEngine;

public class ClotheSettings : MonoBehaviour
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
    public void ChangeSprite(int buttonindex){
        GameObject.Find("EventSystem").GetComponent<SpriteHandler>().Invoke(this);
        GameObject.Find("EventSystem").GetComponent<SoundManager>().PlaySoundTrack(1,buttonindex);
        GameObject.Find("EventSystem").GetComponent<SoundManager>().updateSourceClip();
    }
    public Cloth GetCloth()
    {
        return this.cloth;
    }
    public EClothes GetClothKind()
    {
        return cloth.clothKind;
    }
}
