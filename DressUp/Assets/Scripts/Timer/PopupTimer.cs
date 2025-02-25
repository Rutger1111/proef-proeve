using UnityEngine;

public class PopupTimer : MonoBehaviour
{
    public float timer = 3;
    public float resetTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0){
            gameObject.SetActive(false);
        }
    }

    public void ResetTimer()
    {
        timer = resetTimer;
    }
}
