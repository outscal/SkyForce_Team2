using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyService : MonoSingletonGeneric<EnemyService>
{
    private EnemyType1 type1Obj;

    private EnemyController enemyController;
    public EnemyView enemyPrefab;

    public EnemyScriptableObject[] enemyTypes;
    void Start()
    {
        // SpwanEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public EnemyController SpwanEnemy(int type)
    {
        int index = type;   
        EnemyScriptableObject enemyScriptableObject = enemyTypes[index]; 
        EnemyModel EnemyModel = new EnemyModel(enemyScriptableObject);
        // EnemyModel EnemyModel = new EnemyModel(0.1f,100.0f,4);
        enemyController = new EnemyController(EnemyModel, enemyPrefab);
        
        return enemyController;
    }
}
