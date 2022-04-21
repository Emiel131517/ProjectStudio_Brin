using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tulp : Plant
{
    private Vector3 startScale;
    private Vector3 endScale;
    public Vector3 growSpeed;
    public bool isScaling;

    void Start()
    {
        waterNeed = 100;

        isScaling = true;
        growSpeed = new Vector3(10, 10, 10);

        endScale = transform.localScale;
        startScale = transform.localScale / 100;
        transform.localScale = startScale;
    }
    void Update()
    {
        if (waterNeed > 0 && isScaling)
        {
            transform.localScale += growSpeed * Time.deltaTime;
            if (transform.localScale.x >= endScale.x)
            {
                isScaling = false;
            }
        }
    }
}
