using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AIDresser : MonoBehaviour
{
    public List<Wardrobe> wardrobes = new List<Wardrobe>();
    public List<RawImage[]> Dress = new List<RawImage[]>();
    void Start()
    {
        // start choosing example dress
        ChooseDress();
    }
    void Update()
    {
        // for testing to input yourself
        if(Input.GetKeyDown(KeyCode.A)){
            ChooseDress();
        }
    }
    //chooses dress according to all warddrobes in list
    public void ChooseDress(){
        for (int I = wardrobes.Count - 1;I > -1; I --){
            ChooseClothe(wardrobes[I], I);
        }
    }
    // actually chooses the cloth via the cloth his  function
    private void ChooseClothe(Wardrobe wardrobe, int index){
        Cloth cloth = wardrobe.Choose();
        for (int i = 0; i < cloth.textures.Count; i++)
        {
            Dress[index][i].texture = cloth.textures[i];
            Dress[index][i].GetComponent<ClotheReference>().CL = cloth;
        }
        
        
    }
}
