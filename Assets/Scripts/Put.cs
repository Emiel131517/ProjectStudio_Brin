using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Put : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private ParticleSystem particle;
    void Start()
    {
        animator = GetComponent<Animator>();
        particle = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        // Interactie met de speler terwijl hij de gieter vast heeft.
        // if (player.holdingItem == typeof Gieter)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("Hendel|CircleAction");
            //Gieter.Fill();
        }
        // Interactie met de speler terwijl hij de coin vast heeft.
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            particle.Play();
        }
    }
}
