using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TulpRood : Plant
{
    void Start()
    {
        waterNeed = 100;
        isScaling = true;
        growSpeed = new Vector3(5, 5, 5);
    }
    void Update()
    {
        Grow();
    }
}