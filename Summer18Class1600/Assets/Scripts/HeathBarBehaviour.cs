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
	}

	void Update()
	{
		HealthImage.fillAmount = HealthLevel.Value;
		if (HealthImage.fillAmount < 0.5)
		{
			HealthImage.color = Color.yellow;
		}
		else
		{
			HealthImage.color = Color.green;
		}

		if (HealthImage.fillAmount < 0.25)
		{
			HealthImage.color = Color.red;
		}
	}
}
