using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

    //Public Variable
    public Transform[] target;

    //Private Varible
    private Rigidbody rb;
    private Quaternion rotation;
    private int index;
    private bool isCan;
    //Private Method
    private void Start()
    {
        isCan = true;
        rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        Physics.IgnoreLayerCollision(9, 10);
        if (index <= target.Length-1)
        {
            if (target[index].eulerAngles.y > 0)
            {
                rotation = Quaternion.Euler(0, -target[index].eulerAngles.y, 0);
            }
            else if (target[index].eulerAngles.y <= 0)
            {
                rotation = Quaternion.Euler(0, target[index].eulerAngles.y, 0);
            }


            rb.AddForce(target[index].transform.forward * 150);
            GetComponent<ConfigurableJoint>().targetRotation = rotation;
        }

        
    }
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Target")
        {
            
            
            if (index <= target.Length - 1&& isCan)
            {
                
                index++;
                isCan = false;
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        isCan = true;
    }
    //Public Method
}
