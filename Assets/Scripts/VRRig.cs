using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VRMap
{
    public Transform vrTarget;
    public Transform rigTarget;
    public Vector3 trackingPositionOffset;
    public Vector3 trackingRotationOffset;

    public void Map(bool isHead)
    {
        rigTarget.position = vrTarget.TransformPoint(trackingPositionOffset);
        rigTarget.rotation = vrTarget.rotation * Quaternion.Euler(trackingRotationOffset);
    }


}

public class VRRig : MonoBehaviour
{
    public VRMap head;
    public VRMap leftHand;
    public VRMap rightHand;
    
    public Transform headContraints; 
    public Vector3 headBodyOffest;

    public float smoomthness;

    private void Awake()
    {
        headBodyOffest = transform.position - headContraints.position;
    }

    private void FixedUpdate()
    {
        transform.position = headContraints.position + headBodyOffest;
        transform.forward = Vector3.Lerp(transform.forward,
            Vector3.ProjectOnPlane(headContraints.up, Vector3.up).normalized, Time.deltaTime * smoomthness);

        head.Map(true);
        leftHand.Map(true);
        rightHand.Map(false);
    }
}
