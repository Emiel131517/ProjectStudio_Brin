using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Put : MonoBehaviour
{
    // Heeft een animator component nodig.
    private Animator animator;
    // Heeft een particlesysyem nodig.
    private ParticleSystem particle;
    [SerializeField]
    private string animationName;
    void Start()
    {
        animator = GetComponent<Animator>();
        particle = GetComponentInChildren<ParticleSystem>();
    }

    void Update()
    {
        // Interactie met de speler terwijl hij de gieter vast heeft.
        // (if player.IsHolding(Gieter)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play(animationName);
            //Gieter.Fill();
        }
        // Interactie met de speler terwijl hij de coin vast heeft.
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            particle.Play();
        }
    }
}
