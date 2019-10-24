using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkyForce.Generics;

namespace SkyForce.Enemy
{
    public class EnemyService : GenericMonoSingleton<EnemyService>
    {
        // private EnemyType1 type1Obj;

        private EnemyController enemyController;
    
        public EnemyScriptableObject[] enemyTypes;
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public EnemyController SpwanEnemy(EnemyTypeEnum type, Vector2 position)
        {
            int index = (int)type;
            EnemyScriptableObject enemyScriptableObject = enemyTypes[index]; 
            EnemyModel EnemyModel = new EnemyModel(enemyScriptableObject);
            EnemyView EnemyView = enemyScriptableObject.EnemyView;   
            enemyController = new EnemyController(EnemyModel, EnemyView, position);
            
            return enemyController;
        }
    }
}
