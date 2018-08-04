using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

[CreateAssetMenu]
public class PartCollection : ScriptableObject {

    public List<PartPiece> Parts;
    public BulletData CurrentDamageLevel;

    public void CollectPart(PartPiece part)
    {
        Parts.Add(part);
        CurrentDamageLevel.Damage += part.DamageLevel;

        foreach (var item in Parts)
        {
            Debug.Log(item);
            Debug.Log(item.DamageLevel);
            
        }
    }
    
}
