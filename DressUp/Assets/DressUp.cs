using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;
using UnityEngine;
using System.Collections.Generic;
using System;

public class DressUp : MonoBehaviour
{

    public List<GameObject> im;
    
    public List<Sprite> mm;

    public List<menu> selectedButtons;

    public int index, CLIndex;
    
    public List<GameObject> buttonMenu;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void ClothesMenu(int clothesIndex)
    {
        CLIndex = clothesIndex;

        if (CLIndex == clothesIndex)
        {
            foreach (var turnOn in buttonMenu)
            {
                turnOn.SetActive(true);
            }
            
        }
    }
    
    
    public void ButtonClick(int buttonIndex)
    {
        index = buttonIndex;

        if (index == buttonIndex)
        {
            im[CLIndex].GetComponent<RawImage>().texture = selectedButtons[CLIndex].ClothesChose[index].texture;
        }
    }
}


[Serializable] public class menu
{
    public List<Sprite> ClothesChose;
}
