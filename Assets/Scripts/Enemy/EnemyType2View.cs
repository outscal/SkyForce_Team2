using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Enemy
{
    public class EnemyType2View : EnemyView
    {
        private Vector3 target, velocity;
        // Start is called before the first frame update
        void Start()
        {
            base.Start();
            target = new Vector3(6.0f, 0f, 0f);
            velocity = Vector3.zero;
        }

        // Update is called once per frame
        void Update()
        {
            base.Update();
            // MoveUp();
            MoveStrafe();
        }

        protected void MoveStrafe()
        {
            // iTween.MoveTo(this.gameObject, iTween.Hash("position", new Vector3(5, 5,0), "time", 1.5f, "easeType", iTween.EaseType.easeInOutSine));

            // iTween.MoveBy(gameObject, iTween.Hash("x", -5, "speed", 1.0f, "easeType", iTween.EaseType.easeInOutSine));
            Vector3 pos = Camera.main.transform.position;
            pos.AddY(5.0f);
            target.y = pos.y;

            transform.position = Vector3.MoveTowards(transform.position, target, 0.1f);
            // transform.position = Vector3.SmoothDamp(transform.position, target,ref velocity, 0.5f);

            if ((Vector3.Distance(transform.position, target) < 0.5f))
            {
                Debug.Log("true");
                float x = target.x;
                float y = target.y;
                x *= -1.0f;
                target = new Vector3(x, y, 0f);     
            }
        }
    }
    
}
