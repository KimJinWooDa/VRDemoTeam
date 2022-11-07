using System;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public Transform handPos;

    public void Init()
    {
            
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("LOCK"))
        {
            collision.collider.GetComponent<PadLock>().needBreakCount--;
        }
    }

}

