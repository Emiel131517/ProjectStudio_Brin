using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalablePlant : MonoBehaviour
{
    private float time;
    private Vector3 startScale;
    private Vector3 endScale;
    private Vector3 vec3GrowSpeed;
    private bool isScaling;
    private bool isGrown;

    public float growSpeed;
    public float waterCount;
    protected void Start()
    {
        vec3GrowSpeed = new Vector3(growSpeed, growSpeed, growSpeed);

        time = 0;
        endScale = transform.localScale;
        startScale = transform.localScale / 100f;
        transform.localScale = startScale;

        isScaling = true;
        isGrown = false;
    }

    // Update is called once per frame
    protected void Update()
    {
        DrainWater();
        Grow();
    }
    private void DrainWater()
    {
        time += Time.deltaTime;
        if (time >= 1f && waterCount > 0)
        {
            waterCount -= 1;
            time = 0;
        }
    }
    private void Grow()
    {
        if (waterCount > 0 && isScaling)
        {
            transform.localScale += vec3GrowSpeed * Time.deltaTime;
            if (transform.localScale.x >= endScale.x ||
                transform.localScale.y >= endScale.y ||
                transform.localScale.z >= endScale.z)
            {
                isGrown = true;
                isScaling = false;
            }
        }
    }
    private void Harvest()
    {
        transform.localScale = startScale;
        isScaling = true;
        isGrown = false;
    }
}
