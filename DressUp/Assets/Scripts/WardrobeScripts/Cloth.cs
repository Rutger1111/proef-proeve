using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DressUp/Cloth")]
public class Cloth : ScriptableObject
{
    // cloth is a scriptable object with the info of eacht cloth
    public Texture texture;
    public Texture iconTexture;
    public int Id;
    public EStyles style;
    public EClothes clothKind;

}

