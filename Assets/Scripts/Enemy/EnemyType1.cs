using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType1 : EnemyController
{
    public EnemyType1(EnemyModel model,EnemyView prefab) : base(model,prefab)
    {
        enemyModel = model;
        enemyView = GameObject.Instantiate<EnemyView>(prefab);
        enemyView.Init(this);
    }


    public EnemyModel enemyModel { get; }
	public EnemyView enemyView { get; }
}
