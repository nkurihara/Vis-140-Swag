using UnityEngine;
using System.Collections;

public class Lines : MonoBehaviour {
	public Transform pointA;
	public Transform pointB;
	bool isAtA = true;
	// Use this for initialization
	void Start () {
		if( pointA != null && pointB != null )
			transform.position = pointA.position;
	}
	
	// Update is called once per frame
	void Update () {
		if( pointA != null && pointB != null )
			transform.position = isAtA ? pointB.position : pointA.position;
		isAtA = !isAtA;
	}
}
