using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScale : MonoBehaviour
{
    public List<GameObject> list;
    public Sprite sprite;
  
    public int index;

    private void Start()
    {
        for (int i = 0; i < list.Count; i++)
        {
               list[i].GetComponent<Image>().color = new Color(1, 1, 1, 0f);
        }
    }
    public void ButttonSizeChanger(int indexButton)
    {
        index = indexButton;

        for (int i = 0; i < list.Count; i++)
        {
            if (i == indexButton)
            {
                list[i].GetComponent<Image>().sprite = sprite;
                list[i].GetComponent<Image>().color = new Color(1, 1, 1, 1);
            }
            else if (i != indexButton)
            {
                list[i].GetComponent<Image>().color = new Color(1, 1, 1, 0f);
            }
        }
    }
}
