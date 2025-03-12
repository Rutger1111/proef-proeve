using System;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public List<Node> nodes;

    public GameObject fullscreenButton;
    public GameObject WindowedButton;
    void Start()
    {
        updateSourceClip();
    }

    public void updateSourceClip()
    {
        for (int i = 0; i < nodes.Count; i++)
        {
            foreach (var sources in nodes[i].source)
            {
                sources.clip = nodes[i].clip;
                
                if (nodes[i].backgroundMusic == true)
                {
                    sources.Play();
                }
            }
            
        }
    }

    
    void Update()
    {
        for (int i = 0; i < nodes.Count; i++)
        {
            foreach (var sources in nodes[i].source)
            {
                sources.volume = nodes[i].volume;
                if(sources){
                    sources.volume = nodes[i].volume;
                }
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
        foreach (var sources in nodes[soundIndex].source)
        {
            sources.Play();
        }
       
    }

    public void StopSoundTrack(int soundIndex)
    {
        foreach (var sources in nodes[soundIndex].source)
        {
            sources.Stop();
        }
    }
}

[Serializable] public class Node
{
    [Range(0f, 1f)] public float volume;
    public AudioClip clip;

    public bool backgroundMusic;

    public List<AudioSource> source;
}
