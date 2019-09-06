using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
	IDamageable iDamageable;

    private void Start()
    {
		iDamageable = (IDamageable)GetComponent(typeof(IDamageable));
		if (iDamageable == null)
		{
			throw new MissingComponentException("Requires an implementation of IDamageable");
		}
	}

    private void Update()
    {
        
    }

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Bullet")
		{
			iDamageable.TakeDamage(100);
		}
	}
}
