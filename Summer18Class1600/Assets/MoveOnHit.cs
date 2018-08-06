using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class MoveOnHit : MonoBehaviour
{

	private Animator anims;

	private void Start()
	{
		anims = GetComponent<Animator>();
	}

	public void CameraMove()
	{
		anims.SetTrigger("Hit");
	}
}
