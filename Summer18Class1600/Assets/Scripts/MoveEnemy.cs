using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Networking;

[RequireComponent(typeof(NavMeshAgent))]

public class MoveEnemy : NetworkBehaviour
{
	private NavMeshAgent Agent;
	public Transform TargetPlayer;
	
	public override void OnStartServer()
	{
		Agent = GetComponent<NavMeshAgent>();
	}

	void Update () {
		
	}
}
