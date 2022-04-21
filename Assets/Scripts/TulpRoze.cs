using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TulpRoze : Plant
{
    void Start()
    {
        waterNeed = 100;
        isScaling = true;
        growSpeed = new Vector3(7.5f, 7.5f, 7.5f);
    }
    void Update()
    {
        Grow();
    }
}