using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour {
    public float speed = 1500;
    public float boostSpeed = 3500;
    public float JumpSpeed = 10;
    public float rotationSpeed = 15f;

    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;

    Rigidbody2D RigidBody2D;

    JointMotor2D motor;

    private float movement = 0f;
    private bool Boost;
    private float rotation = 0f;
    // Use this for initialization
    void Start () {
        motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };

    }

    // Update is called once per frame
    void Update () {
        movement = Input.GetAxisRaw("Vertical");
        Boost = Input.GetButton("Boost");
        rotation = Input.GetAxisRaw("Horizontal");



        float Jump = Input.GetAxisRaw("Jump");

        transform.position += new Vector3(0, Jump, 0) * Time.deltaTime * JumpSpeed;

        



        if (Boost)
        {
            motor.motorSpeed = boostSpeed * movement;
        }
        else
        {
            motor.motorSpeed = speed * movement;
        }

        



    }
    void FixedUpdate()
    {
        if (movement == 0f)
        {
            backWheel.useMotor = false;
            frontWheel.useMotor = false;
        }
       
        else
        {
            backWheel.useMotor = true;
            frontWheel.useMotor = true;

            backWheel.motor = motor;
            frontWheel.motor = motor;
        }

    }
   
    
}
