using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Player
{
    public class PlayerInputHandler : MonoBehaviour
    {
        void Update()
        {
            #if UNITY_EDITOR
            if (Input.GetMouseButton(0))
            {
                    Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition).SetZ(0);
                    PlayerService.Instance.SetFighterJetTo(position);
            }
            #elif UNITY_ANDROID
            Debug.LogError("Need to implement Android Input");
            
            #else
            Debug.LogError("Unknown platform detected");

            #endif
        }
    }
}
