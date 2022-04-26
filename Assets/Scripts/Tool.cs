using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    [SerializeField]
    private List<ScalablePlant> plants;
    [SerializeField]
    private string tagName;
    [SerializeField]
    private string animName;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        plants = new List<ScalablePlant>();
    }
    void Update()
    {
        if (!plants.Contains(GameObject.FindWithTag(tagName).GetComponent<ScalablePlant>()))
        {
            plants.Add(GameObject.FindWithTag(tagName).GetComponent<ScalablePlant>());
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            //plants[i].Harvest();
            animator.Play(animName);
        }
    }
}
