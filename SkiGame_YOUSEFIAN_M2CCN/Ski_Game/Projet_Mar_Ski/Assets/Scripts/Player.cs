using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //Public Variable
    public float speedMove;
    public float speedRotate;
    public float forceJump;
    public Animator anim;

    //Private Varible
    private Rigidbody rb;
    private ConfigurableJoint cj;
    private ControllerGround controlGround;
    private float rotateY;
    //Private Method
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        cj = GetComponent<ConfigurableJoint>();
        controlGround = FindObjectOfType<ControllerGround>();
    }


    private void FixedUpdate()
    {
        MoveMent();
    }

    private void MoveMent()
    {
        Move();
        Rotate();
        if (Input.GetKey(KeyCode.Space) && controlGround.IsGround())
        {
            rb.AddForce(new Vector3(0, forceJump, 0));
            anim.SetBool("Crook", true);
        }
        else
        {
            //anim.SetBool("Crook", false);
        }

    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(rb.transform.forward * speedMove * 1.5f);
        }
    }

    private void Rotate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(rb.transform.right * speedRotate);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-rb.transform.right * speedRotate);
        }
        rotateY += Input.GetAxis("Horizontal");
        cj.targetRotation = Quaternion.Euler(0, -rotateY, 0);
    }
    //Public Method







    //Public Variable


    //Private Varible


    //Private Method


    //Public Method
}
