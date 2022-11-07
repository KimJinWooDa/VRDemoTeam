using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadLock : MonoBehaviour
{
    public int needBreakCount = 3;

    private void Update()
    {
        if (needBreakCount <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
