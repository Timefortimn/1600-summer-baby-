using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {

	public GameObject ZombiePrefab;
	public GameObject SpawnLocation;
	public Transform TargetPlayer;
	public int numberOfEnemies;

	public void Start()
	{
		StartCoroutine(SpawnEnemy());
	}

	private IEnumerator SpawnEnemy()
	{
		while (numberOfEnemies > 0)
		{
			for (int i = 0; i < numberOfEnemies; i++)
			{
				var spawnPosition = SpawnLocation.transform.position +
				                    new Vector3(Random.Range(-8.0f, 8.0f), 0.0f, Random.Range(-8.0f, 8.0f));
				var spawnRotation = Quaternion.Euler(0.0f, Random.Range(0, 180), 0.0f);
				GameObject newZombie = Instantiate(ZombiePrefab, spawnPosition, spawnRotation);
				newZombie.GetComponent<AIMovement>().Destination = TargetPlayer;
			}

			numberOfEnemies--;
            
			yield return new WaitForSeconds(20);
		}
        
	}
}
