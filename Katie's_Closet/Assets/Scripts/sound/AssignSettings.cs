using UnityEngine;
using UnityEngine.UI;
public class AssignSettings : MonoBehaviour
{
    public int soundIndex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //GameObject.Find("EventSystem").GetComponent<Settings>().nodes[soundIndex].source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UseSound(){
        //GameObject.Find("EventSystem").GetComponent<SoundManager>().nodes[soundIndex].source.Add(GetComponent<AudioSource>());
        GameObject.Find("EventSystem").GetComponent<SoundManager>().PlaySoundTrack(soundIndex);
    }
}
