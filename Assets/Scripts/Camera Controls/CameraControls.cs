using UnityEngine;
using System.Collections;

public class CameraControls : MonoBehaviour {

	private bool dragging;
	private Vector3 mouseDownPos;
	private Vector3 mouseDragPos;
	private Vector3 TransformChange;
	public Camera mainCamera;
	public float cameraPanSpeed;
	public float scrollWheelSensitivity;
	public bool invertScrollWheel;
	public bool invertPan;

	// Update is called once per frame
	void Update () 
	{
		// Panning camera with middle button
		if (Input.GetMouseButtonDown(2) && dragging == false)
		{
			Debug.Log("Dragging True");
			dragging = true;
			mouseDownPos = Input.mousePosition;
		}

		if (Input.GetMouseButton(2) && dragging == true)
		{
			Debug.Log("Dragging");
			mouseDragPos = Input.mousePosition;
			float xChange = mouseDragPos.x - mouseDownPos.x;
			float zChange = mouseDragPos.y - mouseDownPos.y;

			if (invertPan){
				TransformChange = new Vector3(-xChange,0,-zChange);
			}
			else {
				TransformChange = new Vector3(xChange,0,zChange);				
			}

			mainCamera.transform.position = mainCamera.transform.position + (cameraPanSpeed * TransformChange * mainCamera.orthographicSize);
		}
		else
		{
			dragging = false;
			TransformChange = Vector3.zero;
		}

		// zooming with mouse wheel
		if (invertScrollWheel) 
		{
			mainCamera.orthographicSize = Mathf.Clamp( mainCamera.orthographicSize + scrollWheelSensitivity * Input.GetAxis ("Mouse ScrollWheel") * -1.0f,
			                                          1,
			                                          1000000);
		} 
		else 
		{
			mainCamera.orthographicSize = Mathf.Clamp( mainCamera.orthographicSize + scrollWheelSensitivity * Input.GetAxis ("Mouse ScrollWheel"),
			                                          1,
			                                          1000000);
		}
	}


	

}
