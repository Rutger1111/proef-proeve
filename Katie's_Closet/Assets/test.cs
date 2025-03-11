using UnityEngine;
using UnityEngine.Serialization;

public class test : MonoBehaviour
{
    [FormerlySerializedAs("settings")] public SoundManager soundManager;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N)) 
        {
            soundManager.PlaySoundTrack(1, 0);
        }
    }
}
