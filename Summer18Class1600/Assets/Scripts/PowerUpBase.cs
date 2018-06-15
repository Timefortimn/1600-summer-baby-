using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class PowerUpBase : ScriptableObject
{
    public FloatData Health;

    public float PowerLevel = 0.25f;

    public void RunPowerUp()
    {
        Health.Value = PowerLevel;
    }
}
