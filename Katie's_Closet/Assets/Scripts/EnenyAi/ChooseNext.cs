
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChooseNext : ICommand
{
    public Wardrobe wardrobe;
    public int index = 0;
    public ClotheReference clothe;
    public List<RawImage> images = new List<RawImage>();
    void Start()
    {
        for (int i = 0; i < wardrobe.clothesTextures[index].textures.Count; i++)
        {
            images[i].texture = wardrobe.clothesTextures[index].textures[i];
        }
            
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
                for (int i = 0; i < wardrobe.clothesTextures[index].textures.Count; i++)
                {
                    images[i].texture = wardrobe.clothesTextures[index].textures[i];
                }
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
                for (int i = 0; i < wardrobe.clothesTextures[index].textures.Count; i++)
                {
                    images[i].texture = wardrobe.clothesTextures[index].textures[i];
                }
            }            
        }
        else{
            for (int i = 0; i < wardrobe.clothesTextures[index].textures.Count; i++)
            {
                images[i].texture = wardrobe.clothesTextures[index].textures[i];
            }
        }
        
    }
}
