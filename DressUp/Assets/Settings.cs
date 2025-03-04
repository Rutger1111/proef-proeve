using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class Settings : MonoBehaviour
{
    public List<Node> nodes;
    

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
}

[Serializable] public class Node
{
    [Range(0f, 1f)] public float volume;
    public AudioClip clip;



    public AudioSource source;

    public UnityEvent unityEvent;
}
