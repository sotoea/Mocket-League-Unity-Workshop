using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	public int goals;

	// Use this for initialization
	void Start () {
		goals = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Gets called everytime this object collides with another collider
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "SoccerBall") {
			goals++;
		}
	}

}
