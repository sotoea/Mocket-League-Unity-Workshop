using UnityEngine;
using System.Collections;

public class ManouverBall : MonoBehaviour {

	public GameObject soccerBall;

	// Use this for initialization
	void Start () {
		//soccerBall = GameObject.Find ("Sphere 13");
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (transform.position, soccerBall.transform.position) < 3f) {
			soccerBall.transform.position = transform.position + Vector3.forward*1.5f + Vector3.up*0.5f;
		}
	}
}
