using System;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public List<Node> nodes;

    public GameObject fullscreenButton;
    public GameObject WindowedButton;
    void Start()
    {
        for (int i = 0; i < nodes.Count; i++)
        {

            if (nodes[i].backgroundMusic == true)
            {
                nodes[i].source.clip = nodes[i].clip;

                nodes[i].source.Play();
            }
        }
    }

    
    void Update()
    {
        for (int i = 0; i < nodes.Count; i++)
        {
            if(nodes[i].source){
                nodes[i].source.volume = nodes[i].volume;

            }
        }
    }
    public void toggleFullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        fullscreenButton.SetActive(false);
        WindowedButton.SetActive(true);
    }
    public void toggleWindowedScreen()
    {
        Screen.fullScreenMode = FullScreenMode.Windowed;
        fullscreenButton.SetActive(true);
        WindowedButton.SetActive(false);
    }

    public void PlaySoundTrack(int soundIndex)
    {
        if (soundIndex < 0 || soundIndex >= nodes.Count)
        {
            Debug.LogWarning("Invalid sound index!");
            return;
        }

        nodes[soundIndex].source.Play();
    }

    public void StopSoundTrack(int soundIndex)
    {
        if (soundIndex < 0 || soundIndex >= nodes.Count)
        {
            Debug.LogWarning("Invalid sound index!");
            return;
        }

        nodes[soundIndex].source.Stop();
    }
}

[Serializable] public class Node
{
    [Range(0f, 1f)] public float volume;
    public AudioClip clip;

    public bool backgroundMusic;

    public AudioSource source;
}
