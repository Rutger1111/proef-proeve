using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AIDresser : MonoBehaviour
{
    public List<Wardrobe> wardrobes = new List<Wardrobe>();
    public List<RawImage> Dress = new List<RawImage>();
    void Start()
    {
        ChooseDress();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            ChooseDress();
        }
    }
    private void ChooseDress(){
        for (int I = wardrobes.Count - 1;I > -1; I --){
            ChooseClothe(wardrobes[I], I);
        }
    }
    private void ChooseClothe(Wardrobe wardrobe, int index){
        Dress[index].texture = wardrobe.Choose();
    }
}
