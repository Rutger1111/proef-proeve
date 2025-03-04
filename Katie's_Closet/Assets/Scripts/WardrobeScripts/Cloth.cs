using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DressUp/Cloth")]
public class Cloth : ScriptableObject
{
    // cloth is a scriptable object with the info of eacht cloth
    public List<Texture> textures = new List<Texture>();
    public Texture iconTexture;
    public int Id;
    public EStyles style;
    public EClothes clothKind;

}

