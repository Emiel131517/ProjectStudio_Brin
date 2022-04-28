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

    public bool isGrown;
    public float growSpeed;
    public float waterCount;
    private void Start()
    {
        vec3GrowSpeed = new Vector3(growSpeed, growSpeed, growSpeed);

        time = 0;
        // endScale is de grootte van heb object normaal.
        endScale = transform.localScale;
        // startScale is een procent van de endScale.
        startScale = transform.localScale / 100f;
        // zet de scale van het object naar de startScale.
        transform.localScale = startScale;

        isGrown = false;
        isScaling = true;
    }

    private void Update()
    {
        DrainWater();
        Grow();
    }
    private void DrainWater()
    {
        // Iedere seconde gaat waterCount met een omlaag.
        time += Time.deltaTime;
        if (time >= 1f && waterCount > 0)
        {
            waterCount -= 1;
            time = 0;
        }
    }
    private void Grow()
    {
        // Als de plant nog water heeft ga dan groeien.
        if (waterCount > 0 && isScaling)
        {
            transform.localScale += vec3GrowSpeed * Time.deltaTime;
            if (transform.localScale.x >= endScale.x ||
                transform.localScale.y >= endScale.y ||
                transform.localScale.z >= endScale.z)
            {
                isScaling = false;
                isGrown = true;
            }
        }
    }
    // Reset de scale en begin weer met groeien.
    public void Harvest()
    {
        transform.localScale = startScale;
        isScaling = true;
        isGrown = false;
    }
}
