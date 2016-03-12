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

	public static void CreateLines(GameObject line, GameObject[] objs, Material[] mats, int lines, Transform ctx) {
		if (line != null) {
			for (int i = 0; i < lines; i++) {
				int randIdx1 = 0;
				int randIdx2 = 0;
				while (randIdx1 == randIdx2) {
					randIdx1 = Random.Range(0, objs.Length);
					randIdx2 = Random.Range(0, objs.Length);
				}
				GameObject edge = (GameObject)GameObject.Instantiate (line);
				Lines edgeScript = edge.GetComponent<Lines> ();
				TrailRenderer renderer = edge.GetComponent<TrailRenderer> ();
				renderer.material = mats [Random.Range (0, mats.Length)];
				edgeScript.pointA = objs [randIdx1].transform;
				edgeScript.pointB = objs [randIdx2].transform;
				edge.transform.parent = ctx;
			}
		}
	}
}
