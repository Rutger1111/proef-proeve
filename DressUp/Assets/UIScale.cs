using System.Collections.Generic;
using UnityEngine;

public class UIScale : MonoBehaviour
{
    public List<GameObject> list;
  
    public int index;
    

    public void ButttonSizeChanger(int indexButton)
    {
        index = indexButton;

        foreach (GameObject t in list)
        {
           
            if (indexButton == index)
            {
                list[indexButton].GetComponent<Transform>().localScale = new Vector3(2f, 2f, 2f);
            }
            else
            {
                t.GetComponent<Transform>().localScale = new Vector3(1f, 1f, 1f);
            }
            
        }
    }
}
