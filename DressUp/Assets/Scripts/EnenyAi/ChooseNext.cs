
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChooseNext : ICommand
{
    public Wardrobe wardrobe;
    public RawImage cloth;
    public int index = 0;
    public ClotheReference clothe;
    void Start()
    {
        cloth.texture = wardrobe.clothesTextures[index].texture;    
    }
    public override void Invoke(){
        if( clothe.CL.Id != index){
            if(Random.Range(0,10) >=  4){
                if (index - clothe.CL.Id <= 0){
                    print("--");
                    index -= 1;
                    if (index < 0){
                        index = wardrobe.clothesTextures.Count -1;
                    }

                }
                else{
                    print("--");

                    index += 1;

                    if (index > wardrobe.clothesTextures.Count -1 ){
                        index = 0;
                    }
                }
                cloth.texture = wardrobe.clothesTextures[index].texture;
            }
            else{            
                if (index - clothe.CL.Id >= 0){
                    print("--");
                    index -= 1;
                    if (index < 0){
                        index = wardrobe.clothesTextures.Count -1;
                    }

                }
                else{
                    print("--");
                    index += 1;

                    if (index > wardrobe.clothesTextures.Count -1){
                        index = wardrobe.clothesTextures.Count -1;
                    }

                }
                cloth.texture = wardrobe.clothesTextures[index].texture;
            }            
        }
        else{
            cloth.texture = wardrobe.clothesTextures[index].texture;
        }
        
    }
}
