using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartPickUp : MonoBehaviour {

	public PartPiece Part;
	public PartCollection Collection;

	private void OnTriggerEnter(Collider obj)
	{
			Collection.CollectPart(Part);
			Destroy(gameObject);
	}
}
