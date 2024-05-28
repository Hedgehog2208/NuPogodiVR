using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
	[SerializeField] private Transform left;
	[SerializeField] private Transform right;
    public MoveScript moveScript;
    private float moveSpeed;
	private float timer = 1;

	public void MoveLever()
    {

    }

    public void MoveWolf()
    {
		Debug.Log(transform.eulerAngles);

        if (transform.eulerAngles.z >= 330 && transform.eulerAngles.z < 360)
        {
            moveScript.SetVector(new Vector3(1, 0, 0), right);

			if (transform.eulerAngles.z >= 350)
			{
				moveScript.SetMoveSpeed(2);
			}
			if (transform.eulerAngles.z <= 350 && transform.eulerAngles.z > 340)
			{
				moveScript.SetMoveSpeed(4);
			}
			if (transform.eulerAngles.z <= 340 && transform.eulerAngles.z >= 325)
			{
				moveScript.SetMoveSpeed(6);
			}
		}
        if (transform.eulerAngles.z <= 35 && transform.eulerAngles.z > 0) 
        {
            moveScript.SetVector(new Vector3(-1, 0, 0), left);

			if (transform.eulerAngles.z <= 10)
			{
				moveScript.SetMoveSpeed(2);
			}
			if (transform.eulerAngles.z > 10 && transform.eulerAngles.z <= 20)
			{
				moveScript.SetMoveSpeed(4);
			}
			if (transform.eulerAngles.z > 20 && transform.eulerAngles.z <= 35)
			{
				moveScript.SetMoveSpeed(6);
			}
		}
    }

    //Vector3(0,0,59.3709564)

    public void Timer()
	{
		timer -= Time.deltaTime;
		if (timer <= 0)
		{
			timer = 1;
			MoveWolf();
		}
	}
}
