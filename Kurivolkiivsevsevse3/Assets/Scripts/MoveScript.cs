using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveScript : MonoBehaviour
{
    [SerializeField] private CharacterController controller;

    public float moveSpeed;
    private Vector3 vector;
    private Transform transformLook;
    public Lever lever;

    private void Update()
    {
        Move();
        Rotate();
        Gravity();
        lever.MoveWolf();
    }

    private void Rotate()
    {
        controller.transform.LookAt(transformLook);
    }

    public void Move()
    {
        controller.Move(vector * Time.deltaTime * moveSpeed);
    }

    private void Gravity()
    {
        controller.Move(new Vector3(0, -9.3f, 0));
    }

    public void SetVector(Vector3 vector, Transform transform)
    {
        this.transformLook = transform;
        this.vector = vector;
    }

    public void SetMoveSpeed(float speed)
    {
        moveSpeed = speed;
    }
}
