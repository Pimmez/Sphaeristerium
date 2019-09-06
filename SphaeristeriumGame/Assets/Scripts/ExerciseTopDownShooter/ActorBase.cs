using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActorBase : MonoBehaviour, IDamageable
{
	public int Health { get { return health;} set { health = value; } }

	[SerializeField] private int health;

	public abstract void Attack();
	public abstract void Move();
	public abstract void TakeDamage(int damage);

	protected virtual void Die()
	{
		Destroy(gameObject);
	}
}