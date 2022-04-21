using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    private Vector3 startScale;
    private Vector3 endScale;
    public Vector3 growSpeed;
    public bool isScaling;
    public float waterNeed;
    public bool isGrown;
    //private Renderer renderer;
    void Start()
    {
        endScale = transform.localScale;
        startScale = transform.localScale / 100;
        transform.localScale = startScale;
        isGrown = false;
        //renderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        DrainWater();
    }
    void DrainWater()
    {
        float time = 0;
        time += Time.deltaTime;
        if (time >= 1)
        {
            waterNeed -= 1;
            time = 0;
        }
    }
    protected void Grow()
    {
        if (waterNeed > 0 && isScaling)
        {
            transform.localScale += growSpeed * Time.deltaTime;
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
