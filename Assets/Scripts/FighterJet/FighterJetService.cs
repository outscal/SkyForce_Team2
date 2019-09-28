using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.FighterJet
{
    public class FighterJetService : GenericMonoSingleton<FighterJetService>
    {
        [SerializeField]
        private PlayerJetScriptableObject fighterJetData;
        private FighterJetController fighterJet;
        void Start()
        {
            fighterJet = new FighterJetController(fighterJetData);
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                fighterJet.SetPositionTo(Camera.main.ScreenToWorldPoint(Input.mousePosition).SetZ(0));
            }
        }
    }
}
