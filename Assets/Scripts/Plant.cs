using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public float waterNeed;
    //private Renderer renderer;
    void Start()
    {
        //renderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float time = 0;
        time += Time.deltaTime;
        if (time >= 1)
        {
            waterNeed -= 1;
            time = 0;
        }
    }
}
