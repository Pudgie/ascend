using UnityEngine;
using System.Collections;

public class platformMovement : MonoBehaviour {

	float leftEdge;
	float rightEdge;
	public int speed = 1;
	public int range;
	string currentState;

	// Use this for initialization
	void Start () {
		currentState = "movingRight";
		leftEdge = gameObject.transform.position.x - range;
		rightEdge = gameObject.transform.position.x + range;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentState == "movingRight") {
			if (gameObject.transform.position.x >= rightEdge) {
				currentState = "movingLeft";
			} else {
				gameObject.transform.Translate (0.05f * speed, 0, 0);
			}
		} else if (currentState == "movingLeft") {
			if (gameObject.transform.position.x <= leftEdge) {
				currentState = "movingRight";
			} else {
				gameObject.transform.Translate (-0.05f * speed, 0, 0);
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
