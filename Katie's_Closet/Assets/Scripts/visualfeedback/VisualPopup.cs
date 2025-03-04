using UnityEngine;

public class VisualPopup : ICommand
{
    public override void Invoke()
    {
        gameObject.SetActive(true);
        GetComponent<PopupTimer>().timer = 1;
    }
}
