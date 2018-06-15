using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour
{
    public PowerUpBase PowerUp;
    public FloatData Health;

    void OnTriggerEnter()
    {
        PowerUp.RunPowerUp();
        print(Health.Value);
        gameObject.SetActive(false);
    }
}
