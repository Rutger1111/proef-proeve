using UnityEngine;

public class InleverCount : MonoBehaviour
{
    public int count;

    [SerializeField] private TMPro.TMP_Text countText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = "ingeleverd: " + count.ToString();
    }
}
