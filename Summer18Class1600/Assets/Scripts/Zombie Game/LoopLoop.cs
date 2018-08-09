using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopLoop : MonoBehaviour
{
    int numEnemies = 3;
    int Zombies = 4;


    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }

        while (Zombies > 0)
        {
            Debug.Log("Fight! Get 'em!");
            Zombies--;
        }
        string[] strings = new string[3];
        
        strings[0] = "You're";
        strings[1] = "Doing";
        strings[2] = "So Great!";
        
        foreach(string item in strings)
        {
            print (item);
        }
    }
}
