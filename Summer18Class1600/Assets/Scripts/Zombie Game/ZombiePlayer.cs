using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.UIElements;
using UnityEngine.Networking;

public class ZombiePlayer : MonoBehaviour
{
	private CharacterController controller;
	private Vector3 newPosition;

	public bool IsGrounded;
	public float Speed = 10.0f;
	public float Gravity = 4.0f;
	public float JumpSpeed = 50.0f;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public AudioSource JumpSound;
	public AudioSource FireSound;

	void Start()
	{
		controller = GetComponent<CharacterController>();
		JumpSound = GetComponent<AudioSource>();
	}

	void OnCollisionStay()
	{
		IsGrounded = true;
	}

	void Update()
	{

		float mouseXInput = Input.GetAxis("Mouse X");
		Vector3 lookhere = new Vector3(0, mouseXInput, 0);
		transform.Rotate(lookhere);

		if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
		{
			JumpSound.Play();
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
			Fire();
		}
	}

	void Fire()
	{
		FireSound.Play();
		var bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
		
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;
		
		Destroy(bullet, 2.0f);
	}
}
