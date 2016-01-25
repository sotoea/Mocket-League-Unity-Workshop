using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	//public variables can be modified in real time in the inspector tab inside the unity editor
	public float speed;

	// Start gets called at the beginning of the scene
	void Start () {
		transform.position = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// FixedUpdate is called in intervals of time (frame-independent)
	// Do all rigidbody or movement computations here...
	void FixedUpdate(){
		if (Input.GetKey (KeyCode.LeftArrow))
			transform.position += Vector3.left*speed*Time.deltaTime; //new Vector3(-1,0,0);
		if (Input.GetKey (KeyCode.RightArrow))
			transform.position += Vector3.right*speed*Time.deltaTime;
		if (Input.GetKey (KeyCode.UpArrow))
			transform.position += Vector3.forward*speed*Time.deltaTime;
		if (Input.GetKey (KeyCode.DownArrow))
			transform.position += Vector3.back*speed*Time.deltaTime;

		if (Input.GetKeyDown (KeyCode.Space))
			GetComponent<Rigidbody> ().AddForce (Vector3.up*10, ForceMode.Impulse);
	}

}
