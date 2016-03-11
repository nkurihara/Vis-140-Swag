using UnityEngine;
using System.Collections;

public class FlightControl : MonoBehaviour {
	public float speed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftShift)) {
			
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.Space)) {
			transform.position += Vector3.up * speed * Time.deltaTime;
		}

	}
}
