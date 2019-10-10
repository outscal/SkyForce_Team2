using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController
{
    protected Transform playerObj;

    public EnemyController(EnemyModel model,EnemyView prefab,Vector2 position)
    {
        enemyModel = model;
        
        enemyView = GameObject.Instantiate<EnemyView>(prefab,new Vector3(position.x, position.y, 0),Quaternion.identity);
        enemyView.Init(this);
        // Debug.Log(" type -" + model.EnemyType);
    }

    public EnemyModel enemyModel { get; }
	public EnemyView enemyView { get; }
}
