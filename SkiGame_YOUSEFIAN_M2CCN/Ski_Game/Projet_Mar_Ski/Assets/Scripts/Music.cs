using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    //Private Method
    private void Awake()
    {
        int lenth = FindObjectsOfType<Music>().Length;
        if (lenth > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        
    }
}
