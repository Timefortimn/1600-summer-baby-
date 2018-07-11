using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AISpawner : MonoBehaviour
{
	public GameObject AI;
	public Transform Destination;
	public Level CurrentLevel;
	private int aiCount;
	
	private void Start ()
	{
		aiCount = CurrentLevel.AICount;
		StartCoroutine(StartSpawn());
	}

	private IEnumerator StartSpawn()
	{
		while (aiCount > 0)
		{
			GameObject newAI = Instantiate(AI);
			newAI.GetComponent<AIMovement>().Destination = Destination;
			aiCount--;
			
			yield return new WaitForSeconds(CurrentLevel.AICount);
		}
	}

}
