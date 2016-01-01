using UnityEngine;
using System.Collections;

public class wave : MonoBehaviour {

	private double speed = 1.0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y > -39 && gameObject.transform.position.y <= -35) {
			gameObject.transform.Translate (0, 0.0008f, 0);
		}
		else if (gameObject.transform.position.y > -35 && gameObject.transform.position.y <= -29) {
			gameObject.transform.Translate (0, 0.003f, 0);
		}
		else if (gameObject.transform.position.y > -29 && gameObject.transform.position.y <= -23) {
			gameObject.transform.Translate (0, 0.008f, 0); 
		}
		else if (gameObject.transform.position.y > -23 && gameObject.transform.position.y <= -18) {
			gameObject.transform.Translate (0, 0.013f, 0); 
		}
		else if (gameObject.transform.position.y > -18 && gameObject.transform.position.y <= 10) {
			gameObject.transform.Translate (0, 0.023f, 0); 
		}
		else {
			gameObject.transform.Translate (0, 0.05f, 0); 
		}
	}

	void OnCollisionEnter2D (Collision2D collider) {
		if (collider.gameObject.tag == "Player") {
			gameObject.transform.Translate (0, 0f, 0);
			Application.LoadLevel("gameover");
		}
	}
}
