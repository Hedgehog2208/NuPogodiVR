using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverNullRotation : MonoBehaviour
{
    [SerializeField] private Vector3 vector;
    private Rigidbody rb;
    public void NullPosition()
    {
        //rb = GetComponent<Rigidbody>();
        //rb.AddForce(new Vector3(1,1,1) * 1000);
        transform.position = Vector3.MoveTowards(transform.position, vector, 1);
    }
}
