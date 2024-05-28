using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator animator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isWalk", true);
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            animator.SetBool("isWalk", false);
        }
    }
}
