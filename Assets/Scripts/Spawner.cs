using UnityEngine;
using System.Collections;


public class Spawner : MonoBehaviour {
	public float maxRange = 100;
	public int numberOfObjects = 200;
	public float minX = 10;
	public float maxX = 20;
	public int lines = 100;
	public GameObject gameObj;
	public GameObject line;
	public Material[] mats;


	private GameObject[] objs;
	// Use this for initialization
	void Start () {
		objs = new GameObject[numberOfObjects];
		for (int i = 0; i < numberOfObjects; i++) {
			Vector3 loc = VectorFunctions.CreateRandomVector ();
			Vector3 scale = new Vector3(Random.Range(minX/2,maxX/2),Random.Range(minX,maxX),Random.Range(minX/2,maxX/2));
			loc *= Random.Range (maxRange/10, maxRange);
			loc += transform.position;
			GameObject currObj;

			currObj = (GameObject) GameObject.Instantiate (gameObj, loc, Quaternion.identity);
			currObj.transform.localScale = scale;
			currObj.transform.parent = transform;
			objs [i] = currObj;
		}

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
				edge.transform.parent = transform;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
