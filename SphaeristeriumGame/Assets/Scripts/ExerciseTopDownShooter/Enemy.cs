using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : ActorBase
{
	public override void Attack()
	{
		throw new System.NotImplementedException();
	}

	public override void Move()
	{
		//throw new System.NotImplementedException();
	}

	public override void TakeDamage(int damage)
	{
		Health -= damage;
		if (Health < 0)
		{
			Die();
		}

		//throw new System.NotImplementedException();
	}
}