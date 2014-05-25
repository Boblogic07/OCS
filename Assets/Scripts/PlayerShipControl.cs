using UnityEngine;
using System.Collections;

public class PlayerShipControl : MonoBehaviour {

	private Vector3 forward;
	private Vector3 rotationAcc;
	private float inputRotation;
	private float rotationSpeed;

	public float forwardAcceleration;
	public float reverseAcceleration;
	public float rotationAcceleration;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)){
			gameObject.rigidbody.AddRelativeForce(Vector3.forward * forwardAcceleration);
		}

		if (Input.GetKey (KeyCode.S)) {
			gameObject.rigidbody.AddRelativeForce(Vector3.back * reverseAcceleration);
		}

		if (Input.GetKey (KeyCode.A)) {
			rotationAcc = new Vector3(0,-1,0);
			gameObject.rigidbody.AddTorque(rotationAcc);
				}
		if (Input.GetKey (KeyCode.D)) {
			rotationAcc = new Vector3(0,1,0);
			gameObject.rigidbody.AddTorque(rotationAcc);
		}
		Vector3 newRotation = new Vector3 (0, gameObject.transform.rotation.eulerAngles.y, 0);
		gameObject.transform.rotation.SetFromToRotation(gameObject.transform.rotation.eulerAngles, newRotation);
	}
}

//		inputRotation = 0;
//		if (Input.GetKey (KeyCode.W)){
//			Debug.Log("Forward");
//			velocity += forwardAcceleration * forward;
//			Debug.Log(velocity);
//			Debug.Log(forwardAcceleration);
//			Debug.Log(forward);
//		}
//		
//		if (Input.GetKey (KeyCode.S)){
//			Debug.Log("Back");
//			velocity -= reverseAcceleration * forward;
//		}
//		
//		if (Input.GetKey (KeyCode.A)){
//			inputRotation = -1;
//		}
//		
//		if (Input.GetKey (KeyCode.D)){
//			inputRotation = 1;
//			//			rotationVelocity.Set(0, rotationVelocity.eulerAngles.y + rotationAcceleration, 0,rotationVelocity.w);
//		}
//		
//		if (Input.GetMouseButton (1)) {
//			
//		}
//
//		//Update gameobject position with respect to velocity.
//		gameObject.transform.position += velocity;
////		float rotationY = gameObject.transform.rotation.y + rotationVelocity.y;
////		float rotationW = gameObject.transform.rotation.w + rotationVelocity.w;
//
//		float rotationDelta = inputRotation * rotationSpeed * Time.deltaTime;
//		gameObject.transform.Rotate (Vector3.up * rotationDelta);
//
