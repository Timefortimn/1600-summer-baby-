using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovePlayer : MonoBehaviour
{
    private CharacterController controller;
	private Vector3 newPosition;

	public bool IsGrounded;
    public float Speed = 10.0f;
    public float Gravity = 4.0f;
    public float JumpSpeed = 50.0f;

	void Start ()
    {
        controller = GetComponent<CharacterController>();
    }

	void OnCollisionStay()
	{
		IsGrounded = true;
	}
	
	void Update ()
	{
		float mouseXInput = Input.GetAxis("Mouse X");
		Vector3 lookhere = new Vector3(0,mouseXInput,0);
		transform.Rotate(lookhere);
	    
	    if (Input.GetKeyDown(KeyCode.Space)&& controller.isGrounded)
        {
            newPosition.y = JumpSpeed;
	        IsGrounded = false;
        }
		newPosition.y -= Gravity;
		newPosition.z = Speed * Input.GetAxis("Vertical");
		newPosition.x = Speed * Input.GetAxis("Horizontal");
		newPosition = transform.TransformDirection(newPosition);
        controller.Move(newPosition * Time.deltaTime);
	}
}
