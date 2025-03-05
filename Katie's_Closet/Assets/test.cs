using UnityEngine;

public class test : MonoBehaviour
{
    public Settings settings;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N)) 
        {
            settings.PlaySoundTrack(1);
        }
    }
}
