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

	private void Start ()
	{
		Agent = GetComponent<NavMeshAgent>();
	}
	
	private void Update () 
	{
		Agent.destination = Destination.position;
		
	}
}
