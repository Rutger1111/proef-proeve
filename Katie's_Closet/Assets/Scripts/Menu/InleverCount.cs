using UnityEngine;

public class InleverCount : MonoBehaviour
{
    public int count;

    [SerializeField] private TMPro.TMP_Text countText;
    void Update()
    {
        countText.text = "ingeleverd: " + count.ToString();
    }
}
