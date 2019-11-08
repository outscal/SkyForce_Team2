using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
	public float moveSpeed {get; set;}
	void Start ()
	{
		moveSpeed = 0.75f;
	}

	// After the standard 'Update()' loop runs, and just before each frame is rendered..
	void LateUpdate ()
	{
		if(moveSpeed > 0)
		{
			setCameraSpeed(moveSpeed);
		}
	}
	private void setCameraSpeed(float moveSpeed)
	{
		transform.position += new Vector3(0,moveSpeed * Time.deltaTime,0);
	}
}