using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController
{
    protected Transform playerObj;

    public EnemyController(EnemyModel model,EnemyView prefab)
    {
        enemyModel = model;
        enemyView = GameObject.Instantiate<EnemyView>(prefab);
        enemyView.Init(this);
    }

    public EnemyModel enemyModel { get; }
	public EnemyView enemyView { get; }
}
