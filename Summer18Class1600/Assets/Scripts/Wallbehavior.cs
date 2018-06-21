using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallbehavior : MonoBehaviour
{

	public WallData WallPower;
	public FloatData Health;

	void Update()
	{
		if (Health.Value < 0.51)
		{
			transform.position = new Vector3(Mathf.PingPong(Time.time * WallPower.Speed * 2, 8), transform.position.y, transform.position.z);
		}
		else
		{
			transform.position = new Vector3(Mathf.PingPong(Time.time * WallPower.Speed, 8), transform.position.y, transform.position.z);
		}
	}
}
