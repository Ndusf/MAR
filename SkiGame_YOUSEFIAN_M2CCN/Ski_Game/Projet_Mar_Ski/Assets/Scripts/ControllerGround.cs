using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGround : MonoBehaviour
{
    //Public Variable
    public Animator anim;
    private bool isground;
    

    //Private Varible


    //Private Method
    private void OnCollisionEnter(Collision collision)
    {
        isground = true;
        anim.SetBool("Crook", false);
    }
    private void OnCollisionExit(Collision collision)
    {
        isground = false;
       
    }
    //Public Method
    public bool IsGround()
    {
        return isground;
    }
}
