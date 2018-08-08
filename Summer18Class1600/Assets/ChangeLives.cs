using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeLives : MonoBehaviour
{
	public Text Lives;
	public int l = 2;

	void Update ()
	{
		Lives.text = l.ToString();
	}

	public void LoseLife()
	{
		l--;
		if (l <= 0)
		{
			Debug.Log("Game Over");
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
