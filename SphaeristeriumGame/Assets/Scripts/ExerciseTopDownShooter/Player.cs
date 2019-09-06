using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ActorBase
{
	[SerializeField] private GameObject bullet;
	[SerializeField] private Transform muzzle;

	private void Update()
	{
		Attack();
		Move();
	}

	public override void Attack()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Instantiate(bullet.gameObject, muzzle.position, Quaternion.identity);
			bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10f);
			Debug.Log("PEW");
		}

	}

	public override void Move()
	{
		Rigidbody _rb = GetComponent<Rigidbody>();
		float _moveHorizontal = Input.GetAxis("Horizontal");
		float _moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(_moveHorizontal, 0, _moveVertical);
		_rb.velocity = movement * 5f;

		//throw new System.NotImplementedException();
	}

	public override void TakeDamage(int damage)
	{
		Debug.Log("AU");

		Health -= damage;
		if (Health < 0)
		{
			Die();
		}

		//throw new System.NotImplementedException();
	}
}