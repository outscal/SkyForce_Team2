using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    [SerializeField]
    private GameObject[] backgroundImage;
    private float bgHeight;

    private void Start() 
    {
        var renderer = backgroundImage[0].GetComponent<Renderer>();
        bgHeight = renderer.bounds.size.y;
        backgroundImage[0].transform.position = Camera.main.transform.position.SetZ(0);
        backgroundImage[1].transform.position = backgroundImage[0].transform.position.AddY(bgHeight);
    }
    void Update ()
    {
        if(backgroundImage[1].transform.position.y <= Camera.main.transform.position.y)
        {
            backgroundImage[0].transform.position = Camera.main.transform.position.AddY(bgHeight).SetZ(0);

            GameObject tempHolder = backgroundImage[1];
            backgroundImage[1] = backgroundImage[0];
            backgroundImage[0] = tempHolder;
        }
    }
}
