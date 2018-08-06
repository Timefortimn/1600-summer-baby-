using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Networking;

[RequireComponent(typeof(NavMeshAgent))]

public class AIMovement : MonoBehaviour
{
	private NavMeshAgent Agent;
	public Transform Destination;
	public AIControl Control;

	private void Start ()
	{
		Agent = GetComponent<NavMeshAgent>();
		Control.ConfigAI(Agent);
	}
	
	private void Update () 
	{
		Agent.destination = Destination.position;
		
	}

	private void OnCollisionEnter(Collision collision)
	{
		var hit = collision.gameObject;
		var health = hit.GetComponent<ZombiePlayerHealth>();
		var camera = hit.GetComponentInChildren<MoveOnHit>();
		if (health != null)
		{
			health.TakeDamage(10);
			camera.CameraMove();
		}
	}
}
