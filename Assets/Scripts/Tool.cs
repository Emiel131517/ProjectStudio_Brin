using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    [SerializeField]
    private string tagName;
    [SerializeField]
    private string animName;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tagName)
        {
            ScalablePlant plant = other.GetComponent<ScalablePlant>();
            if (plant.isGrown)
            {
                plant.Harvest();
                //animator.Play(animName);
            }
        }
    }
}
