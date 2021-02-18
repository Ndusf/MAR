using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //Public Variable


    //Private Varible
    private UiManager uiManager;

    //Private Method
    private void Start()
    {
        uiManager = FindObjectOfType<UiManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            uiManager.GetObstacle();
        }
    }

    //Public Method
}
