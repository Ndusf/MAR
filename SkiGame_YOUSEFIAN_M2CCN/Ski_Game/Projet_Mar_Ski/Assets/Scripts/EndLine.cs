using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLine : MonoBehaviour
{
    //Public Variable
    public GameObject panelButton;

    //Private Varible


    //Private Method


    //Public Method
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<SceneLoader>().ResetGame();
        }
    }
}
