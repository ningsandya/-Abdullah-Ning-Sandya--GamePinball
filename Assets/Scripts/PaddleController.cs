using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;

    private float targetPressed;
    private float targetReleased;
    private HingeJoint hinge;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();

        targetPressed = hinge.limits.max;
        targetReleased = hinge.limits.min;
    }

    void Update()
    {
        ReadInput();
        
    }

    private void ReadInput()
    {
        JointSpring joinSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            joinSpring.targetPosition = targetPressed;
        }

        else
        {
            joinSpring.targetPosition = targetReleased;
        }

        hinge.spring = joinSpring;
    }
}
