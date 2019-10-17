using UnityEngine;
using System.Collections;

public class MoveSample : MonoBehaviour
{	
	void Start(){
		iTween.MoveBy(gameObject, iTween.Hash("x", -3 , "y", 3, "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", .1));
	}
}

