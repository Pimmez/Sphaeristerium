using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	[SerializeField] int damage;

	private void OnTriggerEnter(Collider other)
	{
		IDamageable iDamageable = (IDamageable)other.gameObject.GetComponent(typeof(IDamageable));
		if (iDamageable != null)
		{
			iDamageable.TakeDamage(damage);
		}
	}
}