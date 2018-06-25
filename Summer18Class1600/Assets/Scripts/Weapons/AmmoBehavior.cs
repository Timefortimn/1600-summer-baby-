using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBehavior : MonoBehaviour
{ 
    void OnTriggerEnter()
    {
        gameObject.SetActive(false);
    }
}
