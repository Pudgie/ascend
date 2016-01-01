using UnityEngine;
using System.Collections;

public class end : MonoBehaviour {

	public GameObject wave1;
	public GameObject wave2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.color = Color.red;
	}

	void OnCollisionEnter2D (Collision2D collider) {
		if (collider.gameObject.tag == "Player") {
			wave1.transform.Translate (0, 0f, 0);
			wave2.transform.Translate (0, 0f, 0);
			Application.LoadLevel("win");
		}
	}
}
