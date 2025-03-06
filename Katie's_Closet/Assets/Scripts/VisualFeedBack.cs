using UnityEngine;

public class VisualFeedBack : ICommand
{
    public override void Invoke()
    {
        gameObject.SetActive(true);
        GetComponent<PopupTimer>().timer = 1;
        GetComponent<TMPro.TMP_Text>().text = "You did not select all clothe types";
    }
}