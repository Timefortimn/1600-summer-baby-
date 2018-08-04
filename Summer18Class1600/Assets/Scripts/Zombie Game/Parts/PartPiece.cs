using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PartPiece : ScriptableObject {

	public int DamageLevel = 20;

	public float DoDamage()
	{
		return DamageLevel;
	}
}
