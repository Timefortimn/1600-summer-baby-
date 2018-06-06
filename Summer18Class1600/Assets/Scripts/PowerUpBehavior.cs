using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour
{
    public PowerUpBase PowerUp;
    public Animal AnimalInfo;

    void OnTriggerEnter()
    {
        PowerUp.RunPowerUp();
        print(AnimalInfo.Health);
        gameObject.SetActive(false);
    }
}
