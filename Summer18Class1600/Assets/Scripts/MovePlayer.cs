using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 newPosition;

    public float Speed = 10.0f;
    public float Gravity = 6.0f;
    public float JumpSpeed = 50.0f;

	void Start ()
    {
        controller = GetComponent<CharacterController>();
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            newPosition.y = JumpSpeed;
        }

        newPosition.x = Speed * Input.GetAxis("Horizontal");
        newPosition.z = Speed * Input.GetAxis("Vertical");
        newPosition.y -= Gravity;
        controller.Move(newPosition * Time.deltaTime);
	}
}
