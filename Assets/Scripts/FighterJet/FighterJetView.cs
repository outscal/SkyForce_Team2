using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.FighterJet
{
    public class FighterJetView : MonoBehaviour
    {
        private FighterJetController controller;
        public void SetPositionTo(Vector3 newPosition)
        {
            transform.position = newPosition;
        }

        public Vector3 GetPosition()
        {
            return transform.position;
        }

        public void SetController(FighterJetController _controller)
        {
            controller = _controller;
        }

        private void Update() 
        {
            if (controller == null)
            {
                return;
            }

            controller.CheckAndFire();
        }
    }
}
