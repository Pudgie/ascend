using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	// public float rotationSpeed = 100;
	public float jump = 8;
	public float speed = 2f;
	public GameObject originOne;
	public GameObject originTwo;

	private float distance;
	private float distance2;
	private bool onGround = true;
	private bool amILeft = true;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
//		distance = Vector2.Distance (gameObject.transform.position, originOne.transform.position);
//		distance2 = Vector2.Distance (gameObject.transform.position, originTwo.transform.position);

		if (Input.GetKeyDown(KeyCode.Space) && onGround) {
			rigidbody2D.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
		}
		else if (Input.GetKey(KeyCode.LeftArrow)){
			rigidbody2D.velocity = new Vector2 (-speed, rigidbody2D.velocity.y);
			//Debug.Log ("velocity set to "+rigidbody2D.velocity);
		}
		else if (Input.GetKey(KeyCode.RightArrow)){
			rigidbody2D.velocity = new Vector2 (speed, rigidbody2D.velocity.y);
			//Debug.Log ("velocity set to "+rigidbody2D.velocity);
		}
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//Debug.Log ("before update position, position is " + transform.position);
			UpdatePosition ();
			//Debug.Log ("after update position, position is " + transform.position);
		}
		if (gameObject.transform.position.x < originTwo.transform.position.x) {
			amILeft = true;
			gameObject.renderer.material.color = Color.white;
		}
		else if (gameObject.transform.position.x > originTwo.transform.position.x) {
			amILeft = false;
			gameObject.renderer.material.color = Color.black;
		}
	}
	
	// to avoid double-jumping
	public void OnCollisionStay2D(Collision2D collider) {
		if (collider.gameObject.tag == "ground") {
			onGround = true;
		}
	}

	public void OnCollisionExit2D() {
		onGround = false;
	}

	public void UpdatePosition () {
		Debug.Log ("left? " + amILeft);
		if (amILeft) {
			distance = gameObject.transform.position.x - originOne.transform.position.x;
			Debug.Log ("Distance: "+distance);
			Vector2 tempPosition = new Vector2 (distance + originTwo.transform.position.x, gameObject.transform.position.y);	
			gameObject.transform.position= tempPosition;
			// amILeft = false;
		}
		else if(!amILeft) {
			distance2 = gameObject.transform.position.x - originTwo.transform.position.x;
			Debug.Log ("Distance2: "+distance2);
			Vector2 tempPosition2 = new Vector2 (distance2 + originOne.transform.position.x, gameObject.transform.position.y);
			gameObject.transform.position= tempPosition2;
			// amILeft = true;
		}
	}
}