using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterJetController
{
    private FighterJetModel model;
    private FighterJetView view;
    public FighterJetController()
    {
        model = new FighterJetModel();
        view = GameObject.Instantiate<FighterJetView>();
    }
}
