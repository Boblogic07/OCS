using UnityEngine;
using System.Collections;

public class GeneralGunController : MonoBehaviour {

	public float fireRate;
	public GameObject ammoType;
	private float lastFire;
	private float nextFire;
	private float fireInterval;

	// Use this for initialization
	void Start () {
		lastFire = 0;
		fireInterval = 1.0f / fireRate;

		}
	

	
	// Update is called once per frame
	void Update () {
		nextFire = lastFire + fireInterval;
		if (Input.GetKey (KeyCode.Space)) {
			if( Time.time > nextFire) {
				Instantiate( ammoType,gameObject.transform.position, gameObject.transform.rotation);
				lastFire = Time.time;
			}
		}
	}
}
