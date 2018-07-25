using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public BulletData DamageLevel;
	
	private void OnCollisionEnter(Collision collision)
	{
		var hit = collision.gameObject;
		var health = hit.GetComponent<ZombiePlayerHealth>();
		if (health != null)
		{
			health.TakeDamage(DamageLevel.Damage);
		}
		Destroy(gameObject);
	}
}
