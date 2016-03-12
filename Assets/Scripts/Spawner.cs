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


	public GameObject[] objs;
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

		Lines.CreateLines (line, objs, mats, lines, this.gameObject.transform);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
