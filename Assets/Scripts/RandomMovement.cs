using UnityEngine;
using System.Collections;

public class RandomMovement : MonoBehaviour {

	Vector3 dirr;
	Rigidbody rigidBody;
	public float maxSpeed = 3;

	// Use this for initialization
	void Start () {
		transform.rotation = Quaternion.identity;
		rigidBody = GetComponent<Rigidbody> ();
		dirr = VectorFunctions.CreateRandomVector ();
		rigidBody.useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.identity;
		transform.Rotate (new Vector3 (-90, 0, 0));
		rigidBody.AddForce (dirr, ForceMode.Impulse);
		if (rigidBody.velocity.magnitude > maxSpeed)
			rigidBody.velocity = maxSpeed * rigidBody.velocity.normalized;
	}
	void OnCollisionEnter(Collision col) {
		dirr = VectorFunctions.CreateRandomVector ();
	}


}
