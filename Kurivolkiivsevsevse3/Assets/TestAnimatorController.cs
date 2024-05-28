using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestAnimatorController : MonoBehaviour
{
    public Animator animator;
    public List<Rigidbody> rigidbodies;

    private void Start()
    {
        rigidbodies.AddRange(GetComponentsInChildren<Rigidbody>());
        DeactivateRagdoll();
    }

    private void ActivateRagdoll()
    {
        animator.enabled = false;

        foreach(var rb in rigidbodies)
        {
            rb.isKinematic = false;
        }
    }

    private void DeactivateRagdoll()
    {
        animator.enabled = true;

        foreach (var rb in rigidbodies)
        {
            rb.isKinematic = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ActivateRagdoll();
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            DeactivateRagdoll();
        }
    }
}
