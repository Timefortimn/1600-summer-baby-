using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parts : MonoBehaviour
{

	public enum PartType
	{
		Fmj,
		Clip,
		Scope,
		Silencer,
		SemiAuto
	}

	public PartPiece[] PartPieces;

	public PartType CurrentPart;

	void Update()
	{
		switch (CurrentPart)
		{
			case PartType.Fmj:
				Debug.Log(PartPieces[0].name);
				Debug.Log(PartPieces[0].DoDamage());
				break;
			case PartType.Clip:
				Debug.Log(PartPieces[1].name);
				Debug.Log(PartPieces[1].DoDamage());
				break;
			case PartType.Scope:
				Debug.Log(PartPieces[2].name);
				Debug.Log(PartPieces[2].DoDamage());
				break;
			case PartType.Silencer:
				Debug.Log(PartPieces[3].name);
				Debug.Log(PartPieces[3].DoDamage());
				break;
			case PartType.SemiAuto:
				Debug.Log(PartPieces[4].name);
				Debug.Log(PartPieces[4].DoDamage());
				break;

		}
	}
}