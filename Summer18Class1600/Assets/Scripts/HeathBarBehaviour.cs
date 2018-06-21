using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HeathBarBehaviour : MonoBehaviour
{
	public FloatData HealthLevel;
	private Image HealthImage;

	void Start()
	{
		HealthImage = GetComponent<Image>();
		HealthLevel.Value = 1.0f;
	}

	void Update()
	{
		HealthImage.fillAmount = HealthLevel.Value;
		if (HealthImage.fillAmount < 0.51)
		{
			HealthImage.color = Color.yellow;
		}
		else
		{
			HealthImage.color = Color.green;
		}

		if (HealthImage.fillAmount < 0.26)
		{
			HealthImage.color = Color.red;
		}
	}
}
