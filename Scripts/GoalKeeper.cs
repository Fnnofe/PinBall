using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Paddle Ball striking function.
/// </summary>
public class GoalKeeper : MonoBehaviour
{
    HingeJoint2D hinge;
    [SerializeField]float strikeSpeed = 300;
    [SerializeField] bool isReversed = false;
    void Start()
    {
        hinge= GetComponent<HingeJoint2D>();
        if (isReversed==true)
        {
            strikeSpeed = strikeSpeed * -1;
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Strike(1);
        }
        if (Input.GetKeyUp(KeyCode.Space))Strike(-1);

    }
    public void Strike(int number)
    {
        var motor = hinge.motor;

        hinge.useMotor= true;
        motor.motorSpeed = number * strikeSpeed;
        hinge.motor= motor;

    }

}
