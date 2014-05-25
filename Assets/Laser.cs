using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {

	public float beamSpeed;
	// Use this for initialization
	void Start () {
		gameObject.rigidbody.velocity = transform.forward * beamSpeed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
