using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour, IDamageable
{

	public int Health { get { return health; } set { health = value; } }
	private int health;

	public void TakeDamage(int damage)
	{
		if(health < 0)
		{
			DestroyWall();
		}
	}

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

	private void DestroyWall()
	{
		Debug.Log("Destroy Wall");
	}
}