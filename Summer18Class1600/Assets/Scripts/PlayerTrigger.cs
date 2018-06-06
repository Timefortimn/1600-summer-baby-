using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{

    public FloatData HealthLevel;
    public FloatData EvilPower;

    void Start()
    {

    }

    void OnTriggerEnter()
    {
        HealthLevel.Value -= EvilPower.Value;
    }
}
