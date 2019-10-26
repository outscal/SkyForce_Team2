using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Enemy
{
    public class EnemyView : MonoBehaviour, IDamageable
    {

        private EnemyController enemyController;
        // Start is called before the first frame update

        // Update is called once per frame
        protected void Start()
        {
            Debug.Log("View Start");
            transform.Rotate(0,0, 180.0f);
            Destroy(gameObject,20.0f);
        }
        protected void Update()
        {
            // transform.position += Vector3.forward * -Time.deltaTime;

            if (enemyController == null)
            {
                return;
            }

            enemyController.CheckAndFire();
        }
        public void Init(EnemyController c)
        {
            Debug.Log("View INit");
            this.enemyController = c;
        }

        public Vector3 GetPosition()
        {
            return transform.position;
        }

        public bool TakeDamage(float destruction)
        {
            if(enemyController != null)
            {
                enemyController.TakeDamage(destruction);
            }
            return false;
        }

        public void DestroyEnemyView()
        {
            Destroy(gameObject);
        }
    }
}
