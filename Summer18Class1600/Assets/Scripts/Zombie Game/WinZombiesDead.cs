using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinZombiesDead : MonoBehaviour
{

	public ZombieCount DeadZombies;

	void Start()
	{
		DeadZombies.DeadZombies = 0;
	}

	private void Update()
	{
		if (DeadZombies.DeadZombies >= 55)
		{
			Debug.Log(DeadZombies.DeadZombies);
			Debug.Log("The Zambies are dead bru");
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
