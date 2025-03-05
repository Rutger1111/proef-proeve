using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class Settings : MonoBehaviour
{
    public List<Node> nodes;

    public GameObject fullscreenButton;
    public GameObject WindowedButton;
    void Start()
    {
        for (int i = 0; i < nodes.Count; i++)
        {
            nodes[i].source.clip = nodes[i].clip;

            nodes[i].source.Play();
        }
    }

    
    void Update()
    {
        for (int i = 0; i < nodes.Count; i++)
        {
            nodes[i].source.volume = nodes[i].volume;
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

    public void toggleSound(int soundIndex)
    {
        nodes[soundIndex].source.Play();
    }
}

[Serializable] public class Node
{
    [Range(0f, 1f)] public float volume;
    public AudioClip clip;



    public AudioSource source;

    public UnityEvent unityEvent;
}
