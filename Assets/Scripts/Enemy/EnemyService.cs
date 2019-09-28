using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyService : MonoBehaviour
{
    public EnemyType1 type1Obj;

    public EnemyController enemyController;
    // Start is called before the first frame update
    void Start()
    {
        SpwanEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private EnemyController SpwanEnemy()
    {
        EnemyModel EnemyModel = new EnemyModel(0.1,100f,4);
        enemyController = new EnemyController(EnemyModel, enemyPrefab);
        
        return enemyController;
    }
}
