using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
	public float moveSpeed {get; set;}

	private Vector3 initPosition;

	[SerializeField]
    private GameObject[] backgroundImage;
    private float bgHeight;

	void Start ()
	{
		moveSpeed = 0.75f;
		initPosition = transform.position;
		ResetPosition();
	}



	private void Update() 
	{
		if(backgroundImage[1].transform.position.y <= Camera.main.transform.position.y)
        {
            backgroundImage[0].transform.position = Camera.main.transform.position.AddY(bgHeight).SetZ(0);

            GameObject tempHolder = backgroundImage[1];
            backgroundImage[1] = backgroundImage[0];
            backgroundImage[0] = tempHolder;
        }
	}

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

	public void ResetPosition()
	{
		transform.position = initPosition;
		var renderer = backgroundImage[0].GetComponent<Renderer>();
        bgHeight = renderer.bounds.size.y;
        backgroundImage[0].transform.position = Camera.main.transform.position.SetZ(0);
        backgroundImage[1].transform.position = backgroundImage[0].transform.position.AddY(bgHeight);
	}
}