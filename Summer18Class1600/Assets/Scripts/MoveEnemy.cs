using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Networking;

[RequireComponent(typeof(NavMeshAgent))]

public class MoveEnemy : NetworkBehaviour
{
	public NavMeshAgent Agent;
	public Transform TargetPlayer;
	public AIControl Control;

	private void Start ()
	{
		Agent = GetComponent<NavMeshAgent>();
		Control.ConfigAI(Agent);
	}
	
	private void Update () 
	{
		Agent.destination = TargetPlayer.position;
		
	}
	
}
