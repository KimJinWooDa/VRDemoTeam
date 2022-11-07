using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRAnimationController : MonoBehaviour
{
    public float speedTreshold = 0.1f;
    private Animator _animator;
    private Vector3 previousPos;
    private VRRig _vrRig;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _vrRig = GetComponent<VRRig>();

        //previousPos = _vrRig.head.vrTarget.position;
        previousPos = transform.position;
    }

    private void Update()
    {
        //Compute the Speed
        // Vector3 headSetSpeed = (_vrRig.head.vrTarget.position - previousPos) / Time.deltaTime;
        // headSetSpeed.y = 0;
        //
        // //Local Speed
        // Vector3 headSetLocalSpeed = transform.InverseTransformDirection(headSetSpeed);
        // previousPos = _vrRig.head.vrTarget.position;
        //
        // //Set Animator Values
        // _animator.SetBool("isMoving", headSetLocalSpeed.magnitude > speedTreshold);
        //

    }
}
