using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TulpGeel : Plant
{
    void Start()
    {
        waterNeed = 100;
        isScaling = true;
        growSpeed = new Vector3(10, 10, 10);
    }
    void Update()
    {
        Grow();
    }
}
