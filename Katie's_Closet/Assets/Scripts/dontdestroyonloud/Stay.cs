using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Stay : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
