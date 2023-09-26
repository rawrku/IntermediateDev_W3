using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHead : MonoBehaviour
{
    public float speed = 3;

    private HingeJoint2D mouth;


    // Start is called before the first frame update
    void Start()
    {

        mouth = GetComponent<HingeJoint2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            mouth.useMotor = true;
            JointMotor2D newMotor = mouth.motor;
            newMotor.motorSpeed = -speed;

            mouth.motor = newMotor;

        } else if (Input.GetKeyUp(KeyCode.D))
        {
            mouth.useMotor = false;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            mouth.useMotor = true;
            JointMotor2D newMotor = mouth.motor;
            newMotor.motorSpeed = speed;

            mouth.motor = newMotor;
        } else if (Input.GetKeyUp(KeyCode.A))
        {
            mouth.useMotor = false;
        }
    }
}
