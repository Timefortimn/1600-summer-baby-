using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.UIElements;
using UnityEngine.Networking;

public class MovePlayer : NetworkBehaviour
{
	private CharacterController controller;
	private Vector3 newPosition;

	public bool IsGrounded;
	public float Speed = 10.0f;
	public float Gravity = 4.0f;
	public float JumpSpeed = 50.0f;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	public override void OnStartLocalPlayer()
	{
		GetComponent<MeshRenderer>().material.color = Color.green;
	}

	void OnCollisionStay()
	{
		IsGrounded = true;
	}

	void Update()
	{
		if (!isLocalPlayer)
		{
			return;
		}

		float mouseXInput = Input.GetAxis("Mouse X");
		Vector3 lookhere = new Vector3(0, mouseXInput, 0);
		transform.Rotate(lookhere);

		if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
		{
			newPosition.y = JumpSpeed;
			IsGrounded = false;
		}

		newPosition.y -= Gravity;
		newPosition.z = Speed * Input.GetAxis("Vertical");
		newPosition.x = Speed * Input.GetAxis("Horizontal");
		newPosition = transform.TransformDirection(newPosition);
		controller.Move(newPosition * Time.deltaTime);

		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			CmdFire();
		}
	}

	[Command]
	void CmdFire()
	{
		var bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
		
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;
		
		NetworkServer.Spawn(bullet);
		
		Destroy(bullet, 2.0f);
	}
}
