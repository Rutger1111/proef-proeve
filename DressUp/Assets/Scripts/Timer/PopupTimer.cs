using UnityEngine;

public class PopupTimer : MonoBehaviour
{
    public float timer = 3;
    public float resetTimer = 3;

    public GameObject displayModel;
    
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0){
            displayModel.SetActive(false);
        }
    }

    public void ResetTimer()
    {
        timer = resetTimer;
    }
}
