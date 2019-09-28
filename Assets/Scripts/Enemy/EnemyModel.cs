using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel
{
    public EnemyModel(float speed, float health, int spawnspot)
	{
        Speed = speed;
        Health = health;
        Spawnspot = spawnspot;

        PlayerId = Random.Range(1, 10000);
	}

    public float Speed { get; }
    public float Health { get; set;}
    public int Spawnspot { get; }
    public int PlayerId { get; }
}
