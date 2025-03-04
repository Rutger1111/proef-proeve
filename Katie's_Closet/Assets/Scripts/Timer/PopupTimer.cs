using UnityEngine;

public class PopupTimer : MonoBehaviour
{
    public float timer = 3;
    public float resetTimer = 3;
    [SerializeField] private TMPro.TMP_Text popupTimerText;
    public GameObject displayModel;
    
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0){
            displayModel.SetActive(false);
        }
        else{
            if (timer >= 1){
                popupTimerText.text = timer.ToString("F0");
            }
            else{
                popupTimerText.text = timer.ToString("F1");
            }
        }
    }

    public void ResetTimer()
    {
        timer = resetTimer;
    }
}
