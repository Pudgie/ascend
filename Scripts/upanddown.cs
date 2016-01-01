using UnityEngine;
using System.Collections;

public class upanddown : MonoBehaviour {
	float leftEdge;
	float rightEdge;
	public int speed = 1;
	public int range;
	string currentState;
	
	// Use this for initialization
	void Start () {
		currentState = "movingDown";
		leftEdge = gameObject.transform.position.y - range;
		rightEdge = gameObject.transform.position.y + range;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentState == "movingDown") {
			if (gameObject.transform.position.y >= rightEdge) {
				currentState = "movingUp";
			} else {
				gameObject.transform.Translate (0, 0.05f * speed, 0);
			}
		} else if (currentState == "movingUp") {
			if (gameObject.transform.position.y <= leftEdge) {
				currentState = "movingDown";
			} else {
				gameObject.transform.Translate (0, -0.05f * speed, 0);
			}
		}
	}
	
	void OnCollisionEnter2D (Collision2D collider){
		collider.transform.parent = gameObject.transform;
	}
	
	void OnCollisionExit2D (Collision2D collider) {
		collider.transform.parent = null;
	}
}
