using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    //Public Variable

    public Transform target;
  
    //Private Varible

    private void LateUpdate()
    {
        if (target)
        {
            
            transform.position = new Vector3(target.position.x,target.position.y+10,target.position.z-15);
        }
       
    }

    //Public Method

}
