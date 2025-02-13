using UnityEngine;

public class PopupTimer : MonoBehaviour
{
    float timer = 3;
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
}
