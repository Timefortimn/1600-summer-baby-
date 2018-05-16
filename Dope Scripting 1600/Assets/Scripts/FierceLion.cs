using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FierceLion : MonoBehaviour {

    public float Speed;
    public int PowerLevel;
    public string PlayerName;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, Speed, 0);
        transform.Translate(Speed, 0, 0);
    }
}
