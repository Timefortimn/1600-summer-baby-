using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAmmo : MonoBehaviour
{
    public List<GameObject> Ammo;

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
	        for (int i = 0; i < Ammo.Count; i++)
	        {
		        Ammo[i].SetActive(true);
	        }
        }
	}
}
