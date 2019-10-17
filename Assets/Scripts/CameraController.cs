using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// store a public reference to the Player game object, so we can refer to it's Transform
	private float moveSpeed;
	// Store a Vector3 offset from the player (a distance to place the camera from the player at all times)
	private Vector3 offset;
	public bool isMoving = true;
	// At the start of the game..
	void Start ()
	{
		moveSpeed = 1.0f;
	}

	// After the standard 'Update()' loop runs, and just before each frame is rendered..
	void LateUpdate ()
	{
		if(!isMoving)
		{
			moveSpeed = 0;
		}
		else
		{
			moveSpeed = 0.5f;
		}
		// Set the position of the Camera (the game object this script is attached to)
		// to the player's position, plus the offset amount
		transform.position += new Vector3(0,moveSpeed * Time.deltaTime,0);
	}
}